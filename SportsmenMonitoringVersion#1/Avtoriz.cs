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
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void authB_Click(object sender, EventArgs e)
        {
            if (loginTB.Text == "" || passTB.Text == "")
            {
                errorLabel.Visible = true;
                return;
            }
            waitLabel.Visible = true;
            Refresh();
            authB.Enabled = false;
            var res = Model.Authorization(loginTB.Text, passTB.Text);
            if (res)
            {
                var user = Model.Instance.Users.SingleOrDefault(a => a.AspnetUserLogin == loginTB.Text);
                if (user == null)
                {
                    var uu = Model.Instance.client.GetUserFromLogin(loginTB.Text);
                    var coach = Model.Instance.Users.SingleOrDefault(a => a.ID == uu.CoachId);
                    if (uu.CoachId != 0)
                    {
                        if (coach == null)
                        {
                            var u = Model.Instance.client.GetUserFromId(uu.CoachId);
                            var aspnetuser = Model.Instance.client.Getaspnet_Users(u.AspnetUserId);
                            coach = new User(u.Id, u.FirstName, u.Name, u.Patronumic, u.DateBirth, aspnetuser.UserName, u.AspnetUserId, u.Right, null, null);
                            Model.Instance.Users.Add(coach);
                        }
                    }
                    user = new User(uu.Id, uu.FirstName, uu.Name, uu.Patronumic, uu.DateBirth, loginTB.Text, uu.AspnetUserId, uu.Right, coach, passTB.Text);
                    Model.Instance.Users.Add(user);
                }
                Model.Instance.CurrentUser = user;
                Model.Instance.Synchronization();
                user.UpdatePass(passTB.Text);
                Form form;
                if (user.Right == 2)
                    form = new Form_Input_Admin();
                else// if (user.Right == 1)
                    form = new Form_Input();
                Hide();
                form.ShowDialog();
                Close();
            } // переход на главную форму
            if (!res)
            {
                errorLabel.Visible = true;

                waitLabel.Visible = false;
                Refresh();
                authB.Enabled = true;
            }

        }

        private void reginstrationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new FormRegistration();
            Hide();
            form.ShowDialog();
            Show();
        }

    }
}
