using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Library_Management
{
    public partial class LoginForm : Form
    {
        User user=null;
        User verifiedUser = null;
        Login login = null;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        

        private void LogInButton_Click_1(object sender, EventArgs e)
        {
            user = new User();
            login = new Login();
            user.Password = PasswordTextBox.Text;
            user.Username = UserNameTextBox.Text;

            if(UserTypeComboBox.SelectedIndex == 0)
            {
                verifiedUser = login.UserNameAndPasswordCheck(user);
                if (user.Password == verifiedUser.Password && user.Username == verifiedUser.Username)
                {
                    this.Hide();
                    AdminForm admin = new AdminForm();
                    admin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wornning", "Password is wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                verifiedUser = login.student_Id_And_Password_Check(user);
                if (user.Password == verifiedUser.Password && user.Username == verifiedUser.Username)
                {
                    this.Hide();
                    StudentForm student = new StudentForm();
                    student.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wornning", "Password is wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            
        }

        private void user_Type(object sender, EventArgs e)
        {
        }

        private void SelectedIndexChange(object sender, EventArgs e)
        {

            if (UserTypeComboBox.SelectedIndex == 1)
            {
                UserNameLabel.Text = "Student ID :";
            }
            else
                UserNameLabel.Text = "User Name :";
        }
    }
}
