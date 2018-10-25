namespace IMS
{
    partial class frm0003
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbUesYn = new System.Windows.Forms.ComboBox();
            this.txtGroup_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroup_ID = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCurrent = new System.Windows.Forms.TabPage();
            this.listCurrent = new System.Windows.Forms.ListView();
            this.tabAll = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.listUser = new System.Windows.Forms.ListView();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.listMenu = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemoveCurrent = new System.Windows.Forms.Button();
            this.btnAddCurrent = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCurrentSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCurrent.SuspendLayout();
            this.tabAll.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dgvGroup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 678);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvGroup
            // 
            this.dgvGroup.AllowUserToAddRows = false;
            this.dgvGroup.BackgroundColor = System.Drawing.Color.White;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroup.Location = new System.Drawing.Point(3, 4);
            this.dgvGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvGroup.MultiSelect = false;
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.ReadOnly = true;
            this.dgvGroup.RowTemplate.Height = 23;
            this.dgvGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroup.Size = new System.Drawing.Size(659, 331);
            this.dgvGroup.TabIndex = 0;
            this.dgvGroup.SelectionChanged += new System.EventHandler(this.dgvUser_SelectionChanged);
            this.dgvGroup.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvUser_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(668, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(326, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자정보";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.3125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.6875F));
            this.tableLayoutPanel2.Controls.Add(this.cmbUesYn, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.txtGroup_Name, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtGroup_ID, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtRemark, 2, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 13;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(320, 305);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cmbUesYn
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cmbUesYn, 3);
            this.cmbUesYn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbUesYn.FormattingEnabled = true;
            this.cmbUesYn.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cmbUesYn.Location = new System.Drawing.Point(131, 242);
            this.cmbUesYn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUesYn.Name = "cmbUesYn";
            this.cmbUesYn.Size = new System.Drawing.Size(186, 23);
            this.cmbUesYn.TabIndex = 12;
            // 
            // txtGroup_Name
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtGroup_Name, 3);
            this.txtGroup_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGroup_Name.Location = new System.Drawing.Point(131, 110);
            this.txtGroup_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGroup_Name.Name = "txtGroup_Name";
            this.txtGroup_Name.Size = new System.Drawing.Size(186, 25);
            this.txtGroup_Name.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "사용여부";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "비고";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "그룹명";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 5);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 54);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(187, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 46);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(7, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "신규";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "그룹아이디";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGroup_ID
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtGroup_ID, 3);
            this.txtGroup_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGroup_ID.Location = new System.Drawing.Point(131, 66);
            this.txtGroup_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGroup_ID.Name = "txtGroup_ID";
            this.txtGroup_ID.Size = new System.Drawing.Size(186, 25);
            this.txtGroup_ID.TabIndex = 6;
            // 
            // txtRemark
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtRemark, 3);
            this.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemark.Location = new System.Drawing.Point(131, 153);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.tableLayoutPanel2.SetRowSpan(this.txtRemark, 3);
            this.txtRemark.Size = new System.Drawing.Size(186, 76);
            this.txtRemark.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.tabControl1, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tabAll, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 342);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(991, 333);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCurrent);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(373, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(294, 277);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCurrent
            // 
            this.tabCurrent.Controls.Add(this.listCurrent);
            this.tabCurrent.Location = new System.Drawing.Point(4, 25);
            this.tabCurrent.Name = "tabCurrent";
            this.tabCurrent.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurrent.Size = new System.Drawing.Size(286, 248);
            this.tabCurrent.TabIndex = 0;
            this.tabCurrent.Text = "현재";
            this.tabCurrent.UseVisualStyleBackColor = true;
            // 
            // listCurrent
            // 
            this.listCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCurrent.Location = new System.Drawing.Point(3, 3);
            this.listCurrent.Name = "listCurrent";
            this.listCurrent.Size = new System.Drawing.Size(280, 242);
            this.listCurrent.TabIndex = 1;
            this.listCurrent.UseCompatibleStateImageBehavior = false;
            this.listCurrent.View = System.Windows.Forms.View.List;
            // 
            // tabAll
            // 
            this.tabAll.Controls.Add(this.tabUser);
            this.tabAll.Controls.Add(this.tabMenu);
            this.tabAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAll.Location = new System.Drawing.Point(3, 53);
            this.tabAll.Name = "tabAll";
            this.tabAll.SelectedIndex = 0;
            this.tabAll.Size = new System.Drawing.Size(294, 277);
            this.tabAll.TabIndex = 0;
            this.tabAll.SelectedIndexChanged += new System.EventHandler(this.tabAll_SelectedIndexChanged);
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.listUser);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(286, 248);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "사용자";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // listUser
            // 
            this.listUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUser.LabelWrap = false;
            this.listUser.Location = new System.Drawing.Point(3, 3);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(280, 242);
            this.listUser.TabIndex = 0;
            this.listUser.UseCompatibleStateImageBehavior = false;
            this.listUser.View = System.Windows.Forms.View.List;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.listMenu);
            this.tabMenu.Location = new System.Drawing.Point(4, 25);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(286, 257);
            this.tabMenu.TabIndex = 1;
            this.tabMenu.Text = "메뉴";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // listMenu
            // 
            this.listMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMenu.Location = new System.Drawing.Point(3, 3);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(280, 251);
            this.listMenu.TabIndex = 0;
            this.listMenu.UseCompatibleStateImageBehavior = false;
            this.listMenu.View = System.Windows.Forms.View.List;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemoveCurrent);
            this.panel2.Controls.Add(this.btnAddCurrent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(303, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 277);
            this.panel2.TabIndex = 2;
            // 
            // btnRemoveCurrent
            // 
            this.btnRemoveCurrent.Location = new System.Drawing.Point(4, 143);
            this.btnRemoveCurrent.Name = "btnRemoveCurrent";
            this.btnRemoveCurrent.Size = new System.Drawing.Size(57, 64);
            this.btnRemoveCurrent.TabIndex = 1;
            this.btnRemoveCurrent.Text = "<";
            this.btnRemoveCurrent.UseVisualStyleBackColor = true;
            this.btnRemoveCurrent.Click += new System.EventHandler(this.btnRemoveCurrent_Click);
            // 
            // btnAddCurrent
            // 
            this.btnAddCurrent.Location = new System.Drawing.Point(4, 73);
            this.btnAddCurrent.Name = "btnAddCurrent";
            this.btnAddCurrent.Size = new System.Drawing.Size(57, 64);
            this.btnAddCurrent.TabIndex = 0;
            this.btnAddCurrent.Text = ">";
            this.btnAddCurrent.UseVisualStyleBackColor = true;
            this.btnAddCurrent.Click += new System.EventHandler(this.btnAddCurrent_Click);
            // 
            // panel3
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.panel3, 5);
            this.panel3.Controls.Add(this.btnCurrentSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 44);
            this.panel3.TabIndex = 3;
            // 
            // btnCurrentSave
            // 
            this.btnCurrentSave.Location = new System.Drawing.Point(7, 4);
            this.btnCurrentSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCurrentSave.Name = "btnCurrentSave";
            this.btnCurrentSave.Size = new System.Drawing.Size(101, 36);
            this.btnCurrentSave.TabIndex = 1;
            this.btnCurrentSave.Text = "저장";
            this.btnCurrentSave.UseVisualStyleBackColor = true;
            this.btnCurrentSave.Click += new System.EventHandler(this.btnCurrentSave_Click);
            // 
            // frm0003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 720);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frm0003";
            this.Text = "사용자관리";
            this.Load += new System.EventHandler(this.frm0002_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCurrent.ResumeLayout(false);
            this.tabAll.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroup_Name;
        private System.Windows.Forms.TextBox txtGroup_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ComboBox cmbUesYn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCurrent;
        private System.Windows.Forms.TabControl tabAll;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.ListView listCurrent;
        private System.Windows.Forms.ListView listUser;
        private System.Windows.Forms.ListView listMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemoveCurrent;
        private System.Windows.Forms.Button btnAddCurrent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCurrentSave;
    }
}