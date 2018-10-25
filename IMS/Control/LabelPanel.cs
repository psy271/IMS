using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.Control
{
    public partial class LabelPanel : UserControl
    {
        private int _Count;
        Label[] labels;
        public LabelPanel()
        {
            InitializeComponent();
            
        }

        public int Count { get => _Count; set => _Count = value; }
        public Label[] Labels { get => labels; set => labels = value; }

        private void Init()
        {
            labels = new Label[_Count];
            int l_width = this.Width / _Count;
            for (int i = 0; i < _Count; i++)
            {
                labels[i] = new Label();
                labels[i].AutoSize = false;
                labels[i].Text = i.ToString();
                labels[i].Size = new Size(l_width, this.Height);
                labels[i].Location = new Point(i* l_width,0);
                labels[i].BorderStyle = BorderStyle.FixedSingle;
                labels[i].TextAlign = ContentAlignment.MiddleCenter;
                
                this.Controls.Add(labels[i]);
            }

        }

        private void LabelPanel_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
