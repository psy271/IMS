using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace IMS
{
    public partial class frm0001 : SubFormBase
    {
        private TreeNode selectedNode = null;

        private TreeNode candidateNode = null;
        public frm0001()
        {
            InitializeComponent();
            
        }
        private void frm0001_Load(object sender, EventArgs e)
        {
            GetMenu();
        }

        private void TreeViewInit(TreeNode tNode ,DataTable dtMenu)
        {
            var menu = from p in dtMenu.AsEnumerable()
                       where p["PARENT_ID"].ToString() ==  tNode.Name
                       orderby Convert.ToInt32(p["DISPLAY_ORDER"])
                       select p;
            TreeNode tr;
           
            foreach (DataRow dr in menu)
            {
                tr = new TreeNode();
                tr.Name = dr["MENU_ID"].ToString();
                tr.Text = dr["MENU_NAME"].ToString();
                //MENU_ID;MENU_NAME;FORM;USE_YN
                tr.Tag = dr["MENU_ID"].ToString() + ";" + dr["MENU_NAME"].ToString() + ";" + dr["FORM"].ToString() + ";" + dr["USE_YN"].ToString(); ;
                tNode.Nodes.Add(tr);
                TreeViewInit(tr, dtMenu);
              
            }
        }

        private void GetMenu()
        {
            SqlCommand cmd = new SqlCommand("USP_MENU_Q");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            DataSet dsMenu = DBCon.DB_Execute_Dataset(cmd);

            ((frmMain)this.MdiParent).SetStatusText(String.Format("총 {0}건 조회 되었습니다.", dsMenu.Tables[0].Rows.Count));

            treeView1.Nodes.Clear();

            TreeNode tr = new TreeNode();
            tr.Name = "0";
            tr.Text = "/";
            treeView1.Nodes.Add(tr);
            TreeViewInit(tr, dsMenu.Tables[0]);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("변경하시겠습니까?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaveMenu(txtMenuId.Text, txtMenuNm.Text, txtForm.Text, txtParent.Text, txtDisplay.Text, cmbUesYn.SelectedItem.ToString());
            }
        }

        private string SaveMenu(string MENU_ID, string MENU_NAME, string FORM, string PARENT_ID, string DISPLAY_ORDER, string USE_YN)
        {
            SqlCommand cmd = new SqlCommand("USP_MENU_IU");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MENU_ID", MENU_ID);
            cmd.Parameters.AddWithValue("@MENU_NAME", MENU_NAME);
            cmd.Parameters.AddWithValue("@FORM", FORM);
            cmd.Parameters.AddWithValue("@PARENT_ID", PARENT_ID);
            cmd.Parameters.AddWithValue("@DISPLAY_ORDER", DISPLAY_ORDER);
            cmd.Parameters.AddWithValue("@USE_YN", USE_YN);
            cmd.Parameters.AddWithValue("@REG_ID", GVariant.LOGIN_ID);

            return DBCon.DB_ExecuteReturn(cmd);
        }

    
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnRemove.Enabled = false; ;
            if (e.Node.Tag != null && e.Node.Tag != "")
            {
                //MENU_ID;MENU_NAME;FORM;USE_YN
                string[] menuinfo = e.Node.Tag.ToString().Split(';');
                if (menuinfo.Length >= 4)
                {
                    txtMenuId.Text = menuinfo[0];
                    txtMenuNm.Text = menuinfo[1];
                    txtForm.Text = menuinfo[2];
                    cmbUesYn.SelectedItem = menuinfo[3];
                    txtParent.Text = e.Node.Parent.Name;
                    txtDisplay.Text = (e.Node.Index + 1).ToString();
                        
                }
                if (menuinfo[0] == "")
                    btnRemove.Enabled = true;

            }

            
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            this.selectedNode = this.treeView1.GetNodeAt(e.X, e.Y);
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this.isMoveAble(e)) return;
            //바로이전마우스Over 된Node 의색깔을원상복귀시킨다
            if (this.candidateNode != null) this.candidateNode.BackColor = this.treeView1.BackColor;
            this.candidateNode = this.treeView1.GetNodeAt(e.X, e.Y);
            this.candidateNode.BackColor = Color.Gray;
            
        }

        private void treeView1_MouseUp(object sender, MouseEventArgs e)
        {
            TreeNode goalNode = null;
            try
            {
                if (!this.isMoveAble(e)) return;
                goalNode = this.treeView1.GetNodeAt(e.X, e.Y);
                //자기자신에게추가하는것을불허용
                                
                if (this.selectedNode == goalNode) return;
                //원래부모노드일경우추가불필요
                if (this.selectedNode.Parent == goalNode) return;
                //부모노드가 자식으로 이동 방지
                if (isChildNode(goalNode))
                    return;

                
                //실제Node 를추가하는부분
                this.treeView1.Nodes.Remove(this.selectedNode);
                goalNode.Nodes.Add(this.selectedNode);
                goalNode.Expand();
                this.treeView1.Update();
                //이동한Node 를TreeView 의현재선택된노드로강조한다
                this.treeView1.SelectedNode = this.selectedNode;

            }
            catch (Exception ex)
            {
                MessageBox.Show("노드이동중예외발생: " + ex.Message);
            }
            finally
            {
                if(goalNode != null)
                goalNode.BackColor = this.treeView1.BackColor;
            }
        }

        private bool isChildNode(TreeNode node)
        {
            if (node == null)
                return false;
            else if (node == this.selectedNode)
                return true;
            else
            {
                return isChildNode(node.Parent);
            }
        }

        private bool isMoveAble(System.Windows.Forms.MouseEventArgs e)
        {
            //마우스왼쪽버턴일경우에만허용
            if (e.Button != MouseButtons.Left) return false;
            //해당좌표에Node 가있을경우에만허용
            if (this.treeView1.GetNodeAt(e.X, e.Y) == null) return false;
            //선택된Node 가있을경우에만허용
            if (this.selectedNode == null) return false;
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MENU_ID;MENU_NAME;FORM;USE_YN
            if (treeView1.SelectedNode != null)
            {
                TreeNode newnode = new TreeNode();
                newnode.Text = "New";
                string newmenu = ";New;;Y";

                newnode.Tag = newmenu;
                treeView1.SelectedNode.Nodes.Add(newnode);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void btnAllSave_Click(object sender, EventArgs e)
        {
            ChildSave(treeView1.Nodes[0]);
        }

        private bool ChildSave(TreeNode node)
        {
            bool bresult = false;
            foreach (TreeNode tr in node.Nodes)
            {

                //MENU_ID;MENU_NAME;FORM;USE_YN
                string[] info = tr.Tag.ToString().Split(';');
                string result = SaveMenu(info[0], info[1], info[2], tr.Parent.Name, (tr.Index + 1).ToString(), info[3]);

                if (result == "1")
                    bresult = ChildSave(tr);
                else
                {
                    MessageBox.Show("저장중 오류");
                    return false;
                }
            }
            return bresult;
        }
    }
}
