namespace Superadmin
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersLB = new System.Windows.Forms.CheckedListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersLB
            // 
            this.UsersLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersLB.FormattingEnabled = true;
            this.UsersLB.Location = new System.Drawing.Point(3, 16);
            this.UsersLB.Name = "UsersLB";
            this.UsersLB.Size = new System.Drawing.Size(428, 181);
            this.UsersLB.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(371, 218);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.SuccessLabel.Location = new System.Drawing.Point(239, 223);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(126, 13);
            this.SuccessLabel.TabIndex = 2;
            this.SuccessLabel.Text = "Изменения сохранены!";
            this.SuccessLabel.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(224, 223);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(141, 13);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "Изменения не сохранены!";
            this.errorLabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UsersLB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 200);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите пользователей с правами тренера";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 248);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.SuccessLabel);
            this.Controls.Add(this.SaveButton);
            this.Name = "MainForm";
            this.Text = "Изменение прав пользователей";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox UsersLB;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

