using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class SubFormBase : Form
    {
        public SubFormBase()
        {
            InitializeComponent();

        }


        public void Init(Form main,string MenuNm)
        {
            
            this.MdiParent = main;
            this.Dock = DockStyle.Fill;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.lblTitle.Text = MenuNm;
            
            
          
        }
    }
}
