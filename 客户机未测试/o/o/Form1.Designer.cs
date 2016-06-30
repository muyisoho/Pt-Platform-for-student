namespace o
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.studentBtn = new System.Windows.Forms.Button();
            this.employerBtn = new System.Windows.Forms.Button();
            this.stuRegNametxt = new System.Windows.Forms.TextBox();
            this.stuRegNameLab = new System.Windows.Forms.Label();
            this.stuRegSexLab = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.regSchoolNameLab = new System.Windows.Forms.Label();
            this.regSchoolNametxt = new System.Windows.Forms.TextBox();
            this.majorLab = new System.Windows.Forms.Label();
            this.majortxt = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.passAgainLabel = new System.Windows.Forms.Label();
            this.passPasstxt = new System.Windows.Forms.TextBox();
            this.stuRegBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.register = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBtn
            // 
            this.studentBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.studentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.studentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentBtn.ForeColor = System.Drawing.Color.White;
            this.studentBtn.Location = new System.Drawing.Point(406, 117);
            this.studentBtn.Name = "studentBtn";
            this.studentBtn.Size = new System.Drawing.Size(75, 23);
            this.studentBtn.TabIndex = 1;
            this.studentBtn.Text = "学生";
            this.studentBtn.UseVisualStyleBackColor = false;
            this.studentBtn.Click += new System.EventHandler(this.studentBtn_Click);
            // 
            // employerBtn
            // 
            this.employerBtn.BackColor = System.Drawing.Color.Gray;
            this.employerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employerBtn.ForeColor = System.Drawing.Color.Transparent;
            this.employerBtn.Location = new System.Drawing.Point(487, 117);
            this.employerBtn.Name = "employerBtn";
            this.employerBtn.Size = new System.Drawing.Size(75, 23);
            this.employerBtn.TabIndex = 2;
            this.employerBtn.Text = "用人单位";
            this.employerBtn.UseVisualStyleBackColor = false;
            this.employerBtn.Click += new System.EventHandler(this.employerBtn_Click);
            // 
            // stuRegNametxt
            // 
            this.stuRegNametxt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stuRegNametxt.Location = new System.Drawing.Point(398, 175);
            this.stuRegNametxt.Multiline = true;
            this.stuRegNametxt.Name = "stuRegNametxt";
            this.stuRegNametxt.Size = new System.Drawing.Size(225, 32);
            this.stuRegNametxt.TabIndex = 3;
            // 
            // stuRegNameLab
            // 
            this.stuRegNameLab.AutoSize = true;
            this.stuRegNameLab.BackColor = System.Drawing.Color.Transparent;
            this.stuRegNameLab.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stuRegNameLab.Location = new System.Drawing.Point(291, 188);
            this.stuRegNameLab.Name = "stuRegNameLab";
            this.stuRegNameLab.Size = new System.Drawing.Size(89, 19);
            this.stuRegNameLab.TabIndex = 4;
            this.stuRegNameLab.Text = "用户名：";
            // 
            // stuRegSexLab
            // 
            this.stuRegSexLab.AutoSize = true;
            this.stuRegSexLab.BackColor = System.Drawing.Color.Transparent;
            this.stuRegSexLab.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stuRegSexLab.Location = new System.Drawing.Point(311, 228);
            this.stuRegSexLab.Name = "stuRegSexLab";
            this.stuRegSexLab.Size = new System.Drawing.Size(69, 19);
            this.stuRegSexLab.TabIndex = 5;
            this.stuRegSexLab.Text = "性别：";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(425, 227);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 20);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.Location = new System.Drawing.Point(497, 227);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 20);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "女";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // regSchoolNameLab
            // 
            this.regSchoolNameLab.AutoSize = true;
            this.regSchoolNameLab.BackColor = System.Drawing.Color.Transparent;
            this.regSchoolNameLab.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.regSchoolNameLab.Location = new System.Drawing.Point(271, 266);
            this.regSchoolNameLab.Name = "regSchoolNameLab";
            this.regSchoolNameLab.Size = new System.Drawing.Size(109, 19);
            this.regSchoolNameLab.TabIndex = 8;
            this.regSchoolNameLab.Text = "学校名称：";
            // 
            // regSchoolNametxt
            // 
            this.regSchoolNametxt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.regSchoolNametxt.Location = new System.Drawing.Point(398, 259);
            this.regSchoolNametxt.Multiline = true;
            this.regSchoolNametxt.Name = "regSchoolNametxt";
            this.regSchoolNametxt.Size = new System.Drawing.Size(225, 32);
            this.regSchoolNametxt.TabIndex = 9;
            // 
            // majorLab
            // 
            this.majorLab.AutoSize = true;
            this.majorLab.BackColor = System.Drawing.Color.Transparent;
            this.majorLab.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.majorLab.Location = new System.Drawing.Point(311, 310);
            this.majorLab.Name = "majorLab";
            this.majorLab.Size = new System.Drawing.Size(69, 19);
            this.majorLab.TabIndex = 10;
            this.majorLab.Text = "专业：";
            // 
            // majortxt
            // 
            this.majortxt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.majortxt.Location = new System.Drawing.Point(398, 303);
            this.majortxt.Multiline = true;
            this.majortxt.Name = "majortxt";
            this.majortxt.Size = new System.Drawing.Size(225, 32);
            this.majortxt.TabIndex = 11;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addressLabel.Location = new System.Drawing.Point(291, 349);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(89, 19);
            this.addressLabel.TabIndex = 12;
            this.addressLabel.Text = "居住地：";
            // 
            // addresstxt
            // 
            this.addresstxt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addresstxt.Location = new System.Drawing.Point(399, 345);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(225, 32);
            this.addresstxt.TabIndex = 13;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.Transparent;
            this.passLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passLabel.Location = new System.Drawing.Point(311, 396);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(69, 19);
            this.passLabel.TabIndex = 14;
            this.passLabel.Text = "密码：";
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passtxt.Location = new System.Drawing.Point(398, 389);
            this.passtxt.Multiline = true;
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(225, 32);
            this.passtxt.TabIndex = 15;
            // 
            // passAgainLabel
            // 
            this.passAgainLabel.AutoSize = true;
            this.passAgainLabel.BackColor = System.Drawing.Color.Transparent;
            this.passAgainLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passAgainLabel.Location = new System.Drawing.Point(271, 439);
            this.passAgainLabel.Name = "passAgainLabel";
            this.passAgainLabel.Size = new System.Drawing.Size(109, 19);
            this.passAgainLabel.TabIndex = 16;
            this.passAgainLabel.Text = "确认密码：";
            // 
            // passPasstxt
            // 
            this.passPasstxt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passPasstxt.Location = new System.Drawing.Point(396, 433);
            this.passPasstxt.Multiline = true;
            this.passPasstxt.Name = "passPasstxt";
            this.passPasstxt.Size = new System.Drawing.Size(225, 32);
            this.passPasstxt.TabIndex = 17;
            // 
            // stuRegBtn
            // 
            this.stuRegBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.stuRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stuRegBtn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stuRegBtn.ForeColor = System.Drawing.Color.White;
            this.stuRegBtn.Location = new System.Drawing.Point(464, 484);
            this.stuRegBtn.Name = "stuRegBtn";
            this.stuRegBtn.Size = new System.Drawing.Size(75, 27);
            this.stuRegBtn.TabIndex = 18;
            this.stuRegBtn.Text = "注册";
            this.stuRegBtn.UseVisualStyleBackColor = false;
            this.stuRegBtn.Click += new System.EventHandler(this.stuRegBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.register);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-23, -45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 99);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.register.Location = new System.Drawing.Point(780, 69);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(29, 12);
            this.register.TabIndex = 4;
            this.register.Text = "注册";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.login.Location = new System.Drawing.Point(742, 70);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(29, 12);
            this.login.TabIndex = 3;
            this.login.Text = "登录";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(224, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "适合大学生的兼职平台";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(143, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "聚兼职   ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stuRegBtn);
            this.Controls.Add(this.passPasstxt);
            this.Controls.Add(this.passAgainLabel);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.majortxt);
            this.Controls.Add(this.majorLab);
            this.Controls.Add(this.regSchoolNametxt);
            this.Controls.Add(this.regSchoolNameLab);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.stuRegSexLab);
            this.Controls.Add(this.stuRegNameLab);
            this.Controls.Add(this.stuRegNametxt);
            this.Controls.Add(this.employerBtn);
            this.Controls.Add(this.studentBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.Button employerBtn;
        private System.Windows.Forms.TextBox stuRegNametxt;
        private System.Windows.Forms.Label stuRegNameLab;
        private System.Windows.Forms.Label stuRegSexLab;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label regSchoolNameLab;
        private System.Windows.Forms.TextBox regSchoolNametxt;
        private System.Windows.Forms.Label majorLab;
        private System.Windows.Forms.TextBox majortxt;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label passAgainLabel;
        private System.Windows.Forms.TextBox passPasstxt;
        private System.Windows.Forms.Button stuRegBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label register;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

