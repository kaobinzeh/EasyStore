using EasyStore.Abstract;
using EasyStore.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyStore
{
    public partial class Register : Form
    {
        private UnitOfWork unitofwork = new UnitOfWork();

        public Register()
        {
            InitializeComponent();
            //pnlRegister.Hide();
            pnlSignIn.Show();
        }
        
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (validateRegisterForm())
            {
                var userStore = new UserStore<IdentityUser>();
                var manager = new UserManager<IdentityUser>(userStore);

                var user = new IdentityUser() { UserName = txtUsername.text };
                IdentityResult result = manager.Create(user, txtPassword.Text);

                if (result.Succeeded)
                {
                    var userid = user.Id;
                    var newUser = new User()
                    {
                        FullName = txtFullname.text,
                        Password = txtPassword.Text,
                        IsActive = true,
                        UserId = userid
                    };
                    unitofwork.UserRepository.Insert(newUser);
                    unitofwork.Save();
                    Dashboard dashboard = new Dashboard();
                    ActiveForm.Hide();
                    dashboard.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unable to Register User");
                }
            }
           
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //pnlRegister.Hide();
            pnlSignIn.Show();
        }

        private void BtnSignUp1_Click(object sender, EventArgs e)
        {
            pnlSignIn.Hide();
            pnlRegister.Show();
        }

        private void BtnSign1_Click(object sender, EventArgs e)
        {
            if (validateSignForm())
            {
                var userStore = new UserStore<IdentityUser>();
                var userManager = new UserManager<IdentityUser>(userStore);
                var user = userManager.Find(txtUsername1.text, txtPassword1.Text);

                if (user != null)
                {

                    //  WindowsIdentity identity = WindowsIdentity.GetCurrent();
                    //  WindowsPrincipal principal = new WindowsPrincipal(identity);
                    Dashboard dashboard = new Dashboard();
                    this.Hide();
                    dashboard.Show();
                    //this.Close();                        
                }
                else
                {
                    MessageBox.Show("You do not have an account, Please contact Admin");
                }

            }

        }

        private void txtUsername1_Enter(object sender, EventArgs e)
        {
            txtUsername1.text = "";
        }

        private void txtPassword1_Click(object sender, EventArgs e)
        {
            txtPassword1.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.text = "";
        }

        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.Text = "";
        }

        private void txtFullname_Click(object sender, EventArgs e)
        {
            txtFullname.text = "";
        }

        bool validateRegisterForm()
        {
            if(txtFullname.text == "")
            {
                MessageBox.Show("Please Enter FullName");
                return false;
            }

            if (txtUsername.text == "")
            {
                MessageBox.Show("Please Enter Username");
                return false;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password");
                return false;
            }
         
            if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please Enter Confirm Passord");
                return false;
            }

            if (txtConfirmPassword.Text == txtPassword.Text)
            {
                MessageBox.Show("Password and confirm Password must match");
                return false;
            }

            return true;
        }

        bool validateSignForm()
        {

            if (txtUsername1.text == "")
            {
                MessageBox.Show("Please Enter Username");
                return false;
            }

            if (txtPassword1.Text == "")
            {
                MessageBox.Show("Please Enter Password");
                return false;
            }


            return true;
        }

    }

}
