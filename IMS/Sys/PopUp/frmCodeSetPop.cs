using Common;
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

namespace IMS.Sys.PopUp
{
    public partial class frmCodeSetPop : Form
    {
        
        public frmCodeSetPop()
        {
            InitializeComponent();
        }

        public frmCodeSetPop(DataGridViewRow code)
        {
            InitializeComponent();
            txtMajor.ReadOnly = true;
            txtMinor.ReadOnly = true;
            txtMajor.Text = code.Cells["MAJOR_CD"].Value.ToString();
            txtMinor.Text = code.Cells["MINOR_CD"].Value.ToString();
            txtCodeNM.Text = code.Cells["CD_NM"].Value.ToString();
            cmbYN.SelectedValue = code.Cells["SYS_FLAG"].Value.ToString();
            txtRel_CD1.Text = code.Cells["REL_CD1"].Value.ToString();
            txtRel_CD2.Text = code.Cells["REL_CD2"].Value.ToString();
            txtRel_CD3.Text = code.Cells["REL_CD3"].Value.ToString();
            txtExt.Text = code.Cells["EXT_CD"].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            SqlCommand cmd;
            if (txtMajor.ReadOnly)
                cmd = new SqlCommand("USP_CODE_U");
            else
                cmd = new SqlCommand("USP_CODE_I");

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MAJOR_CD", txtMajor.Text);
            cmd.Parameters.AddWithValue("@MINOR_CD", txtMinor.Text);
            cmd.Parameters.AddWithValue("@CD_NM", txtCodeNM.Text);
            cmd.Parameters.AddWithValue("@SYS_FLAG", cmbYN.SelectedValue);
            cmd.Parameters.AddWithValue("@CD_NM_EN", "");
            cmd.Parameters.AddWithValue("@REL_CD1", txtRel_CD1.Text);
            cmd.Parameters.AddWithValue("@REL_CD2", txtRel_CD2.Text);
            cmd.Parameters.AddWithValue("@REL_CD3", txtRel_CD3.Text);
            cmd.Parameters.AddWithValue("@EXT_CD", txtExt.Text);
            cmd.Parameters.AddWithValue("@LEVEL_CD", txtLevel.Text);
            cmd.Parameters.AddWithValue("@USER_ID", "");
            cmd.Parameters.AddWithValue("@TERMINAL_NO", "");
            cmd.Parameters.AddWithValue("@REG_ID ", GVariant.LOGIN_ID);

            string Result = DBCon.DB_ExecuteReturn(cmd);

            if (Result == "1")
            {
                MessageBox.Show("저장 되었습니다.");
                this.DialogResult = DialogResult.OK;
            }
            else if (Result == "-2")
            {
                MessageBox.Show("해당코드가 존재합니다.");
            }
            else if (Result == "-1")
            {
                MessageBox.Show("저장에 실패하였습니다.");
            }
        }

    }
}
