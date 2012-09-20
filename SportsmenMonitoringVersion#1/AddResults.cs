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
    public partial class AddResults : Form
    {
        public AddResults()
        {
            InitializeComponent();
        }

        private void buttonToGraph_Click(object sender, EventArgs e)
        {
            AddResults ar = new AddResults();
            Graphic gr = new Graphic();
            ar.Close();
            gr.Show();
        }

        private void buttonAddRes_Click(object sender, EventArgs e)
        {
            FormAuth fa = new FormAuth();
            fa.Show();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            Form_Input fi = new Form_Input();
            fi.Show();
        }

        private void buttonAdminData_Click(object sender, EventArgs e)
        {
            Form_Input_Admin fia = new Form_Input_Admin();
            fia.Show();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            FormRegistration fr = new FormRegistration();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
