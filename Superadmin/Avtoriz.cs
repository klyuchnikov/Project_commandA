using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Superadmin
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private BackgroundWorker bw = new BackgroundWorker { WorkerSupportsCancellation = true };

        private void authB_Click(object sender, EventArgs e)
        {
            bool Res = false;
            if (loginTB.Text == "" || passTB.Text == "")
            {
                errorLabel.Visible = true;
                return;
            }
         /*   bw.DoWork += delegate
            {
                bool res = false;
                try
                {
                    res = Model.Instance.client.AuthSuperAdmin(loginTB.Text, passTB.Text);
                }
                catch (Exception eee)
                {
                    res = false;
                }
                Res = res;
            };
            bw.RunWorkerAsync();
            while (true)
            {
                progressBar1.PerformStep();
                Thread.Sleep(100);
                if (progressBar1.Value == progressBar1.Maximum)
                    progressBar1.Value = 0;
                if (!bw.IsBusy)
                    break;
            }
          */
            waitLabel.Visible = true;
            Refresh();
            authB.Enabled = false;
            Res = Model.Instance.client.AuthSuperAdmin(loginTB.Text, passTB.Text);

            authB.Enabled = true;
            waitLabel.Visible = false;
            if (Res)
            {
                Hide();
                var form = new MainForm();
                form.ShowDialog();
                Close();
            } // переход на главную форму
            if (!Res)
            {
                errorLabel.Visible = true;
                waitLabel.Visible = false;
            }

        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            loginTB.Focus();
        }

        private void passTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = false;
                authB_Click(sender, e);
            }
        }

    }
}
