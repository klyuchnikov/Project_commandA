namespace Sportsmen_Monitoring
{
    partial class FormAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuth));
            this.authB = new System.Windows.Forms.Button();
            this.reginstrationLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.waitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // authB
            // 
            this.authB.Location = new System.Drawing.Point(142, 89);
            this.authB.Name = "authB";
            this.authB.Size = new System.Drawing.Size(126, 23);
            this.authB.TabIndex = 0;
            this.authB.Text = "Авторизироваться";
            this.authB.UseVisualStyleBackColor = true;
            this.authB.Click += new System.EventHandler(this.authB_Click);
            // 
            // reginstrationLink
            // 
            this.reginstrationLink.AutoSize = true;
            this.reginstrationLink.BackColor = System.Drawing.Color.Transparent;
            this.reginstrationLink.Location = new System.Drawing.Point(274, 94);
            this.reginstrationLink.Name = "reginstrationLink";
            this.reginstrationLink.Size = new System.Drawing.Size(72, 13);
            this.reginstrationLink.TabIndex = 1;
            this.reginstrationLink.TabStop = true;
            this.reginstrationLink.Text = "Регистрация";
            this.reginstrationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reginstrationLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(146, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(139, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(193, 12);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(149, 20);
            this.loginTB.TabIndex = 4;
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(193, 38);
            this.passTB.Name = "passTB";
            this.passTB.PasswordChar = '*';
            this.passTB.Size = new System.Drawing.Size(149, 20);
            this.passTB.TabIndex = 5;
            this.passTB.UseSystemPasswordChar = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(146, 61);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(193, 13);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "Логин или пароль введены неверно!";
            this.errorLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sportsmen_Monitoring.Properties.Resources.pict_login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // waitLabel
            // 
            this.waitLabel.AutoSize = true;
            this.waitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.waitLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.waitLabel.Location = new System.Drawing.Point(146, 115);
            this.waitLabel.Name = "waitLabel";
            this.waitLabel.Size = new System.Drawing.Size(136, 13);
            this.waitLabel.TabIndex = 8;
            this.waitLabel.Text = "Пожалуйста подождите...";
            this.waitLabel.Visible = false;
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sportsmen_Monitoring.Properties.Resources.arrows1;
            this.ClientSize = new System.Drawing.Size(354, 136);
            this.Controls.Add(this.waitLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reginstrationLink);
            this.Controls.Add(this.authB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAuth";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authB;
        private System.Windows.Forms.LinkLabel reginstrationLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label waitLabel;
    }
}