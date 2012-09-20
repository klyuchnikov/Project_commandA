using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sportsmen_Monitoring
{
    public partial class Form_Input_Admin : Form
    {
        public Form_Input_Admin()
        {
            InitializeComponent();
        }

        int i, z, n;

        private void Form_Input_Load(object sender, EventArgs e)
        {
            foreach (var a in Model.Instance.Sports.ToArray())
            {
                sportsCB.Items.Add(new ComboBoxItem { Text = a.Name, Id = a.ID });
                sports_best_CB.Items.Add(new ComboBoxItem { Text = a.Name, Id = a.ID });
            }
            comboBoxSports.Items.AddRange(Model.Instance.Sports.ToArray());
            listBox1.Items.AddRange(Model.Instance.Sports.ToArray());
            comboBoxScaleDisciplines.Items.AddRange(Model.Instance.Scales.ToArray());
            //  comboBoxDisciplines.Items.AddRange(Model.Instance.Sports.Where(q => q.ID == (list.SelectedItem as Sport).ID).ToArray());

            // для Goals
            comboBoxAddSportGoal.Items.AddRange(Model.Instance.Sports.ToArray());
            //  comboBoxAddDiscGoal.Items.AddRange(Model.Instance.Sports.Where(q => q.ID == (comboBoxAddDiscGoal.SelectedItem as Sport).ID).ToArray());


        }

        private void sportsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentSportid = (sportsCB.SelectedItem as ComboBoxItem).Id;
            disciplinesCB.Items.Clear();

            //  disciplinesCB.Items.AddRange(Model.Instance.Disciplines.Where(a => a.Sport.ID == currentSportid).ToArray());
            var dis = Model.Instance.Disciplines.Where(q => q.Sport.ID == currentSportid).ToArray();
            foreach (var a in dis)
            {
                disciplinesCB.Items.Add(new ComboBoxItem { Id = a.ID, Text = a.Name });
            }
            groupBox_disciplines.Enabled = true;
        }

        private void disciplinesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentDisciplineid = (disciplinesCB.SelectedItem as ComboBoxItem).Id;
            goalsCB.Items.Clear();
            // goalsCB.Items.AddRange(Model.Instance.Goals.Where(a => a.Discipline.ID == currentDisciplineid).ToArray());

            var goals = Model.Instance.Goals.Where(q => q.Discipline.ID == currentDisciplineid).ToArray();
            foreach (var a in goals)
            {
                goalsCB.Items.Add(new ComboBoxItem { Text = a.Description, Id = a.ID });
            }
            groupBox_goals.Enabled = true;
        }

        private void goalsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentGoalid = (goalsCB.SelectedItem as ComboBoxItem).Id;
            groupBox_Start.Enabled = true;
            groupBox_end.Enabled = true;
            groupBox_sports.Enabled = true;

            var sub = datetimeEnd.Value - datetimeStart.Value;
            for (int i = 0; i < sub.Days + 1; i++)
            {
                var date = datetimeStart.Value.AddDays(i);
                var column = new DataGridViewColumn();
                column.Width = 70;
                column.HeaderText = date.ToShortDateString();
                dataGridView1.Columns.Add(column);
            }
            var users = Model.Instance.Users_Goals.Where(q => q.Goal.ID == currentGoalid).Select(q => q.User).ToArray();
            foreach (var a in users)
            {
                var row = new DataGridViewRow();
                foreach (var q in dataGridView1.Columns)
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = "" });
                row.ReadOnly = false;
                row.HeaderCell.Value = a.ToString();
                row.HeaderCell.Tag = a;
                dataGridView1.Rows.Add(row);
            }
            dataGridView1.RowHeadersWidth = 150;

        }

        private void datetimeStart_ValueChanged(object sender, EventArgs e)
        {
            ReGenDGV();
        }

        private void datetimeEnd_ValueChanged(object sender, EventArgs e)
        {
            ReGenDGV();
        }

        private void ReGenDGV()
        {
            var currentGoalid = (goalsCB.SelectedItem as ComboBoxItem).Id;
            var sub = datetimeEnd.Value.AddSeconds(5) - datetimeStart.Value;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            if (datetimeStart.Value.Date > datetimeEnd.Value.Date)
                return;
            for (int i = 0; i < sub.Days + 1; i++)
            {
                var date = datetimeStart.Value.AddDays(i);
                var column = new DataGridViewColumn();
                column.Width = 70;
                column.HeaderText = date.ToShortDateString();
                dataGridView1.Columns.Add(column);
            }
            foreach (var a in Model.Instance.Users_Goals.Where(q => q.Goal.ID == currentGoalid).Select(q => q.User).ToArray())
            {
                var row = new DataGridViewRow();
                foreach (var q in dataGridView1.Columns)
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = "" });
                row.ReadOnly = false;
                row.HeaderCell.Value = a.ToString();
                row.HeaderCell.Tag = a;
                dataGridView1.Rows.Add(row);
            }
        }

        private void PostedDataButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Данных нет!");
                return;
            }
            try
            {
                foreach (var row in dataGridView1.Rows.OfType<DataGridViewRow>())
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        float pars = -1;
                        var res = float.TryParse(row.Cells[i].Value as string, out pars);
                        if (!res)
                        {
                            MessageBox.Show("Поля заполнены неправильно!");
                            return;
                        }
                        if (pars == 0)
                        {
                            MessageBox.Show("Поля заполнены не все!");
                            return;
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Поля заполнены неправильно!");
                return;
            }

            foreach (var row in dataGridView1.Rows.OfType<DataGridViewRow>())
            {
                var User_Goalid = Model.Instance.Users_Goals.First(q => q.User.ID == (row.HeaderCell.Tag as User).ID).ID;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    var column = dataGridView1.Columns[i];
                    var day = DateTime.Parse(column.HeaderText);
                    Model.Instance.Users_Datas.Add(new User_Data(0, Model.Instance.Users_Goals.Single(q => q.ID == User_Goalid), float.Parse(row.Cells[i].Value as string), day)); //    { User_Goal = User_Goal, Date = day, value = float.Parse(row.Cells[i].Value as string) });
                    Model.Instance.SaveBinaryFormat();
                }
                PostedDataButton.Visible = false;
                DataPostedLabel.Visible = true;
                ViewGrafics.Visible = true;
            }
        }
        private void ViewGrafics_Click(object sender, EventArgs e)
        {
            var form = new Graphic();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentSportsid = (sports_best_CB.SelectedItem as ComboBoxItem).Id;
            disciplines_best_CB.Items.Clear();

            //      disciplines_best_CB.Items.AddRange(Model.Instance.Disciplines.Where(a => a.Sport.ID == currentSportsid).ToArray());

            var dis = Model.Instance.Disciplines.Where(q => q.Sport.ID == currentSportsid).ToArray();
            foreach (var a in dis)
            {
                disciplines_best_CB.Items.Add(new ComboBoxItem { Id = a.ID, Text = a.Name });
            }
            groupBox_disciplines_best.Enabled = true;
        }

        private void disciplines_best_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentDisciplineid = (disciplines_best_CB.SelectedItem as ComboBoxItem).Id;
            goals_best_CB.Items.Clear();

            //    goals_best_CB.Items.AddRange(Model.Instance.Goals.Where(a => a.Discipline.ID == currentDisciplineid).ToArray());

            var goals = Model.Instance.Goals.Where(q => q.Discipline.ID == currentDisciplineid).ToArray();
            foreach (var a in goals)
            {
                goals_best_CB.Items.Add(new ComboBoxItem { Text = a.Description, Id = a.ID });
            }

            groupBox_goals_best.Enabled = true;
        }

        private void goals_best_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentGoalid = (goals_best_CB.SelectedItem as ComboBoxItem).Id;
            groupBox_sports_best.Enabled = true;

            for (int i = 1; i <= Model.Instance.Goals.Single(a => a.ID == currentGoalid).PeriodDays; i++)
            {
                var column = new DataGridViewColumn();
                column.Width = 70;
                column.HeaderText = "День " + i.ToString();
                dataGridView_bestDatas.Columns.Add(column);

            }

            var row = new DataGridViewRow();

            for (int i = 1; i <= Model.Instance.Goals.Single(a => a.ID == currentGoalid).PeriodDays; i++)
            {
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = "" });
                row.ReadOnly = false;
            }

            dataGridView_bestDatas.Rows.Add(row);

            groupBox_goal_info.Visible = true;
            groupBox_goal_info.Enabled = true;

            label_srok.Text = "Срок: " + Model.Instance.Goals.Single(a => a.ID == currentGoalid).PeriodDays.ToString() + " дней";
            label_description.Text = "Описание: " + Model.Instance.Goals.Single(a => a.ID == currentGoalid).Description;
        }

        private void button_Send_best_Click(object sender, EventArgs e)
        {
            // ОТРЕДАКТИРОВАТЬ!
            if (dataGridView_bestDatas.Rows.Count == 0)
            {
                MessageBox.Show("Данных нет!");
                return;
            }
            try
            {
                foreach (var row in dataGridView_bestDatas.Rows.OfType<DataGridViewRow>())
                {
                    for (int i = 0; i < dataGridView_bestDatas.Columns.Count; i++)
                    {
                        float pars = -1;
                        var res = float.TryParse(row.Cells[i].Value as string, out pars);
                        if (!res)
                        {
                            MessageBox.Show("Поля заполнены неправильно!");
                            return;
                        }
                        if (pars == 0)
                        {
                            MessageBox.Show("Поля заполнены не все!");
                            return;
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Поля заполнены неправильно!");
                return;
            }

            foreach (var row in dataGridView_bestDatas.Rows.OfType<DataGridViewRow>())
            {
                //var User_Goal = row.HeaderCell.Tag as User_Goal;
                for (int i = 0; i < dataGridView_bestDatas.Columns.Count; i++)
                {
                    var column = dataGridView1.Columns[i];
                    //var day = DateTime.Parse(column.HeaderText);
                    //  Model.Instance.Standarts_Datas.Add(new Standart_Data( // { Goal = (goalsCB.SelectedItem as Goal) });
                    Model.Instance.SaveBinaryFormat();
                }
                PostedDataButton.Visible = false;
                DataPostedLabel.Visible = true;
                ViewGrafics.Visible = true;
            }
        }

        /*
         * 
         * 
         *  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!ЧАСТЬ АНДРЕЯ!!!!!!!!!!!!!!!!
         * 
         * 
         */

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
            // listBox1.Items.AddRange(Model.Instance.Sports.ToArray());
            foreach (var a in Model.Instance.Sports.ToArray())
            {
                listBox1.Items.Add(new ComboBoxItem { Text = a.Name, Id = a.ID });
            }
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
            { MessageBox.Show("Вы не выбрали нужный пункт для удаления"); }
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
                MessageBox.Show("Вы не выбрали нужный пункт");
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
            var mysportid = (comboBoxSports.SelectedItem as Sport).ID;
            var myscaleid = (comboBoxScaleDisciplines.SelectedItem as Scale).ID;
            Model.Instance.Disciplines.Add(new Discipline(0, textBoxNameDisciplines.Text, Model.Instance.Sports.Single(q => q.ID == mysportid), Model.Instance.Scales.Single(a => a.ID == myscaleid), textBoxDescripDisciplines.Text));

            //listBox2.Items.AddRange(Model.Instance.Disciplines.ToArray());
            listBox2.Items.Clear();
            foreach (var a in Model.Instance.Disciplines.Where(a => a.Sport.ID == myscaleid).ToArray())
            {
                listBox2.Items.Add(new ComboBoxItem { Id = a.ID, Text = a.Name });
            }

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
            { MessageBox.Show("Вы не выбрали нужный пункт для удаления"); }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
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
                item.Update(double.Parse(valueEditTB.Text), item.Discipline, int.Parse(perEditTB.Text), textBoxRedGoals.Text, item.Owner);
                //Model.Instance.Goals.Add(item);
                listBox3.Items[listBox3.SelectedIndex] = textBoxRedGoals.Text;
            }
            panelRedGoals.Visible = false;
            panelMainGoals.Visible = true;
        }

        private void buttonAddGoals_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            Model.Instance.Goals.Add(new Goal(0, int.Parse(ValueTB.Text), (comboBoxAddDiscGoal.SelectedItem as Discipline), (short)short.Parse(periodTB.Text), textBoxAddGoals.Text, Model.Instance.CurrentUser));
            foreach (var a in Model.Instance.Goals.ToArray())
            {
                listBox3.Items.Add(new ComboBoxItem { Text = a.Description == null ? a.Discipline.Name + " - " + a.Value + a.Discipline.Scale.Name : a.Description, Id = a.ID });
            }
            // listBox1.Items.AddRange(Model.Instance.Goals.ToArray());
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
                var item = Model.Instance.Goals.Single(a => a.Description == listBox3.Items[listBox3.SelectedIndex].ToString());
                
                textBoxRedGoals.Text = listBox3.Items[listBox3.SelectedIndex].ToString();

                valueEditTB.Text = item.Value.ToString();
                perEditTB.Text = item.PeriodDays.ToString();
                panelRedGoals.Visible = true;
                panelMainGoals.Visible = false;
                Refresh();
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
            Refresh();
        }

        private void listBox3_Leave(object sender, EventArgs e)
        {
            n = listBox3.SelectedIndex;
        }


        private void tabControl_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_Main.SelectedIndex == 2)
            {
                panelAddSport.Visible = false;
                panelRedSport.Visible = false;
                panelYesNoSport.Visible = false;
            }

            if (tabControl_Main.SelectedIndex == 3)
            {
                panelAddDisciplines.Visible = false;
                panelRedDisciplines.Visible = false;
                panelYesNoDisciplines.Visible = false;
            }

            if (tabControl_Main.SelectedIndex == 4)
            {
                panelAddGoals.Visible = false;
                panelRedGoals.Visible = false;
                panelYesNoGoals.Visible = false;
            }

        }
        private void comboBoxDisciplines_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange(Model.Instance.Disciplines.Where(a => a.Sport.ID == (comboBoxSports.SelectedItem as Sport).ID).ToArray());
        }

        private void comboBoxAddSportGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAddDiscGoal.Items.Clear();
            comboBoxAddDiscGoal.Items.AddRange(Model.Instance.Disciplines.Where(a => a.Sport.ID == (comboBoxAddSportGoal.SelectedItem as Sport).ID).ToArray());
       
        }

        private void comboBoxAddDiscGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox3.Items.AddRange(Model.Instance.Goals.Where(q => q.Discipline.ID == (comboBoxAddDiscGoal.SelectedItem as Discipline).ID).ToArray());
        }


    }
}
