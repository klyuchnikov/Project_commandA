using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Superadmin.ServiceConnectServer;

namespace Superadmin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var users = Model.Instance.client.GetAllUsers();
            foreach (var a in users)
            {
                    UsersLB.Items.Add(a);
            }
            for (int i = 0; i < UsersLB.Items.Count; i++)
            {
                if ((UsersLB.Items[i] as Users).Right == 2)
                    UsersLB.SetItemChecked(i, true);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveButton.Enabled = false;
            for (int i = 0; i < UsersLB.Items.Count; i++)
            {
                var user = UsersLB.Items[i] as Users;
                try
                {
                  var res =   Model.Instance.client.SetUserCoach(user.Id, UsersLB.GetItemChecked(i));
                  if (!res)
                  {
                      errorLabel.Visible = true;
                      SuccessLabel.Visible = false;
                      return;
                  }
                }
                catch (Exception ee)
                {
                    errorLabel.Visible = true;
                    SuccessLabel.Visible = false;
                }
            }

            SaveButton.Enabled = true;
            errorLabel.Visible = false;
            SuccessLabel.Visible = true;
        }

    }
}
