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
    public partial class frm0002 : SubFormBase
    {
        public frm0002()
        {
            InitializeComponent();
            
        }
        private void frm0002_Load(object sender, EventArgs e)
        {
            GetUser();
        }

        private void Gridinit()
        {
            foreach (DataGridViewColumn col in dgvUser.Columns)
            {
                switch (col.HeaderText)
                {
                    case "USR_ID" :
                        col.HeaderText = "아이디";
                        break;
                    case "USR_PW":
                        col.Visible = false;
                        break;
                    case "USR_NM":
                        col.HeaderText = "이름";
                        break;
                    case "EMP_NO":
                        col.HeaderText = "사번";
                        break;
                    case "STATUS":
                        col.HeaderText = "상태";
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

        private void GetUser()
        {
            SqlCommand cmd = new SqlCommand("USP_USER_Q");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            DataSet dsUser = DBCon.DB_Execute_Dataset(cmd);

            ((frmMain)this.MdiParent).SetStatusText(String.Format("총 {0}건 조회 되었습니다.",dsUser.Tables[0].Rows.Count));

            dgvUser.DataSource = dsUser.Tables[0];
            Gridinit();
        }

        private void dgvUser_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                txtUsr_ID.ReadOnly = true;
                btnSave.Text = "저장";
                txtUsr_ID.Text = dgvUser.SelectedRows[0].Cells["USR_ID"].Value.ToString();
                txtUsr_Name.Text = dgvUser.SelectedRows[0].Cells["USR_NM"].Value.ToString();
                txtEmp_No.Text = dgvUser.SelectedRows[0].Cells["EMP_NO"].Value.ToString();
                txtUsr_Pw.Text = dgvUser.SelectedRows[0].Cells["USR_PW"].Value.ToString();
                txtStatus.Text = dgvUser.SelectedRows[0].Cells["STATUS"].Value.ToString();

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvUser.ClearSelection();
            txtUsr_ID.ReadOnly = false;
            btnSave.Text = "등록";
            txtUsr_ID.Text = "";
            txtUsr_Name.Text = "";
            txtEmp_No.Text = "";
            txtUsr_Pw.Text = "";
            txtStatus.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(btnSave.Text + " 하시겠습니까?","Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (txtUsr_ID.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("아이디를 입력하세요.");
                    return;
                }
                else if (txtUsr_Pw.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("비밀번호를 입력하세요.");
                    return;
                }
                else if (txtUsr_Name.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("이름을 입력하세요.");
                    return;
                }

                SaveUser(btnSave.Text == "등록" ? "N" : "U");
            }
            
        }

        private void SaveUser(string type)
        {
            SqlCommand cmd = new SqlCommand("USP_USER_IUD");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TYPE", type);
            cmd.Parameters.AddWithValue("@USR_ID", txtUsr_ID.Text);
            cmd.Parameters.AddWithValue("@USR_PW", txtUsr_Pw.Text);
            cmd.Parameters.AddWithValue("@USR_NM", txtUsr_Name.Text);
            cmd.Parameters.AddWithValue("@EMP_NO", txtEmp_No.Text);
            cmd.Parameters.AddWithValue("@STATUS", txtStatus.Text);
            cmd.Parameters.AddWithValue("@REG_ID", GVariant.LOGIN_ID);

            string Result = DBCon.DB_ExecuteReturn(cmd);

            if (Result == "1")
            {
                MessageBox.Show((type == "N" ? "등록" : type == "D" ? "삭제" : "저장") + " 되었습니다.");
                GetUser();
            }
            else if (Result == "-1")
            {
                MessageBox.Show("아이디가 존재합니다.");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제하시겠습니까?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaveUser("D");
            }
        }
    }
}
