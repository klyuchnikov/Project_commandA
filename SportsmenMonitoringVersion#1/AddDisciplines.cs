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
    public partial class AddDisciplines : Form
    {
        int i;
        public AddDisciplines()
        {
            InitializeComponent();
        }

        private void listBox1_Leave(object sender, EventArgs e)
        {
            i = listBox1.SelectedIndex;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            for (int j = 0; j <= listBox1.Controls.Count; j++)
            {
                Model.Instance.Disciplines.Remove(Model.Instance.Disciplines.Single(a => a.Name == listBox1.Items[listBox1.SelectedIndex].ToString()));
                Model.Instance.SaveBinaryFormat();
                listBox1.Items.RemoveAt(i);
            }
            panelMain.Visible = true;
            panelYesNo.Visible = false;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            panelYesNo.Visible = false;
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                var item = Model.Instance.Disciplines.Single(a => a.Name == listBox1.Items[listBox1.SelectedIndex].ToString());
                item.Name = textBox2.Text;
                listBox1.Items[listBox1.SelectedIndex] = textBox2.Text;
            }
            panelRed.Visible = false;
            panelMain.Visible = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Model.Instance.Disciplines.Add(new Discipline { Name = textBox1.Text });
            listBox1.Items.AddRange(Model.Instance.Disciplines.ToArray());
            textBox1.Text = "";
            panelMain.Visible = true;
            panelAdd.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex > -1)
            {
                panelYesNo.Visible = true;
                panelRed.Visible = false;
                panelMain.Visible = false;
                panelAdd.Visible = false;
            }
            else
            { MessageBox.Show("Вы не выбрали нужный item для удаления"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                textBox2.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                panelRed.Visible = true;
                panelMain.Visible = false;
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужный item");
                panelRed.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelAdd.Visible = true;
        }

        private void AddDisciplines_Load(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelRed.Visible = false;
            panelYesNo.Visible = false;

            comboBoxSports.Items.AddRange(Model.Instance.Sports.ToArray());
        }
    }
}
