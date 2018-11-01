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
    public partial class frm0003 : SubFormBase
    {
        public frm0003()
        {
            InitializeComponent();
            
        }
        private void frm0002_Load(object sender, EventArgs e)
        {
            GetGroup();
        }

        private void Gridinit()
        {
            foreach (DataGridViewColumn col in dgvGroup.Columns)
            {
                switch (col.HeaderText)
                {
                    case "GROUP_ID" :
                        col.HeaderText = "그룹아이디";
                        break;
                    case "GROUP_NAME":
                        //col.Visible = false;
                        col.HeaderText = "그룹명";
                        break;
                    case "REMARK":
                        col.HeaderText = "비고";
                        break;
                    case "USE_YN":
                        col.HeaderText = "사용유무";
                        break;
                    case "REG_ID":
                        col.HeaderText = "등록자";
                        break;
                    case "REG_DATE":
                        col.HeaderText = "등록일시";
                        col.DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss";
                        break;
                }
            }

        }

        private void GetGroup()
        {
            SqlCommand cmd = new SqlCommand("USP_GROUP_Q");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            DataSet dsUser = DBCon.DB_Execute_Dataset(cmd);

            ((frmMain)this.MdiParent).SetStatusText(String.Format("총 {0}건 조회 되었습니다.",dsUser.Tables[0].Rows.Count));

            dgvGroup.DataSource = dsUser.Tables[0];
            Gridinit();
        }

        private void dgvUser_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGroup.SelectedRows.Count > 0)
            {
                txtGroup_ID.ReadOnly = true;
                btnSave.Text = "저장";
                txtGroup_ID.Text = dgvGroup.SelectedRows[0].Cells["GROUP_ID"].Value.ToString();
                txtGroup_Name.Text = dgvGroup.SelectedRows[0].Cells["GROUP_NAME"].Value.ToString();
                txtRemark.Text = dgvGroup.SelectedRows[0].Cells["REMARK"].Value.ToString();
                cmbUesYn.SelectedItem = dgvGroup.SelectedRows[0].Cells["USE_YN"].Value.ToString();

                tabAll_SelectedIndexChanged(null, null);
                
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvGroup.ClearSelection();
            
            btnSave.Text = "등록";
            txtGroup_ID.Text = "";
            txtGroup_Name.Text = "";
            txtRemark.Text ="";
            cmbUesYn.SelectedItem = "Y";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(btnSave.Text  + " 하시겠습니까?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (String.IsNullOrWhiteSpace(txtGroup_Name.Text))
                {
                    MessageBox.Show("그룹명을 입력하세요.");
                    return;
                }


                SaveGroup(btnSave.Text == "등록" ? "N" : "U");
            }
        }

        private void SaveGroup(string type)
        {
            SqlCommand cmd = new SqlCommand("USP_GROUP_IU");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@GROUP_ID", txtGroup_ID.Text);
            cmd.Parameters.AddWithValue("@GROUP_NAME", txtGroup_Name.Text);
            cmd.Parameters.AddWithValue("@REMARK", txtRemark.Text);
            cmd.Parameters.AddWithValue("@USE_YN", cmbUesYn.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@REG_ID", GVariant.LOGIN_ID);

            string Result = DBCon.DB_ExecuteReturn(cmd);

            if (Result == "1")
            {
                MessageBox.Show((type == "N" ? "등록" : type == "D" ? "삭제" : "저장") + " 되었습니다.");
                GetGroup();
            }
            else if (Result == "-1")
            {
                MessageBox.Show("아이디가 존재합니다.");
            }
        }

        private void GetGroupUser(string Group_id)
        {

            listUser.Items.Clear();
            listCurrent.Items.Clear();

            SqlCommand cmd = new SqlCommand("USP_GROUP_USER_Q");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GROUP_ID", txtGroup_ID.Text);
            DataSet dsUser = DBCon.DB_Execute_Dataset(cmd);


            if (dsUser.Tables.Count > 0 && dsUser.Tables[0].Rows.Count > 0)
            {
                var user = from p in dsUser.Tables[0].AsEnumerable()
                           where p["GROUP_ID"].ToString() == "-1"
                           select p;

                var Currentuser = from p in dsUser.Tables[0].AsEnumerable()
                           where p["GROUP_ID"].ToString() == Group_id
                                  select p;


                ListViewItem item;
                foreach (var dr in user)
                {
                    item = new ListViewItem(String.Format("{0}[{1}]", dr["USR_ID"].ToString(), dr["USR_NM"].ToString()));
                    item.SubItems.Add(dr["USR_ID"].ToString());
                    listUser.Items.Add(item);
                }

                foreach (var dr in Currentuser)
                {
                    item = new ListViewItem(String.Format("{0}[{1}]", dr["USR_ID"].ToString(), dr["USR_NM"].ToString()));
                    item.SubItems.Add(dr["USR_ID"].ToString());
                    listCurrent.Items.Add(item);
                }

            }
            
        }


        private void GetGroupMenu(string Group_id)
        {

            SqlCommand cmd = new SqlCommand("USP_GROUP_MENU_Q");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@GROUP_ID", txtGroup_ID.Text);
            DataSet dsUser = DBCon.DB_Execute_Dataset(cmd);


            if (dsUser.Tables.Count > 0 && dsUser.Tables[0].Rows.Count > 0)
            {
                var menu = from p in dsUser.Tables[0].AsEnumerable()
                           where p["GROUP_ID"].ToString() == "-1"
                           select p;

                var Currenmenu = from p in dsUser.Tables[0].AsEnumerable()
                                  where p["GROUP_ID"].ToString() == Group_id
                                  select p;


                ListViewItem item;
                foreach (var dr in menu)
                {
                    item = new ListViewItem(String.Format("{0}[{1}]",  dr["MENU_NAME"].ToString(), dr["MENU_ID"].ToString()));
                    item.SubItems.Add(dr["MENU_ID"].ToString());
                    listMenu.Items.Add(item);
                }

                foreach (var dr in Currenmenu)
                {
                    item = new ListViewItem(String.Format("{0}[{1}]", dr["MENU_NAME"].ToString(), dr["MENU_ID"].ToString()));
                    item.SubItems.Add(dr["MENU_ID"].ToString());
                    listCurrent.Items.Add(item);
                }

            }

        }

        private void tabAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            listUser.Items.Clear();
            listCurrent.Items.Clear();
            listMenu.Items.Clear();

            if (tabAll.SelectedIndex == 0)
            {
                if (dgvGroup.SelectedRows.Count > 0)
                {
                    GetGroupUser(dgvGroup.SelectedRows[0].Cells["GROUP_ID"].Value.ToString());
                }

            }
            else
            {
                if (dgvGroup.SelectedRows.Count > 0)
                {
                    GetGroupMenu(dgvGroup.SelectedRows[0].Cells["GROUP_ID"].Value.ToString());
                }
            }
        }

        private void btnAddCurrent_Click(object sender, EventArgs e)
        {
            ListView lv;
            if (tabAll.SelectedIndex == 0)
            {
                lv = listUser;
            }
            else
            {
                lv = listMenu;
            }

            
            if (lv.SelectedItems.Count > 0)
            {
                ListViewItem item = (ListViewItem)lv.SelectedItems[0].Clone();
                listCurrent.Items.Add(item);
                lv.Items.Remove(lv.SelectedItems[0]);
            }


        }

        private void btnRemoveCurrent_Click(object sender, EventArgs e)
        {
            ListView lv;
            if (tabAll.SelectedIndex == 0)
            {
                lv = listUser;
            }
            else
            {
                lv = listMenu;
            }


            if (listCurrent.SelectedItems.Count > 0)
            {
                
                ListViewItem item = (ListViewItem)listCurrent.SelectedItems[0].Clone();
                lv.Items.Add(item);
                listCurrent.Items.Remove(listCurrent.SelectedItems[0]);
            }
        }

        private void btnCurrentSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show((tabAll.SelectedIndex == 0 ? "사용자를" : "메뉴를") + " 저장 하시겠습니까?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string currents = "";
                string type = tabAll.SelectedIndex == 0 ? "U" : "M";
                foreach (ListViewItem c in listCurrent.Items)
                {
                    currents += c.SubItems[1].Text + ";";
                }
                currents = currents.Length > 0 ? currents.Substring(0, currents.Length - 1) : currents;

                SaveCurrent(type, currents);
            }
        }

        private void SaveCurrent(string type, string Currents)
        {

            SqlCommand cmd= new SqlCommand(type=="U" ? "USP_GROUP_USER_SAVE" : "USP_GROUP_MENU_SAVE");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@GROUP_ID", txtGroup_ID.Text);
            cmd.Parameters.AddWithValue(type == "U" ? "@USERS" : "@MENUS", Currents);
            cmd.Parameters.AddWithValue("@REG_ID", GVariant.LOGIN_ID);

            string Result = DBCon.DB_ExecuteReturn(cmd);
            if (Result == "1")
            {
                MessageBox.Show(" 저장 되었습니다.");
                tabAll_SelectedIndexChanged(null,null);
            }
            else if (Result == "-1")
            {
                MessageBox.Show("처리중 오류");
            }
        }
    }
}
