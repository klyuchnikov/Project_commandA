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
    public partial class AddGoals : Form
    {
        int i;
        public AddGoals()
        {
            InitializeComponent();
        }

        private void listBox1_Leave(object sender, EventArgs e)
        {
            i = listBox1.SelectedIndex;
        }

        private void AddGoals_Load(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelRed.Visible = false;
            panelYesNo.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelRed.Visible = false;
            panelMain.Visible = false;
            panelAdd.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                textBoxRed.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                panelRed.Visible = true;
                panelMain.Visible = false;
            }
            else
            {
                MessageBox.Show("Вы не выбрали нужный item");
                panelRed.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Model.Instance.Goals.Add(new Goal { Description = textBoxAdd.Text });
            listBox1.Items.AddRange(Model.Instance.Goals.ToArray());
            textBoxAdd.Text = "";
            panelMain.Visible = true;
            panelAdd.Visible = false;
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                var item = Model.Instance.Goals.Single(a => a.Description == listBox1.Items[listBox1.SelectedIndex].ToString());
                item.Description = textBoxRed.Text;
                listBox1.Items[listBox1.SelectedIndex] = textBoxRed.Text;
            }
            panelRed.Visible = false;
            panelMain.Visible = true;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            for (int j = 0; j <= listBox1.Controls.Count; j++)
            {
                Model.Instance.Goals.Remove(Model.Instance.Goals.Single(a => a.Description == listBox1.Items[listBox1.SelectedIndex].ToString()));
                Model.Instance.SaveBinaryFormat();
                listBox1.Items.RemoveAt(i);
            }
            panelMain.Visible = true;
            panelYesNo.Visible = false;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            panelYesNo.Visible = false;
            panelMain.Visible = true;
        }
    }
}
