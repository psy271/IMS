using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace IMS
{

    public partial class CodeComboBox : ComboBox, ISupportInitialize
    {
        bool _EmptyEnable;
        string _EmptyText;
        string _CodeMajor;

        [Category("Code")]
        public string EmptyText { get => _EmptyText; set => _EmptyText = value; }
        [Category("Code")]
        public bool EmptyEnable { get => _EmptyEnable; set => _EmptyEnable = value; }
        [Category("Code")]
        public string CodeMajor { get => _CodeMajor; set => _CodeMajor = value; }
       
        
        

        public CodeComboBox()
        {
            InitializeComponent();
            
        }

        public void BeginInit() { }
        public void EndInit()
        {
            GetCode();
        }

        private void GetCode()
        {
            if (!this.DesignMode && !string.IsNullOrEmpty(_CodeMajor))
            {
                SqlCommand cmd = new SqlCommand("USP_CODE_R");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MAJOR_CD", _CodeMajor);

                DataSet ds = DBCon.DB_Execute_Dataset(cmd);

                if (ds.Tables.Count > 0)
                {
                    if (_EmptyEnable)
                    {
                        DataRow emptyRow = ds.Tables[0].NewRow();
                        emptyRow["VALUE"] = "";
                        emptyRow["NAME"] = _EmptyText;

                        ds.Tables[0].Rows.InsertAt(emptyRow, 0);
                    }
                    this.DataSource = ds.Tables[0].DefaultView;
                }
                this.ValueMember = "VALUE";
                this.DisplayMember = "NAME";

                ds.Dispose();
            }

        }
    }
}
