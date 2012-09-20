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
    public partial class AddSports : Form
    {
        int i;
        public AddSports()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelRed.Visible = false;
            panelMain.Visible = false;
            panelAdd.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Model.Instance.Sports.Add(new Sport { Name = textBox1.Text });
            listBox1.Items.AddRange(Model.Instance.Sports.ToArray());
            textBox1.Text = "";
            panelMain.Visible = true;
            panelAdd.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                var item = Model.Instance.Sports.Single(a => a.Name == listBox1.Items[listBox1.SelectedIndex].ToString());
                item.Name = textBox2.Text;
                listBox1.Items[listBox1.SelectedIndex] = textBox2.Text;
            }
            panelRed.Visible = false;
            panelMain.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int j = 0; j <= listBox1.Controls.Count; j++)
            {

                Model.Instance.Sports.Remove(Model.Instance.Sports.Single(a => a.Name == listBox1.Items[listBox1.SelectedIndex].ToString()));
                Model.Instance.SaveBinaryFormat();
                listBox1.Items.RemoveAt(i);
            }
            panelMain.Visible = true;
            panelYesNo.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            panelYesNo.Visible = false;
        }

        private void listBox1_Leave(object sender, EventArgs e)
        {
            i = listBox1.SelectedIndex;
        }

        private void AddSports_Load(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelRed.Visible = false;
            panelYesNo.Visible = false;
        }
    }
}
