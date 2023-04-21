namespace GUI
{
    partial class Login
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
            txtUser = new DevExpress.XtraEditors.TextEdit();
            txtPass = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)txtUser.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPass.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.EditValue = "";
            txtUser.Location = new Point(41, 162);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.Properties.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Properties.Appearance.Options.UseFont = true;
            txtUser.Size = new Size(298, 26);
            txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.EditValue = "";
            txtPass.Location = new Point(41, 219);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Name = "txtPass";
            txtPass.Properties.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Properties.Appearance.Options.UseFont = true;
            txtPass.Size = new Size(298, 26);
            txtPass.TabIndex = 2;
            txtPass.EditValueChanged += txtPass_EditValueChanged;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.ForeColor = Color.Black;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(42, 10);
            labelControl1.Margin = new Padding(3, 2, 3, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(112, 22);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "Welcome to ";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.ForeColor = Color.Black;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new Point(41, 101);
            labelControl2.Margin = new Padding(3, 2, 3, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(175, 22);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "Sign In to Continue";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl3.Appearance.ForeColor = Color.Black;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new Point(42, 140);
            labelControl3.Margin = new Padding(3, 2, 3, 2);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(61, 17);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Username";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl4.Appearance.ForeColor = Color.Black;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.Location = new Point(42, 37);
            labelControl4.Margin = new Padding(3, 2, 3, 2);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(186, 22);
            labelControl4.TabIndex = 6;
            labelControl4.Text = "Airport Management";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl5.Appearance.ForeColor = Color.Black;
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Appearance.Options.UseForeColor = true;
            labelControl5.Location = new Point(42, 197);
            labelControl5.Margin = new Padding(3, 2, 3, 2);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(58, 17);
            labelControl5.TabIndex = 7;
            labelControl5.Text = "Password";
            // 
            // hyperlinkLabelControl1
            // 
            hyperlinkLabelControl1.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hyperlinkLabelControl1.Appearance.Options.UseFont = true;
            hyperlinkLabelControl1.Location = new Point(241, 254);
            hyperlinkLabelControl1.Margin = new Padding(3, 2, 3, 2);
            hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            hyperlinkLabelControl1.Size = new Size(97, 14);
            hyperlinkLabelControl1.TabIndex = 8;
            hyperlinkLabelControl1.Text = "Forgot Password?";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = Color.FromArgb(42, 93, 196);
            simpleButton1.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            simpleButton1.Appearance.ForeColor = Color.White;
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.Cursor = Cursors.Hand;
            simpleButton1.Location = new Point(41, 315);
            simpleButton1.Margin = new Padding(3, 2, 3, 2);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(298, 36);
            simpleButton1.TabIndex = 9;
            simpleButton1.Text = "Sign in";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(46, 256);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(116, 21);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Remember me";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 455);
            Controls.Add(radioButton1);
            Controls.Add(simpleButton1);
            Controls.Add(hyperlinkLabelControl1);
            Controls.Add(labelControl5);
            Controls.Add(labelControl4);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            ((System.ComponentModel.ISupportInitialize)txtUser.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPass.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private RadioButton radioButton1;
    }
}