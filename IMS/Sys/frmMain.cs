using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Common;
using System.Reflection;

namespace IMS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            init();
        }


        public void init()
        {
            GVariant.LOGIN_ID = "admin";
            DBCon.ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["dbConn"];

            SetMenu();
            

        }

        public void SetMenu()
        {
            SqlCommand cmd = new SqlCommand("USP_USER_MENU_Q");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@USR_ID", GVariant.LOGIN_ID);

            DataSet dsMenu = DBCon.DB_Execute_Dataset(cmd);

            ToolStripMenuItem MnuStripItem;
            if (dsMenu.Tables.Count > 0 && dsMenu.Tables[0].Rows.Count > 0)
            {

                IEnumerable<DataRow> r_menu =   from p in dsMenu.Tables[0].AsEnumerable()
                                                where p.Field<Int64>("PARENT_ID") == 0
                                                orderby p.Field <Int32>("DISPLAY_ORDER") ascending
                                                select p;

                
                foreach (DataRow dr in r_menu)
                {
                    MnuStripItem = new ToolStripMenuItem();
                    MnuStripItem.Text = dr["MENU_NAME"].ToString();
                    MnuStripItem.Tag = dr["FORM"] == null ? "" : dr["FORM"].ToString();
                    if (MnuStripItem.Tag != "")
                    {
                        MnuStripItem.Click += new System.EventHandler(MenuClick);
                    }

                    SubMenu(MnuStripItem, dr["MENU_ID"].ToString(), dsMenu.Tables[0]);

                    menuStrip1.Items.Add(MnuStripItem);
                }
            }
        }

        public void SubMenu(ToolStripMenuItem MnuItems, string menu_id,DataTable dtMenu)
        {

            IEnumerable<DataRow> menu = from p in dtMenu.AsEnumerable()
                                          where p.Field<Int64>("PARENT_ID") == Int64.Parse(menu_id)
                                          orderby p.Field<Int32>("DISPLAY_ORDER") ascending
                                          select p;
            if (menu == null || menu.Count() <= 0)
                return;

            foreach (DataRow dr in menu)
            {
                ToolStripMenuItem SSSMenu = new ToolStripMenuItem();
                SSSMenu.Text = dr["MENU_NAME"].ToString();
                SSSMenu.Tag = dr["FORM"] == null ? "" : dr["FORM"].ToString();
                if (SSSMenu.Tag != "")
                {
                    SSSMenu.Click += new System.EventHandler(MenuClick);
                }

                SubMenu(SSSMenu, dr["MENU_ID"].ToString(), dtMenu);

                MnuItems.DropDownItems.Add(SSSMenu);

            }
            
        }

        public void MenuClick(object sender, System.EventArgs e)
        {
            
           
            string form = ((ToolStripMenuItem)sender).Tag.ToString();
            if (this.ActiveMdiChild != null && this.ActiveMdiChild.Name == form)
                return;

            foreach (Form f in this.MdiChildren)
            {
            
                f.Dispose();
                f.Close();
            }


            string nameSpace = "IMS"; //네임스페이스 명

            Assembly cuasm = Assembly.GetExecutingAssembly();

            //string Format 의 따옴표와 마침표 주의!!
            SubFormBase frm = (SubFormBase)cuasm.CreateInstance(string.Format("{0}.{1}", nameSpace, form));
            frm.Init((Form)this, ((ToolStripMenuItem)sender).Text);
            frm.MdiParent = this;

            frm.Show();


        }

        public void SetStatusText(string msg)
        {
            lblStatus.Text = msg;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBCon.DB_Close();
        }
    }
}
