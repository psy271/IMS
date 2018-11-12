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
    public partial class frm0004 : SubFormBase
    {
        bool bAddbutton = false;
        public frm0004()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IMS.Sys.PopUp.frmCodeSetPop frm = new Sys.PopUp.frmCodeSetPop();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                GetCode();
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            GetCode();
        }

        private void GetCode()
        {
            SqlCommand cmd = new SqlCommand("USP_CODE_Q");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MAJOR_CD", cmbMajor.SelectedValue == null ? "" : cmbMajor.SelectedValue);

            DataSet ds = DBCon.DB_Execute_Dataset(cmd);
            dgvCode.DataSource = ds.Tables[0];
            if (!bAddbutton)
            {
                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = "button";
                column.HeaderText = "수정";
                dgvCode.Columns.Insert(0, column);
                bAddbutton = true;
            }
            foreach (DataGridViewRow dr in dgvCode.Rows)
            {
                dr.Cells["button"].Value = "수정";

            }
            Gridinit();
        }

        private void Gridinit()
        {
            foreach (DataGridViewColumn col in dgvCode.Columns)
            {
                switch (col.HeaderText)
                {
                    case "button":
                        col.HeaderText = "수정";
                        break;
                    case "MAJOR_CD":
                        col.HeaderText = "Major 코드";
                        break;
                    case "MINOR_CD":
                        //col.Visible = false;
                        col.HeaderText = "Minor 코드";
                        break;
                    case "CD_NM":
                        col.HeaderText = "코드명";
                        break;
                    case "SYS_FLAG":
                        col.HeaderText = "시스템 구분";
                        break;
                    case "REL_CD1":
                        col.HeaderText = "코드1";
                        break;
                    case "REL_CD2":
                        col.HeaderText = "코드2";
                        break;
                    case "REL_CD3":
                        col.HeaderText = "코드3";
                        break;
                    case "EXT_CD":
                        col.HeaderText = "확장코드1 ";
                        break;
                    case "LAST_UPDATE_PNAME":
                        col.HeaderText = "수정자";
                        break;
                    case "LAST_UPDATE_DATE":
                        col.HeaderText = "수정일";
                        break;
                }
            }
            
        }

        private void dgvCode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                showEdit(e.RowIndex);
            }
        }

        private void showEdit(int rowIndex)
        {
            IMS.Sys.PopUp.frmCodeSetPop frm = new Sys.PopUp.frmCodeSetPop(dgvCode.Rows[rowIndex]);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                GetCode();
            }
        }
    }

}
