﻿namespace Sportsmen_Monitoring
{
    partial class AddResults
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
            this.buttonToGraph = new System.Windows.Forms.Button();
            this.buttonAuthorize = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonAdminData = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToGraph
            // 
            this.buttonToGraph.Location = new System.Drawing.Point(163, 210);
            this.buttonToGraph.Name = "buttonToGraph";
            this.buttonToGraph.Size = new System.Drawing.Size(117, 46);
            this.buttonToGraph.TabIndex = 0;
            this.buttonToGraph.Text = "buttonToGraph";
            this.buttonToGraph.UseVisualStyleBackColor = true;
            this.buttonToGraph.Click += new System.EventHandler(this.buttonToGraph_Click);
            // 
            // buttonAuthorize
            // 
            this.buttonAuthorize.Location = new System.Drawing.Point(12, 210);
            this.buttonAuthorize.Name = "buttonAuthorize";
            this.buttonAuthorize.Size = new System.Drawing.Size(129, 46);
            this.buttonAuthorize.TabIndex = 1;
            this.buttonAuthorize.Text = "К авторизации";
            this.buttonAuthorize.UseVisualStyleBackColor = true;
            this.buttonAuthorize.Click += new System.EventHandler(this.buttonAddRes_Click);
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(12, 158);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(129, 46);
            this.buttonInput.TabIndex = 2;
            this.buttonInput.Text = "К добавлению данных";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // buttonAdminData
            // 
            this.buttonAdminData.Location = new System.Drawing.Point(163, 158);
            this.buttonAdminData.Name = "buttonAdminData";
            this.buttonAdminData.Size = new System.Drawing.Size(117, 46);
            this.buttonAdminData.TabIndex = 3;
            this.buttonAdminData.Text = "К админке";
            this.buttonAdminData.UseVisualStyleBackColor = true;
            this.buttonAdminData.Click += new System.EventHandler(this.buttonAdminData_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(163, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(12, 106);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(129, 46);
            this.buttonReg.TabIndex = 5;
            this.buttonReg.Text = "К регистрации";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // AddResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 268);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonAdminData);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.buttonAuthorize);
            this.Controls.Add(this.buttonToGraph);
            this.Name = "AddResults";
            this.Text = "Форма ввода данных";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToGraph;
        private System.Windows.Forms.Button buttonAuthorize;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonAdminData;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonReg;
    }
}

