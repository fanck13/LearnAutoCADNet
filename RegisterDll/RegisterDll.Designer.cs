namespace RegisterDll
{
    partial class frmRegisterDll
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLoader = new System.Windows.Forms.Label();
            this.lblLocadCtrls = new System.Windows.Forms.Label();
            this.lblManaged = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.cbxLoadCtrls = new System.Windows.Forms.ComboBox();
            this.tbxLoader = new System.Windows.Forms.TextBox();
            this.cbxManaged = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 37);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(71, 12);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // lblLoader
            // 
            this.lblLoader.AutoSize = true;
            this.lblLoader.Location = new System.Drawing.Point(30, 197);
            this.lblLoader.Name = "lblLoader";
            this.lblLoader.Size = new System.Drawing.Size(41, 12);
            this.lblLoader.TabIndex = 1;
            this.lblLoader.Text = "Loader";
            // 
            // lblLocadCtrls
            // 
            this.lblLocadCtrls.AutoSize = true;
            this.lblLocadCtrls.Location = new System.Drawing.Point(328, 37);
            this.lblLocadCtrls.Name = "lblLocadCtrls";
            this.lblLocadCtrls.Size = new System.Drawing.Size(53, 12);
            this.lblLocadCtrls.TabIndex = 2;
            this.lblLocadCtrls.Text = "LoadCtrl";
            // 
            // lblManaged
            // 
            this.lblManaged.AutoSize = true;
            this.lblManaged.Location = new System.Drawing.Point(328, 197);
            this.lblManaged.Name = "lblManaged";
            this.lblManaged.Size = new System.Drawing.Size(47, 12);
            this.lblManaged.TabIndex = 3;
            this.lblManaged.Text = "Managed";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(118, 35);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(100, 21);
            this.tbxDescription.TabIndex = 4;
            // 
            // cbxLoadCtrls
            // 
            this.cbxLoadCtrls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoadCtrls.FormattingEnabled = true;
            this.cbxLoadCtrls.Items.AddRange(new object[] {
            "0x01",
            "0x02",
            "0x04",
            "0x08",
            "0x10",
            "0x20"});
            this.cbxLoadCtrls.Location = new System.Drawing.Point(454, 37);
            this.cbxLoadCtrls.Name = "cbxLoadCtrls";
            this.cbxLoadCtrls.Size = new System.Drawing.Size(121, 20);
            this.cbxLoadCtrls.TabIndex = 5;
            // 
            // tbxLoader
            // 
            this.tbxLoader.Location = new System.Drawing.Point(114, 197);
            this.tbxLoader.Name = "tbxLoader";
            this.tbxLoader.Size = new System.Drawing.Size(100, 21);
            this.tbxLoader.TabIndex = 6;
            // 
            // cbxManaged
            // 
            this.cbxManaged.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxManaged.FormattingEnabled = true;
            this.cbxManaged.Items.AddRange(new object[] {
            "0x01"});
            this.cbxManaged.Location = new System.Drawing.Point(454, 189);
            this.cbxManaged.Name = "cbxManaged";
            this.cbxManaged.Size = new System.Drawing.Size(121, 20);
            this.cbxManaged.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(486, 242);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmRegisterDll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbxManaged);
            this.Controls.Add(this.tbxLoader);
            this.Controls.Add(this.cbxLoadCtrls);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblManaged);
            this.Controls.Add(this.lblLocadCtrls);
            this.Controls.Add(this.lblLoader);
            this.Controls.Add(this.lblDescription);
            this.Name = "frmRegisterDll";
            this.Text = "Register Dll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLoader;
        private System.Windows.Forms.Label lblLocadCtrls;
        private System.Windows.Forms.Label lblManaged;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.ComboBox cbxLoadCtrls;
        private System.Windows.Forms.TextBox tbxLoader;
        private System.Windows.Forms.ComboBox cbxManaged;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button button1;
    }
}

