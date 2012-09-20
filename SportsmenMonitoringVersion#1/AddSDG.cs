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
    public partial class AddSDG : Form
    {
        int i, z, n;
        int s = 0, d = 0, g = 0;
        public AddSDG()
        {
            InitializeComponent();
        }

        private void buttonYesSport_Click(object sender, EventArgs e)
        {
            for (int j = 0; j <= listBox1.Controls.Count; j++)
            {
                Model.Instance.Sports.Remove(Model.Instance.Sports.Single(a => a.Name == listBox1.Items[listBox1.SelectedIndex].ToString()));
                Model.Instance.SaveBinaryFormat();
                listBox1.Items.RemoveAt(i);
            }
            panelMainSport.Visible = true;
            panelYesNoSport.Visible = false;
        }

        private void buttonNoSports_Click(object sender, EventArgs e)
        {
            panelMainSport.Visible = true;
            panelYesNoSport.Visible = false;
        }

        private void buttonRedSport_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                var item = Model.Instance.Sports.Single(a => a.Name == listBox1.Items[listBox1.SelectedIndex].ToString());
                Model.Instance.Sports.Add(item);
                listBox1.Items[listBox1.SelectedIndex] = textBoxRedSport.Text;
            }
            panelRedSport.Visible = false;
            panelMainSport.Visible = true;
        }

        private void buttonAddSport_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Model.Instance.Sports.Add(new Sport(0, textBoxAddSport.Text));
            listBox1.Items.AddRange(Model.Instance.Sports.ToArray());
            textBoxAddSport.Text = "";
            panelMainSport.Visible = true;
            panelAddSport.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                panelYesNoSport.Visible = true;
                panelRedSport.Visible = false;
                panelMainSport.Visible = false;
                panelAddSport.Visible = false;
            }
            else
            { MessageBox.Show("Вы не выбрали нужный item для удаления"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                textBoxRedSport.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                panelRedSport.Visible = true;
                panelMainSport.Visible = false;
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужный item");
                panelRedSport.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelRedSport.Visible = false;
            panelMainSport.Visible = false;
            panelAddSport.Visible = true;
        }

        private void buttonYesDisciplines_Click(object sender, EventArgs e)
        {
            for (int j = 0; j <= listBox2.Controls.Count; j++)
            {
                Model.Instance.Disciplines.Remove(Model.Instance.Disciplines.Single(a => a.Name == listBox2.Items[listBox2.SelectedIndex].ToString()));
                Model.Instance.SaveBinaryFormat();
                listBox2.Items.RemoveAt(z);
            }
            panelMainDisciplines.Visible = true;
            panelYesNoDisciplines.Visible = false;
        }

        private void buttonNoDisciplines_Click(object sender, EventArgs e)
        {
            panelMainDisciplines.Visible = true;
            panelYesNoDisciplines.Visible = false;
        }

        private void buttonRedDisciplines_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                var item = Model.Instance.Disciplines.Single(a => a.Name == listBox2.Items[listBox2.SelectedIndex].ToString());
                Model.Instance.Disciplines.Add(item);
                listBox2.Items[listBox2.SelectedIndex] = textBoxRedSport.Text;
            }
            panelRedDisciplines.Visible = false;
            panelMainDisciplines.Visible = true;
        }

        private void buttonAddDisciplines_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Model.Instance.Disciplines.Add(new Discipline(0, textBoxNameDisciplines.Text, (comboBoxDisciplines.SelectedItem as Sport), (comboBoxScaleDisciplines.SelectedItem as Scale), textBoxDescripDisciplines.Text));
            listBox2.Items.AddRange(Model.Instance.Disciplines.ToArray());
            textBoxNameDisciplines.Text = "";
            panelMainDisciplines.Visible = true;
            panelAddDisciplines.Visible = false;
        }

        private void buttonDelDisciplines_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                panelYesNoDisciplines.Visible = true;
                panelRedDisciplines.Visible = false;
                panelMainDisciplines.Visible = false;
                panelAddDisciplines.Visible = false;
            }
            else
            { MessageBox.Show("Вы не выбрали нужный item для удаления"); }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                textBoxRedSport.Text = listBox2.Items[listBox2.SelectedIndex].ToString();
                panelRedDisciplines.Visible = true;
                panelMainDisciplines.Visible = false;
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужный item");
                panelRedDisciplines.Visible = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panelMainDisciplines.Visible = false;
            panelAddDisciplines.Visible = true;
        }

        private void listBox1_Leave(object sender, EventArgs e)
        {
            i = listBox1.SelectedIndex;
        }

        private void listBox2_Leave(object sender, EventArgs e)
        {
            z = listBox2.SelectedIndex;
        }

        private void button1YesGoals_Click(object sender, EventArgs e)
        {
            for (int j = 0; j <= listBox3.Controls.Count; j++)
            {
                Model.Instance.Goals.Remove(Model.Instance.Goals.Single(a => a.Description == listBox3.Items[listBox3.SelectedIndex].ToString()));
                Model.Instance.SaveBinaryFormat();
                listBox3.Items.RemoveAt(n);
            }
            panelMainGoals.Visible = true;
            panelYesNoGoals.Visible = false;
        }

        private void buttonNoGoals_Click(object sender, EventArgs e)
        {
            panelYesNoGoals.Visible = false;
            panelMainGoals.Visible = true;
        }

        private void buttonRedGoals_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex > -1)
            {
                var item = Model.Instance.Goals.Single(a => a.Description == listBox3.Items[listBox3.SelectedIndex].ToString());
                Model.Instance.Goals.Add(item);
                listBox3.Items[listBox3.SelectedIndex] = textBoxRedGoals.Text;
            }
            panelRedGoals.Visible = false;
            panelMainGoals.Visible = true;
        }

        private void buttonAddGoals_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            //Model.Instance.Goals.Add(new Goal(0, "", (comboBoxAddDiscGoal.SelectedItem as Discipline), (short)(dateTimePickerStartGoal.MinDate - dateTimeEndGoal.MaxDate + 1), textBoxAddGoals.Text, ""));
            listBox1.Items.AddRange(Model.Instance.Goals.ToArray());
            textBoxAddGoals.Text = "";
            panelMainGoals.Visible = true;
            panelAddGoals.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex > -1)
            {
                panelYesNoGoals.Visible = true;
                panelRedGoals.Visible = false;
                panelMainGoals.Visible = false;
                panelAddGoals.Visible = false;
            }
            else
            { MessageBox.Show("Вы не выбрали нужный item для удаления"); }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex > -1)
            {
                textBoxRedGoals.Text = listBox3.Items[listBox3.SelectedIndex].ToString();
                panelRedGoals.Visible = true;
                panelMainGoals.Visible = false;
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужный item");
                panelRedGoals.Visible = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panelRedGoals.Visible = false;
            panelMainGoals.Visible = false;
            panelAddGoals.Visible = true;
        }

        private void listBox3_Leave(object sender, EventArgs e)
        {
            n = listBox3.SelectedIndex;
        }

        private void AddSDG_Load(object sender, EventArgs e)
        {
            panelAddSport.Visible = false;
            panelRedSport.Visible = false;
            panelYesNoSport.Visible = false;
            panelAddSport.Visible = false;
            panelAddGoals.Visible = false;
            panelAddGoals.Visible = false;
            panelAddGoals.Visible = false;
            panelRedGoals.Visible = false;
            panelYesNoGoals.Visible = false;
            panelAddDisciplines.Visible = false;
            panelRedDisciplines.Visible = false;
            panelYesNoDisciplines.Visible = false;
            panelSports.Visible = false;
            panelDisciplines.Visible = false;
            panelGoals.Visible = false;
            comboBoxDisciplines.Items.AddRange(Model.Instance.Sports.ToArray());
            comboBoxDisciplines.Items.AddRange(Model.Instance.Sports.Where(q => q.ID == (comboBoxDisciplines.SelectedItem as Sport).ID).ToArray());

            // для Goals
            comboBoxAddSportGoal.Items.AddRange(Model.Instance.Sports.ToArray());
            comboBoxAddDiscGoal.Items.AddRange(Model.Instance.Sports.Where(q => q.ID == (comboBoxAddDiscGoal.SelectedItem as Sport).ID).ToArray());
        }

        private void buttonAdd_Sport_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                panelSports.Visible = true;
                s++;
            }
            else { panelSports.Visible = false; s--; }
        }

        private void buttonAdd_Disciplines_Click(object sender, EventArgs e)
        {
            if (d == 0)
            {
                panelDisciplines.Visible = true;
                d++;
            }
            else
            { panelDisciplines.Visible = false; d--; }
            
        }

        private void buttonAdd_Goals_Click(object sender, EventArgs e)
        {
            if (g == 0)
            {
                panelGoals.Visible = true;
                g++;
            }
            else { panelGoals.Visible = false; g--; }
        }

        private void comboBoxDisciplines_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(Model.Instance.Disciplines.Where(a => a.Sport.ID == (comboBoxDisciplines.SelectedItem as Sport).ID).ToArray());
        }
    }
}
