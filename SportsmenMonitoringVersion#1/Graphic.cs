﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sportsmen_Monitoring
{
    public partial class Graphic : Form 
    {
        float[] arr = new float[1000];  //массив точек результатов
        int daysCount = 0;              //количество дней за которые выводится график результатов
        bool isLines = false;           //необходимы ли сноски на оси координат
        int curX = 0;                   //текущее значение курсора по Х
        int curY = 0;                   //текущее значение курсора по Y
        float min = 100000;             //стартовое минимальное значение
        float max = 0;                  //стартовое максимальное значение
        float step = 0;                 //индекс шага графика по результатам
        int stDays = 0;                 //индекс шага граыика по дням
        int x_1 = 0;
        int y_1 = 0;
        int x_2 = 0;
        int y_2 = 0;
        int count = 0;
        Graphics graph;
        Image buffer;
        Graphics bufgraph;
        bool point = true;
        public Panel panel1;
        private Label label1;
        private GroupBox groupBox_sports;
        private ComboBox sportsCB;
        private GroupBox groupBox_disciplines;
        private ComboBox disciplinesCB;
        private GroupBox groupBox_goals;
        private ComboBox goalsCB;
        private GroupBox groupBox_Start;
        private DateTimePicker datetimeStart;
        private GroupBox groupBox_end;
        private DateTimePicker datetimeEnd;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        List<Point> points = new List<Point>();
        public Graphic()
        {
            InitializeComponent();
            buffer = new Bitmap(panel1.Width, panel1.Height);
            bufgraph = Graphics.FromImage(buffer);
            //bufgraph.FillEllipse(Brushes.White, 0, 0, panel1.Width, panel1.Height);
            //bufgraph.FillRectangle(Brushes.White, 0, 0, paintPanel.Width, paintPanel.Height);
            graph = panel1.CreateGraphics();
        }

        public void getData() //получение массива результатов для построения графика
        {
            arr = Model.Instance.Users_Datas.Where(a => a.Date >= datetimeStart.Value && a.Date <= datetimeEnd.Value).Select(temp => (float)temp.Value).ToArray(); 
        }

        public void findMinMax() //нахождение минимального и максимального значения и вычисление индекса шага по результатам
        {
            if (arr.Length > 1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (min > arr[i])
                        min = arr[i];
                    if (max < arr[i])
                        max = arr[i];
                }
            }
            else
            {
                MessageBox.Show("На графике должно быть минимум две точки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            step = 300 / (max - min);
        }

        
        public void drawGrid() // рисование сетки
        {
            Brush br = new SolidBrush(Color.LightGray);
            Pen pen = new Pen(br);
            for (int i = 0; i < panel1.Width; i += 10)
            {
                bufgraph.DrawLine(pen, i, 0, i, panel1.Height);
            }
            for (int i = 0; i < panel1.Height; i += 10)
            {
                bufgraph.DrawLine(pen, 0, i, panel1.Width, i);
            }
            
        }

        public void drawOsi() //рисование осей координат
        {
            Brush br = new SolidBrush(Color.Black);
            Pen pen = new Pen(br);
            bufgraph.DrawLine(pen, 20, panel1.Height - 20, 20, 20);
            bufgraph.DrawLine(pen, 20, panel1.Height - 20, panel1.Width - 20, panel1.Height - 20);

            bufgraph.DrawLine(pen, 20, 20, 15, 30);
            bufgraph.DrawLine(pen, 20, 20, 25, 30);

            bufgraph.DrawLine(pen, panel1.Width - 20, panel1.Height - 20, panel1.Width - 30, panel1.Height - 25);
            bufgraph.DrawLine(pen, panel1.Width - 20, panel1.Height - 20, panel1.Width - 30, panel1.Height - 15);
            
        }

        public void stepDays() // вычисление индекса шага по дням
        {
            stDays = 756 / daysCount;
        }

        public void drawPoints() // рисование точек на графике и их соединение
        {
            getData();
            findMinMax();
            if (arr.Length > 1)
            {
                stepDays();
                Brush br = new SolidBrush(Color.Red);
                Pen pen = new Pen(br);
                for (int i = 0; i < daysCount; i++)
                {
                    if (arr[i] != null)
                    {
                        graph.DrawEllipse(pen, (i * stDays) + 20, 384 - arr[i] * step, 4, 4);
                        graph.FillEllipse(br, (i * stDays) + 20, 384 - arr[i] * step, 4, 4);
                    }
                }
                for (int i = 1; i < daysCount; i++)
                { 
                    if (arr[i] != null && arr[i - 1] != null)
                        graph.DrawLine(pen, (i * stDays) + 20, 384 - arr[i] * step, ((i - 1) * stDays) + 20, 384 - arr[i - 1] * step);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void draw_line ()
        {
            Pen blackPen = new Pen(Color.Black, 2);
            bufgraph.DrawLine(blackPen, x_1, y_1, x_2, y_2);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            drawGrid();
            drawOsi();
            bufgraph.DrawLine(new Pen(Color.Black, 2), x_1, y_1, x_2, y_2);
            graph.DrawImage(buffer, 0, 0, panel1.Width, panel1.Height);
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void Graphic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void InitializeComponent()
        {
System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphic));
this.panel1 = new System.Windows.Forms.Panel();
this.label3 = new System.Windows.Forms.Label();
this.label2 = new System.Windows.Forms.Label();
this.label1 = new System.Windows.Forms.Label();
this.groupBox_sports = new System.Windows.Forms.GroupBox();
this.sportsCB = new System.Windows.Forms.ComboBox();
this.groupBox_disciplines = new System.Windows.Forms.GroupBox();
this.disciplinesCB = new System.Windows.Forms.ComboBox();
this.groupBox_goals = new System.Windows.Forms.GroupBox();
this.goalsCB = new System.Windows.Forms.ComboBox();
this.groupBox_Start = new System.Windows.Forms.GroupBox();
this.datetimeStart = new System.Windows.Forms.DateTimePicker();
this.groupBox_end = new System.Windows.Forms.GroupBox();
this.datetimeEnd = new System.Windows.Forms.DateTimePicker();
this.label4 = new System.Windows.Forms.Label();
this.label5 = new System.Windows.Forms.Label();
this.panel1.SuspendLayout();
this.groupBox_sports.SuspendLayout();
this.groupBox_disciplines.SuspendLayout();
this.groupBox_goals.SuspendLayout();
this.groupBox_Start.SuspendLayout();
this.groupBox_end.SuspendLayout();
this.SuspendLayout();
// 
// panel1
// 
this.panel1.BackColor = System.Drawing.Color.White;
this.panel1.Controls.Add(this.label5);
this.panel1.Controls.Add(this.label4);
this.panel1.Controls.Add(this.label3);
this.panel1.Controls.Add(this.label2);
this.panel1.Controls.Add(this.label1);
this.panel1.Location = new System.Drawing.Point(170, -3);
this.panel1.Name = "panel1";
this.panel1.Size = new System.Drawing.Size(756, 424);
this.panel1.TabIndex = 0;
this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
// 
// label3
// 
this.label3.AutoSize = true;
this.label3.ForeColor = System.Drawing.Color.Black;
this.label3.Location = new System.Drawing.Point(628, 411);
this.label3.Name = "label3";
this.label3.Size = new System.Drawing.Size(0, 13);
this.label3.TabIndex = 2;
// 
// label2
// 
this.label2.AutoSize = true;
this.label2.ForeColor = System.Drawing.Color.Black;
this.label2.Location = new System.Drawing.Point(3, 411);
this.label2.Name = "label2";
this.label2.Size = new System.Drawing.Size(0, 13);
this.label2.TabIndex = 1;
// 
// label1
// 
this.label1.AutoSize = true;
this.label1.Location = new System.Drawing.Point(779, 148);
this.label1.Name = "label1";
this.label1.Size = new System.Drawing.Size(51, 13);
this.label1.TabIndex = 0;
this.label1.Text = "Графики";
// 
// groupBox_sports
// 
this.groupBox_sports.BackColor = System.Drawing.Color.Transparent;
this.groupBox_sports.Controls.Add(this.sportsCB);
this.groupBox_sports.Location = new System.Drawing.Point(12, 12);
this.groupBox_sports.Name = "groupBox_sports";
this.groupBox_sports.Size = new System.Drawing.Size(138, 55);
this.groupBox_sports.TabIndex = 24;
this.groupBox_sports.TabStop = false;
this.groupBox_sports.Text = "Виды спорта";
// 
// sportsCB
// 
this.sportsCB.FormattingEnabled = true;
this.sportsCB.Location = new System.Drawing.Point(6, 19);
this.sportsCB.Name = "sportsCB";
this.sportsCB.Size = new System.Drawing.Size(125, 21);
this.sportsCB.TabIndex = 3;
this.sportsCB.SelectedIndexChanged += new System.EventHandler(this.sportsCB_SelectedIndexChanged);
// 
// groupBox_disciplines
// 
this.groupBox_disciplines.BackColor = System.Drawing.Color.Transparent;
this.groupBox_disciplines.Controls.Add(this.disciplinesCB);
this.groupBox_disciplines.Enabled = false;
this.groupBox_disciplines.Location = new System.Drawing.Point(12, 73);
this.groupBox_disciplines.Name = "groupBox_disciplines";
this.groupBox_disciplines.Size = new System.Drawing.Size(138, 55);
this.groupBox_disciplines.TabIndex = 25;
this.groupBox_disciplines.TabStop = false;
this.groupBox_disciplines.Text = "Дисциплина";
// 
// disciplinesCB
// 
this.disciplinesCB.FormattingEnabled = true;
this.disciplinesCB.Location = new System.Drawing.Point(6, 19);
this.disciplinesCB.Name = "disciplinesCB";
this.disciplinesCB.Size = new System.Drawing.Size(126, 21);
this.disciplinesCB.TabIndex = 15;
this.disciplinesCB.SelectedIndexChanged += new System.EventHandler(this.disciplinesCB_SelectedIndexChanged);
// 
// groupBox_goals
// 
this.groupBox_goals.BackColor = System.Drawing.Color.Transparent;
this.groupBox_goals.Controls.Add(this.goalsCB);
this.groupBox_goals.Enabled = false;
this.groupBox_goals.Location = new System.Drawing.Point(12, 134);
this.groupBox_goals.Name = "groupBox_goals";
this.groupBox_goals.Size = new System.Drawing.Size(138, 55);
this.groupBox_goals.TabIndex = 26;
this.groupBox_goals.TabStop = false;
this.groupBox_goals.Text = "Цель";
// 
// goalsCB
// 
this.goalsCB.FormattingEnabled = true;
this.goalsCB.Location = new System.Drawing.Point(6, 19);
this.goalsCB.Name = "goalsCB";
this.goalsCB.Size = new System.Drawing.Size(125, 21);
this.goalsCB.TabIndex = 18;
this.goalsCB.SelectedIndexChanged += new System.EventHandler(this.goalsCB_SelectedIndexChanged);
// 
// groupBox_Start
// 
this.groupBox_Start.BackColor = System.Drawing.Color.Transparent;
this.groupBox_Start.Controls.Add(this.datetimeStart);
this.groupBox_Start.Enabled = false;
this.groupBox_Start.Location = new System.Drawing.Point(12, 195);
this.groupBox_Start.Name = "groupBox_Start";
this.groupBox_Start.Size = new System.Drawing.Size(138, 54);
this.groupBox_Start.TabIndex = 31;
this.groupBox_Start.TabStop = false;
this.groupBox_Start.Text = "Начало периода";
// 
// datetimeStart
// 
this.datetimeStart.Location = new System.Drawing.Point(6, 19);
this.datetimeStart.Name = "datetimeStart";
this.datetimeStart.Size = new System.Drawing.Size(125, 20);
this.datetimeStart.TabIndex = 27;
this.datetimeStart.ValueChanged += new System.EventHandler(this.datetimeStart_ValueChanged);
// 
// groupBox_end
// 
this.groupBox_end.BackColor = System.Drawing.Color.Transparent;
this.groupBox_end.Controls.Add(this.datetimeEnd);
this.groupBox_end.Enabled = false;
this.groupBox_end.Location = new System.Drawing.Point(12, 255);
this.groupBox_end.Name = "groupBox_end";
this.groupBox_end.Size = new System.Drawing.Size(138, 54);
this.groupBox_end.TabIndex = 31;
this.groupBox_end.TabStop = false;
this.groupBox_end.Text = "Конец периода";
// 
// datetimeEnd
// 
this.datetimeEnd.Location = new System.Drawing.Point(6, 19);
this.datetimeEnd.Name = "datetimeEnd";
this.datetimeEnd.Size = new System.Drawing.Size(125, 20);
this.datetimeEnd.TabIndex = 27;
this.datetimeEnd.ValueChanged += new System.EventHandler(this.datetimeEnd_ValueChanged);
// 
// label4
// 
this.label4.AutoSize = true;
this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
this.label4.Location = new System.Drawing.Point(617, 12);
this.label4.Name = "label4";
this.label4.Size = new System.Drawing.Size(59, 13);
this.label4.TabIndex = 3;
this.label4.Text = "Результат";
// 
// label5
// 
this.label5.AutoSize = true;
this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
this.label5.Location = new System.Drawing.Point(617, 34);
this.label5.Name = "label5";
this.label5.Size = new System.Drawing.Size(0, 18);
this.label5.TabIndex = 4;
// 
// Graphic
// 
this.BackColor = System.Drawing.SystemColors.Control;
this.BackgroundImage = global::Sportsmen_Monitoring.Properties.Resources.arrows_mirror;
this.ClientSize = new System.Drawing.Size(924, 421);
this.Controls.Add(this.groupBox_end);
this.Controls.Add(this.groupBox_Start);
this.Controls.Add(this.groupBox_goals);
this.Controls.Add(this.groupBox_disciplines);
this.Controls.Add(this.groupBox_sports);
this.Controls.Add(this.panel1);
this.ForeColor = System.Drawing.SystemColors.Control;
this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
this.MaximizeBox = false;
this.Name = "Graphic";
this.Text = "Графики результатов";
this.Load += new System.EventHandler(this.Graphic_Load);
this.ClientSizeChanged += new System.EventHandler(this.Graphic_Resize);
this.Resize += new System.EventHandler(this.Graphic_Resize);
this.panel1.ResumeLayout(false);
this.panel1.PerformLayout();
this.groupBox_sports.ResumeLayout(false);
this.groupBox_disciplines.ResumeLayout(false);
this.groupBox_goals.ResumeLayout(false);
this.groupBox_Start.ResumeLayout(false);
this.groupBox_end.ResumeLayout(false);
this.ResumeLayout(false);

        }

        private void Graphic_Resize(object sender, EventArgs e) // по изменению формы
        {
            panel1.Width = Width;
            panel1.Height = Height;
            drawGrid();
            drawOsi();
            Refresh();
            panel1.Refresh();
        }

        private void Graphic_Load(object sender, EventArgs e)
        {
            sportsCB.Items.AddRange(Model.Instance.Sports.ToArray());
        }

        private void sportsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentSports = sportsCB.SelectedItem as Sport;
            disciplinesCB.Items.Clear();
            disciplinesCB.Items.AddRange(Model.Instance.Disciplines.Where(a => a.Sport.ID == currentSports.ID).ToArray());
            groupBox_disciplines.Enabled = true;
        }

        private void disciplinesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentDiscipline = disciplinesCB.SelectedItem as Discipline;
            goalsCB.Items.Clear();
            goalsCB.Items.AddRange(Model.Instance.Goals.Where(a => a.Discipline.ID == currentDiscipline.ID /*&& a.Owner.ID == Model.Instance.CurrentUser.UserCoach.ID*/).ToArray());
            groupBox_goals.Enabled = true;
        }

        private void datetimeStart_ValueChanged(object sender, EventArgs e)
        {
            //label1.Text = Model.Instance.Users_Datas.Where(a => a.Date > datetimeStart.Value && a.Date < datetimeEnd.Value).Select(temp => temp.value).ToArray(); 
            
            label3.Text = datetimeEnd.Value.ToString();
            
            daysCount = (datetimeEnd.Value.Date - datetimeStart.Value.Date).Days + 1;
            
            panel1.Refresh();
            drawPoints();

            label2.Text = datetimeStart.Value.Date.ToShortDateString();
            label3.Text = datetimeEnd.Value.Date.ToShortDateString();
            
        }

        private void goalsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox_Start.Enabled = true;
            groupBox_end.Enabled = true;
        }

        private void datetimeEnd_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = datetimeEnd.Value.ToString();
            daysCount = (datetimeEnd.Value.Date - datetimeStart.Value.Date).Days + 1;

            panel1.Refresh();
            drawPoints();

            label2.Text = datetimeStart.Value.Date.ToShortDateString();
            label3.Text = datetimeEnd.Value.Date.ToShortDateString();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (isLines == true)
            //{
                label5.Text = ((424 - Cursor.Position.Y) / step).ToString(); 
                /*Brush br = new SolidBrush(Color.DarkGray);
                Pen pen = new Pen(br);
                Brush brush = new SolidBrush(Color.White);
                Pen p = new Pen(brush);
                if (Cursor.Position.X > curX + 5 || Cursor.Position.X < curX - 5 || Cursor.Position.Y < curY - 5 || Cursor.Position.Y > curY + 5)
                {
                    Refresh();
                    //graph.DrawLine(p, curX - 197, curY - 55, 20, curY - 55);
                    //graph.DrawLine(p, curX - 197, curY - 55, curX - 197, panel1.Height - 20);
                    drawOsi();
                    drawGrid();
                    
                    graph.DrawLine(pen, Cursor.Position.X - 197, Cursor.Position.Y - 55, 20, Cursor.Position.Y - 55);
                    graph.DrawLine(pen, Cursor.Position.X - 197, Cursor.Position.Y - 55, Cursor.Position.X - 197, panel1.Height - 20);
                    curX = Cursor.Position.X;
                    curY = Cursor.Position.Y;*/
                //}
            //}
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            //isLines = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            //isLines = false;
        }

       
    }
}
