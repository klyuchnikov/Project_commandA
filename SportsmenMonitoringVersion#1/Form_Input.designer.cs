﻿namespace Sportsmen_Monitoring
{
    partial class Form_Input
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
            this.sportsCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.groupBox_Send = new System.Windows.Forms.GroupBox();
            this.dateTimePickerGoal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button_GoGraph = new System.Windows.Forms.Button();
            this.label_send = new System.Windows.Forms.Label();
            this.label_metric = new System.Windows.Forms.Label();
            this.button_Send = new System.Windows.Forms.Button();
            this.disciplinesCB = new System.Windows.Forms.ComboBox();
            this.goalsCB = new System.Windows.Forms.ComboBox();
            this.button_newGoal = new System.Windows.Forms.Button();
            this.groupBox_sports = new System.Windows.Forms.GroupBox();
            this.groupBox_disciplines = new System.Windows.Forms.GroupBox();
            this.groupBox_goals = new System.Windows.Forms.GroupBox();
            this.groupBox_AddGoal = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_newGoal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button_AddGoal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.newGoal_CB = new System.Windows.Forms.ComboBox();
            this.label_discipline = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_sport = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Send.SuspendLayout();
            this.groupBox_sports.SuspendLayout();
            this.groupBox_disciplines.SuspendLayout();
            this.groupBox_goals.SuspendLayout();
            this.groupBox_AddGoal.SuspendLayout();
            this.SuspendLayout();
            // 
            // sportsCB
            // 
            this.sportsCB.FormattingEnabled = true;
            this.sportsCB.Location = new System.Drawing.Point(6, 19);
            this.sportsCB.Name = "sportsCB";
            this.sportsCB.Size = new System.Drawing.Size(150, 21);
            this.sportsCB.TabIndex = 3;
            this.sportsCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(41, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Результат";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(44, 61);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(68, 20);
            this.textBox_result.TabIndex = 7;
            // 
            // groupBox_Send
            // 
            this.groupBox_Send.Controls.Add(this.dateTimePickerGoal);
            this.groupBox_Send.Controls.Add(this.label3);
            this.groupBox_Send.Controls.Add(this.button_GoGraph);
            this.groupBox_Send.Controls.Add(this.label_send);
            this.groupBox_Send.Controls.Add(this.label_metric);
            this.groupBox_Send.Controls.Add(this.button_Send);
            this.groupBox_Send.Controls.Add(this.label4);
            this.groupBox_Send.Controls.Add(this.textBox_result);
            this.groupBox_Send.Enabled = false;
            this.groupBox_Send.Location = new System.Drawing.Point(12, 261);
            this.groupBox_Send.Name = "groupBox_Send";
            this.groupBox_Send.Size = new System.Drawing.Size(309, 222);
            this.groupBox_Send.TabIndex = 12;
            this.groupBox_Send.TabStop = false;
            this.groupBox_Send.Text = "Отправка результатов";
            // 
            // dateTimePickerGoal
            // 
            this.dateTimePickerGoal.Location = new System.Drawing.Point(163, 61);
            this.dateTimePickerGoal.Name = "dateTimePickerGoal";
            this.dateTimePickerGoal.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerGoal.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(195, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Дата";
            // 
            // button_GoGraph
            // 
            this.button_GoGraph.Location = new System.Drawing.Point(77, 190);
            this.button_GoGraph.Name = "button_GoGraph";
            this.button_GoGraph.Size = new System.Drawing.Size(135, 26);
            this.button_GoGraph.TabIndex = 21;
            this.button_GoGraph.Text = "Посмотреть графики";
            this.button_GoGraph.UseVisualStyleBackColor = true;
            this.button_GoGraph.Click += new System.EventHandler(this.button_GoGraph_Click_1);
            // 
            // label_send
            // 
            this.label_send.AutoSize = true;
            this.label_send.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_send.ForeColor = System.Drawing.Color.SeaGreen;
            this.label_send.Location = new System.Drawing.Point(8, 162);
            this.label_send.Name = "label_send";
            this.label_send.Size = new System.Drawing.Size(29, 13);
            this.label_send.TabIndex = 20;
            this.label_send.Text = "text";
            this.label_send.Visible = false;
            // 
            // label_metric
            // 
            this.label_metric.AutoSize = true;
            this.label_metric.Location = new System.Drawing.Point(112, 64);
            this.label_metric.Name = "label_metric";
            this.label_metric.Size = new System.Drawing.Size(0, 13);
            this.label_metric.TabIndex = 9;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(77, 100);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(135, 40);
            this.button_Send.TabIndex = 8;
            this.button_Send.Text = "Отправка данных";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button1_Click);
            // 
            // disciplinesCB
            // 
            this.disciplinesCB.FormattingEnabled = true;
            this.disciplinesCB.Location = new System.Drawing.Point(6, 19);
            this.disciplinesCB.Name = "disciplinesCB";
            this.disciplinesCB.Size = new System.Drawing.Size(150, 21);
            this.disciplinesCB.TabIndex = 15;
            this.disciplinesCB.SelectedIndexChanged += new System.EventHandler(this.disciplinesCB_SelectedIndexChanged);
            // 
            // goalsCB
            // 
            this.goalsCB.FormattingEnabled = true;
            this.goalsCB.Location = new System.Drawing.Point(6, 19);
            this.goalsCB.Name = "goalsCB";
            this.goalsCB.Size = new System.Drawing.Size(150, 21);
            this.goalsCB.TabIndex = 18;
            this.goalsCB.SelectedIndexChanged += new System.EventHandler(this.goalsCB_SelectedIndexChanged);
            // 
            // button_newGoal
            // 
            this.button_newGoal.Enabled = false;
            this.button_newGoal.Location = new System.Drawing.Point(17, 52);
            this.button_newGoal.Name = "button_newGoal";
            this.button_newGoal.Size = new System.Drawing.Size(139, 38);
            this.button_newGoal.TabIndex = 19;
            this.button_newGoal.Text = "Добавить новую цель";
            this.button_newGoal.UseVisualStyleBackColor = true;
            this.button_newGoal.Click += new System.EventHandler(this.button_newGoal_Click);
            // 
            // groupBox_sports
            // 
            this.groupBox_sports.Controls.Add(this.sportsCB);
            this.groupBox_sports.Location = new System.Drawing.Point(12, 12);
            this.groupBox_sports.Name = "groupBox_sports";
            this.groupBox_sports.Size = new System.Drawing.Size(162, 55);
            this.groupBox_sports.TabIndex = 20;
            this.groupBox_sports.TabStop = false;
            this.groupBox_sports.Text = "Виды спорта";
            // 
            // groupBox_disciplines
            // 
            this.groupBox_disciplines.Controls.Add(this.disciplinesCB);
            this.groupBox_disciplines.Enabled = false;
            this.groupBox_disciplines.Location = new System.Drawing.Point(12, 73);
            this.groupBox_disciplines.Name = "groupBox_disciplines";
            this.groupBox_disciplines.Size = new System.Drawing.Size(162, 49);
            this.groupBox_disciplines.TabIndex = 21;
            this.groupBox_disciplines.TabStop = false;
            this.groupBox_disciplines.Text = "Дисциплина";
            // 
            // groupBox_goals
            // 
            this.groupBox_goals.Controls.Add(this.goalsCB);
            this.groupBox_goals.Controls.Add(this.button_newGoal);
            this.groupBox_goals.Enabled = false;
            this.groupBox_goals.Location = new System.Drawing.Point(12, 128);
            this.groupBox_goals.Name = "groupBox_goals";
            this.groupBox_goals.Size = new System.Drawing.Size(162, 127);
            this.groupBox_goals.TabIndex = 22;
            this.groupBox_goals.TabStop = false;
            this.groupBox_goals.Text = "Моя цель";
            // 
            // groupBox_AddGoal
            // 
            this.groupBox_AddGoal.Controls.Add(this.dateTimePicker_newGoal);
            this.groupBox_AddGoal.Controls.Add(this.label2);
            this.groupBox_AddGoal.Controls.Add(this.button_AddGoal);
            this.groupBox_AddGoal.Controls.Add(this.label7);
            this.groupBox_AddGoal.Controls.Add(this.newGoal_CB);
            this.groupBox_AddGoal.Controls.Add(this.label_discipline);
            this.groupBox_AddGoal.Controls.Add(this.label5);
            this.groupBox_AddGoal.Controls.Add(this.label_sport);
            this.groupBox_AddGoal.Controls.Add(this.label1);
            this.groupBox_AddGoal.Location = new System.Drawing.Point(181, 13);
            this.groupBox_AddGoal.Name = "groupBox_AddGoal";
            this.groupBox_AddGoal.Size = new System.Drawing.Size(140, 242);
            this.groupBox_AddGoal.TabIndex = 23;
            this.groupBox_AddGoal.TabStop = false;
            this.groupBox_AddGoal.Text = "Добавить цель";
            this.groupBox_AddGoal.Visible = false;
            // 
            // dateTimePicker_newGoal
            // 
            this.dateTimePicker_newGoal.Location = new System.Drawing.Point(12, 167);
            this.dateTimePicker_newGoal.Name = "dateTimePicker_newGoal";
            this.dateTimePicker_newGoal.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_newGoal.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата начала:";
            // 
            // button_AddGoal
            // 
            this.button_AddGoal.Enabled = false;
            this.button_AddGoal.Location = new System.Drawing.Point(21, 193);
            this.button_AddGoal.Name = "button_AddGoal";
            this.button_AddGoal.Size = new System.Drawing.Size(92, 38);
            this.button_AddGoal.TabIndex = 6;
            this.button_AddGoal.Text = "Добавить к моим целям";
            this.button_AddGoal.UseVisualStyleBackColor = true;
            this.button_AddGoal.Click += new System.EventHandler(this.button_AddGoal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Доступные цели:";
            // 
            // newGoal_CB
            // 
            this.newGoal_CB.FormattingEnabled = true;
            this.newGoal_CB.Location = new System.Drawing.Point(11, 122);
            this.newGoal_CB.Name = "newGoal_CB";
            this.newGoal_CB.Size = new System.Drawing.Size(121, 21);
            this.newGoal_CB.TabIndex = 4;
            this.newGoal_CB.SelectedIndexChanged += new System.EventHandler(this.newGoal_CB_SelectedIndexChanged);
            // 
            // label_discipline
            // 
            this.label_discipline.AutoSize = true;
            this.label_discipline.ForeColor = System.Drawing.Color.SeaGreen;
            this.label_discipline.Location = new System.Drawing.Point(9, 79);
            this.label_discipline.Name = "label_discipline";
            this.label_discipline.Size = new System.Drawing.Size(0, 13);
            this.label_discipline.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Выбранная дисциплина:";
            // 
            // label_sport
            // 
            this.label_sport.AutoSize = true;
            this.label_sport.ForeColor = System.Drawing.Color.SeaGreen;
            this.label_sport.Location = new System.Drawing.Point(9, 41);
            this.label_sport.Name = "label_sport";
            this.label_sport.Size = new System.Drawing.Size(0, 13);
            this.label_sport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбранный спорт:";
            // 
            // Form_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(354, 495);
            this.Controls.Add(this.groupBox_AddGoal);
            this.Controls.Add(this.groupBox_goals);
            this.Controls.Add(this.groupBox_disciplines);
            this.Controls.Add(this.groupBox_sports);
            this.Controls.Add(this.groupBox_Send);
            this.Name = "Form_Input";
            this.Text = "Форма ввода результатов";
            this.Load += new System.EventHandler(this.Form_Input_Load);
            this.groupBox_Send.ResumeLayout(false);
            this.groupBox_Send.PerformLayout();
            this.groupBox_sports.ResumeLayout(false);
            this.groupBox_disciplines.ResumeLayout(false);
            this.groupBox_goals.ResumeLayout(false);
            this.groupBox_AddGoal.ResumeLayout(false);
            this.groupBox_AddGoal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox sportsCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.GroupBox groupBox_Send;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.ComboBox disciplinesCB;
        private System.Windows.Forms.ComboBox goalsCB;
        private System.Windows.Forms.Button button_newGoal;
        private System.Windows.Forms.Label label_send;
        private System.Windows.Forms.Label label_metric;
        private System.Windows.Forms.Button button_GoGraph;
        private System.Windows.Forms.GroupBox groupBox_sports;
        private System.Windows.Forms.GroupBox groupBox_disciplines;
        private System.Windows.Forms.GroupBox groupBox_goals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerGoal;
        private System.Windows.Forms.GroupBox groupBox_AddGoal;
        private System.Windows.Forms.Label label_discipline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_sport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AddGoal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox newGoal_CB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_newGoal;
    }
}