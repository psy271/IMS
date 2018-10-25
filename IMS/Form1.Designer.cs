namespace IMS
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPanel2 = new IMS.Control.LabelPanel();
            this.labelPanel1 = new IMS.Control.LabelPanel();
            this.SuspendLayout();
            // 
            // labelPanel2
            // 
            this.labelPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPanel2.Count = 15;
            this.labelPanel2.Location = new System.Drawing.Point(114, 161);
            this.labelPanel2.Name = "labelPanel2";
            this.labelPanel2.Size = new System.Drawing.Size(423, 27);
            this.labelPanel2.TabIndex = 1;
            // 
            // labelPanel1
            // 
            this.labelPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.labelPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPanel1.Count = 10;
            this.labelPanel1.Location = new System.Drawing.Point(114, 118);
            this.labelPanel1.Name = "labelPanel1";
            this.labelPanel1.Size = new System.Drawing.Size(423, 27);
            this.labelPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPanel2);
            this.Controls.Add(this.labelPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.LabelPanel labelPanel1;
        private Control.LabelPanel labelPanel2;
    }
}

