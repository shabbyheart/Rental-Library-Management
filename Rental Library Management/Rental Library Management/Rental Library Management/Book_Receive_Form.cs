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
    public partial class Book_Receive_Form : Form
    {
        public Book_Receive_Form()
        {
            InitializeComponent();
        }
        Book_Receive BReceive = new Book_Receive();

        public void clear_All_Text_Field()
        {
            StudentId_BR_TextBox.Clear();
            StudentName_BR_TextBox.Clear();
            Department_BR_TextBox.Clear();
            BookID_BR_TextBox.Clear();
            BookName_BR_TextBox.Clear();
            Author_BR_TextBox.Clear();
            Publisher_BR_TextBox.Clear();
            Issue_Date_textbox.Clear();
            Date_Over_Due_TextBox.Clear();
            Fine_TextBox.Clear();
        }


        private void StudentId_keypress_action(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void StudentId_keyUp_Action(object sender, KeyEventArgs e)
        {
            if (StudentId_BR_TextBox.Text == "")
                return;
            BReceive.StudentId = Convert.ToInt32(StudentId_BR_TextBox.Text);
            Book_Receive_Gateway BRGateway = new Book_Receive_Gateway();
            List<Book_Receive> LBIssue = new List<Book_Receive>();
            LBIssue = BRGateway.student_Status_view(BReceive);
            studentstatus_BR_Grideview.DataSource = LBIssue;

        }

        private void StudenId_leave_Action(object sender, EventArgs e)
        {
            if (StudentId_BR_TextBox.Text == "")
                return;
            BReceive.StudentId = Convert.ToInt32(StudentId_BR_TextBox.Text);
            Book_Receive_Gateway BRGateway = new Book_Receive_Gateway();
            List<Book_Receive> LBIssue = new List<Book_Receive>();
            LBIssue = BRGateway.student_Status_view(BReceive);
            studentstatus_BR_Grideview.DataSource = LBIssue;
        }

        private void Receive_BR_button_Click(object sender, EventArgs e)
        {
            BReceive = new Book_Receive();
            if( StudentId_BR_TextBox.Text == "" && BookID_BR_TextBox.Text == "")
            {
                MessageBox.Show("Fill all Text box");
                return;
            }
            BReceive.StudentId = Convert.ToInt32(StudentId_BR_TextBox.Text);
            BReceive.BookId = Convert.ToInt32(BookID_BR_TextBox.Text);
            Book_Receive_Gateway BRGateaway = new Book_Receive_Gateway();
            BRGateaway.book_Receive(BReceive);

            List<Book_Receive> LBIssue = new List<Book_Receive>();
            LBIssue = BRGateaway.student_Status_view(BReceive);
            studentstatus_BR_Grideview.DataSource = LBIssue;

            BReceive.Fine = Convert.ToDouble(Fine_TextBox.Text);
            BRGateaway.fine_amount_entry(BReceive);

            //List<Book_Receive> newBReceive = BRGateaway.studentID_Textbox_leave_action(BReceive);
        }

        private void studentstatus_BR_Grideview_Cell_content_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.studentstatus_BR_Grideview.Rows[e.RowIndex];

                StudentId_BR_TextBox.Text = row.Cells["StudentId"].Value.ToString();
                StudentName_BR_TextBox.Text = row.Cells["StudentName"].Value.ToString();
                Department_BR_TextBox.Text = row.Cells["Department"].Value.ToString();
                BookID_BR_TextBox.Text = row.Cells["BookId"].Value.ToString();
                BookName_BR_TextBox.Text = row.Cells["BookName"].Value.ToString();
                Author_BR_TextBox.Text = row.Cells["Author"].Value.ToString();
                Publisher_BR_TextBox.Text = row.Cells["Publisher"].Value.ToString();
                Issue_Date_textbox.Text = row.Cells["IssueDate"].Value.ToString();

                BReceive.ReturnDate = ReturnDate_BR_Textbox.Text;
                //long n = long.Parse(BReceive.ReturnDate.ToString("yyyyMMddHHmmss"));
                int DayNum(string date)
                {
                    DateTime start = DateTime.Parse(Issue_Date_textbox.Text);
                    DateTime dt = DateTime.Parse(date);
                    TimeSpan t = dt - start;
                    return (int)t.TotalDays;
                }
                int n = DayNum(BReceive.ReturnDate);
                Date_Over_Due_TextBox.Text = n.ToString();
                //n = 35;
                double fine = 0;
                if( n-15 >= 0)
                {
                    n = n - 15;
                    if (n - 15 >= 0)
                    {
                        fine = 15 * .5;
                        n = n - 15;
                        fine = fine + (n * 1);
                    }
                    else
                        fine = fine + (n * .5); 
                }
                Fine_TextBox.Text = fine.ToString();

            }
        }

        private void Clear_SR_Button_Click(object sender, EventArgs e)
        {
            clear_All_Text_Field();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm admin = new AdminForm();
                admin.Show();
        }
    }
}
