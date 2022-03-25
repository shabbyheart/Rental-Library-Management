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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }



        Student_Registration SRegistration = new Student_Registration();
        Book_Store BStore = new Book_Store();
        Book_Issue BIssue = new Book_Issue();
        List<Book_Issue> bissue = null;
        Book_Search BSearch = new Book_Search();

        public void enable_Text_Field_Book_Issue_Pannel()
        {
            StudentId_BI_textbox.Enabled = true;
            StudentName_BI_textbox.Enabled = true;
            Department_BI_textbox.Enabled = true;
            BookId_BI_textbox.Enabled = true;
            BookName_BI_textbox.Enabled = true;
            Author_BI_textbox.Enabled = true;
            Publisher_BI_textbox.Enabled = true;
            IssueDate_BI.Enabled = true;

        }
        public bool empty_TextField_check_Book_Issue_Panel()
        {
            if(BookId_BI_textbox.Text == "")
            {
                return true;
            }
            return false;
        }
        public void clear_Book_Issue_Panel_all_Field()
        {
            StudentId_BI_textbox.Clear();
            StudentName_BI_textbox.Clear();
            Department_BI_textbox.Clear();
            BookId_BI_textbox.Clear();
            BookName_BI_textbox.Clear();
            Author_BI_textbox.Clear();
            Publisher_BI_textbox.Clear();
            Search_BI_textbox.Text = "Search by student id for update info";
            
        }
        public void get_inpt_from_book_issue_panel()
        {
            BIssue.StudentId = Convert.ToInt32( StudentId_BI_textbox.Text);
            BIssue.StudentName = StudentName_BI_textbox.Text;
            BIssue.Department1 = Department_BI_textbox.Text;
            BIssue.BookId = Convert.ToInt32(BookId_BI_textbox.Text);
            BIssue.BookName = BookName_BI_textbox.Text;
            BIssue.Author = Author_BI_textbox.Text;
            BIssue.Publisher = Publisher_BI_textbox.Text;
            BIssue.IssueDate = IssueDate_BI.Text;
        }
        public void clear_Book_Store_panel_all_Field()
        {
            BookID_BS_TextBox.Clear();
            BookName_BS_textbox.Clear();
            Author_BS_textbox.Clear();
            Publisher_BS_textBox.Clear();
            Edition_BS_textbox.Clear();
            Year_BS_textbox.Clear();
            Source_BS_textbook.Clear();
            Quantity_BS_TextBox.Clear();
            Search_BS_TextBox.Text = "search by Book id for update info";

        }
        public void clear_Student_Registration_panel_all_Field()
        {
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            StudentIdTextBox.Clear();
            Department_S_TextBox.Clear();
            EmailTextBox.Clear();
            PhoneTextBox.Clear();
            PasswordTextBox.Clear();
            ConfirmTextBox.Clear();
            Search_SR_Panel_textBox.Text = "search student id for update info";
        }
        public bool all_TextField_isEmpty_Check_Book_Store_Panel()
        {
            if(BookNumber_BS_TextBox.Text == "" || Year_BS_textbox.Text == "" || BookName_BS_textbox.Text == "" || Author_BS_textbox.Text == "" || Publisher_BS_textBox.Text== "" || Edition_BS_textbox.Text == "" || Source_BS_textbook.Text == ""|| EntryDate_BS_datetimepicker.Text == "" || Quantity_BS_TextBox.Text =="")
            {
                return true;
                
            }
            return false;
        }
        public void get_Input_From_Book_Store_Panel()
        {
            BStore.BookNumber = Convert.ToInt32(BookNumber_BS_TextBox.Text);
            BStore.BookId = Convert.ToInt32(BookID_BS_TextBox.Text);
            BStore.BookName = BookName_BS_textbox.Text;
            BStore.Author = Author_BS_textbox.Text;
            BStore.Pubisher = Publisher_BS_textBox.Text;
            BStore.Edition = Edition_BS_textbox.Text;
            BStore.Year = Convert.ToInt32(Year_BS_textbox.Text);
            BStore.Source = Source_BS_textbook.Text;
            BStore.EntryDate = EntryDate_BS_datetimepicker.Text;
            BStore.Quantity1 = Convert.ToInt32(Quantity_BS_TextBox.Text);
        }
        public bool isEmpty_Student_registraion_panel_textBox()
        {
            if (StudentIdTextBox.Text == "" || FirstNameTextBox.Text == "" || LastNameTextBox.Text == "" || PasswordTextBox.Text == "")
                return true;
            if (Department_S_TextBox.Text == "" || EmailTextBox.Text == "" || PhoneTextBox.Text == "" || ConfirmTextBox.Text == "")
                return true;
            return false;
        }
        public void get_Input_form_Student_registraion_panel( )
        {
            
            if(StudentIdTextBox.Text != "")
            {
                SRegistration.Student_ID = Convert.ToInt32(StudentIdTextBox.Text);
                SRegistration.First_Name = FirstNameTextBox.Text;
                SRegistration.Last_Name = LastNameTextBox.Text;
                if (MaleRadioButton.Checked)
                {
                    //SRegistration.s = MaleRadioButton.Text;
                    SRegistration.Sex = MaleRadioButton.Text;
                }
                else
                {
                    SRegistration.Sex = FemaleRadioButton.Text;
                }

                SRegistration.Department = Department_S_TextBox.Text;
                SRegistration.Email = EmailTextBox.Text;
                SRegistration.Phone_Number = PhoneTextBox.Text;
                SRegistration.Password = PasswordTextBox.Text;
                SRegistration.Confirm_Password = ConfirmTextBox.Text;
            }
               

            
        }

        public void HidePanel()
        {
            BookIssuePanel.Visible = false;
            BookStorePanel.Visible = false;
            StudentRegistrationPanel.Visible = false;
           FineReceive_Panel.Visible = false;
            BookSearchPanel.Visible = false;
            Due_Book_Status_Panel.Visible = false;
            Student_Status_Panel.Visible = false;
            WelcomePanel.Visible = false;
        }































        private void AdminForm_Load(object sender, EventArgs e)
        {
            //HidePanel();
            StudentRegistrationPanel.Visible = true;
            StudentRegistrationPanel.Width = 1119;
            clear_Student_Registration_panel_all_Field();
        }

        private void BookStatusButton_Click(object sender, EventArgs e)
        {
            HidePanel();
            Due_Book_Status_Panel.Visible = true;
            Due_Book_Status_Panel.Width = 1119;

            Book_Issue_Gateaway BIGateaway = new Book_Issue_Gateaway();
            List<Book_Issue> LBIssue = new List<Book_Issue>();
            LBIssue = BIGateaway.all_book_Status();
            DBS_dataGridView.DataSource = LBIssue;
            Search_DBS_textbox.Clear();
        }
        private void BookStoreButton_Click(object sender, EventArgs e)
        {
            HidePanel();
            BookStorePanel.Visible = true;
            BookStorePanel.Width = 1119;

            Book_Store_Gateaway BSGateaway = new Book_Store_Gateaway();
            Book_Store BStore = BSGateaway.row_Count();
            BookNumber_BS_TextBox.Text = BStore.BookNumber.ToString();
            clear_Book_Store_panel_all_Field();

        }
        
        private void StudentRegistrationButon_Click(object sender, EventArgs e)
        {
            HidePanel();
            StudentRegistrationPanel.Visible = true;
            StudentRegistrationPanel.Width = 1119;
            clear_Student_Registration_panel_all_Field();
            
        }

        private void BookIssueButton_Click_1(object sender, EventArgs e)
        {
            HidePanel();
            BookIssuePanel.Width = 1119;
            BookIssuePanel.Visible = true;
            clear_Book_Issue_Panel_all_Field();
            //StudentStatus_BI_DataGrideview.Rows.Clear();
            //StudentStatus_BI_DataGrideview.Refresh();
        }
        private void StudentStatusButton_Click(object sender, EventArgs e)
        {
            HidePanel();
            Student_Status_Panel.Visible = true;
            Student_Status_Panel.Width = 1119;

            Book_Issue_Gateaway BIGateaway = new Book_Issue_Gateaway();
            List<Book_Issue> LBIssue = new List<Book_Issue>();
            LBIssue = BIGateaway.all_student_Status();
            Search_SS_dataGridView.DataSource = LBIssue;

        }

        private void BookReceiveButton_Click(object sender, EventArgs e)
        {
            Book_Receive_Form BReceive = new Book_Receive_Form();
            this.Hide();
            BReceive.Show();
        }

        private void BookSearchButton_Click(object sender, EventArgs e)
        {
            HidePanel();
            BookSearchPanel.Visible = true;
            BookSearchPanel.Height = 712;
            BookSearchPanel.Width = 1119;

            
            Book_Search_Gateway BSGateway = new Book_Search_Gateway();
            List<Book_Search> LBIssue = new List<Book_Search>();
            LBIssue = BSGateway.show_all_Books();
            Search_GrideView.DataSource = LBIssue;
        }
        private void FineReceiveButton_Click(object sender, EventArgs e)
        {
            HidePanel();
            FineReceive_Panel.Visible = true;
            //BookSearchPanel.Height = 712;
            FineReceive_Panel.Width = 1119;

            
            Fine_Receive_Gateway FRGateway = new Fine_Receive_Gateway();
            List<Fine_Receive> LFReceive = new List<Fine_Receive>();
            LFReceive = FRGateway.all_Student_Fine_Amount_view();
            fine_dataGridView.DataSource = LFReceive;
        }












        private void Search_SR_Panel_textBox_keypress_Action(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void student_Resigtration_studentId_textbox_keypress_action(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Student_Registration_Panel_Search_Button_Click(object sender, EventArgs e)
        {
            if( Search_SR_Panel_textBox.Text == "search student id for update info" || Search_SR_Panel_textBox.Text == "")
            {
                MessageBox.Show("Filled Text Field first");
                return;
            }
            SRegistration.Student_ID = Convert.ToInt32(Search_SR_Panel_textBox.Text);
            Student_Registration_Gateaway SRGateaway = new Student_Registration_Gateaway();
            Student_Registration newSRgistration = SRGateaway.search_into_Student_Registreation_Table(SRegistration);

            if (newSRgistration.Student_ID != -1)
            {
                FirstNameTextBox.Text = newSRgistration.First_Name;
                LastNameTextBox.Text = newSRgistration.Last_Name;
                if (newSRgistration.Sex == "Male")
                    MaleRadioButton.Select();
                else
                    FemaleRadioButton.Select();
                StudentIdTextBox.Text = newSRgistration.Student_ID.ToString();
                Department_S_TextBox.Text = newSRgistration.Department;
                EmailTextBox.Text = newSRgistration.Email;
                PhoneTextBox.Text = newSRgistration.Phone_Number;
                PasswordTextBox.Text = newSRgistration.Password;
                Search_SR_Panel_textBox.Text = "search student id for update info";
            }
            else
            {
                Search_SR_Panel_textBox.Text = "search student id for update info";
                clear_Student_Registration_panel_all_Field();
            }


        }
        private void student_register_Search_textbox_click(object sender, EventArgs e)
        {
            Search_SR_Panel_textBox.Clear();
        }
        private void Student_Resigtration_SubmitButton_Click(object sender, EventArgs e)
        {
            //Student_Registration SRegistration = new Student_Registration();
            get_Input_form_Student_registraion_panel();
            
            Student_Registration_Gateaway registraryGateaway = new Student_Registration_Gateaway();
            if( isEmpty_Student_registraion_panel_textBox())
            {
                MessageBox.Show("Filled all Field First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (SRegistration.Password == SRegistration.Confirm_Password && SRegistration.Password != "" && SRegistration.Confirm_Password != "" )
            {
                registraryGateaway.Insert_Into_Student_Registration_Table(SRegistration);
                clear_Student_Registration_panel_all_Field();
            }
            else
            {
                MessageBox.Show("Password is not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Student_Resgistration_Update_Click(object sender, EventArgs e)
        {
            if (isEmpty_Student_registraion_panel_textBox())
            {
                MessageBox.Show("Filled all Field First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            get_Input_form_Student_registraion_panel();
            Student_Registration_Gateaway registraryGateaway = new Student_Registration_Gateaway();
            if (SRegistration.Password == SRegistration.Confirm_Password)
            {
                registraryGateaway.Update_Into_Student_Registration_Table(SRegistration);
                clear_Student_Registration_panel_all_Field();
            }
            else
            {
                MessageBox.Show("Password is not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void StudentDelete_Click(object sender, EventArgs e)
        {
            if (isEmpty_Student_registraion_panel_textBox())
            {
                MessageBox.Show("Filled all Field First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            get_Input_form_Student_registraion_panel();
            Student_Registration_Gateaway registraryGateaway = new Student_Registration_Gateaway();

            registraryGateaway.delete_Into_Student_Registration_Table(SRegistration);
            clear_Student_Registration_panel_all_Field();
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            clear_Student_Registration_panel_all_Field();
        }














        /// here start Book Store Panel work;
        private void Book_Store_Delete_button_Click(object sender, EventArgs e)
        {
            if (all_TextField_isEmpty_Check_Book_Store_Panel())
            {
                MessageBox.Show("Filled all Field First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            get_Input_From_Book_Store_Panel();
            Book_Store_Gateaway BSGateaway =new Book_Store_Gateaway();
            BSGateaway.delete(BStore);
            clear_Book_Store_panel_all_Field();

            
            Book_Store BStoree = BSGateaway.row_Count();
            BookNumber_BS_TextBox.Text = BStoree.BookNumber.ToString();
        }
        private void Book_Store_Search_Texbox_click(object sender, EventArgs e)
        {
            Search_BS_TextBox.Clear();

        }
        private void Search_BS_Button_Click(object sender, EventArgs e)
        {
            if(Search_BS_TextBox.Text == "search by Book id for update info" || Search_BS_TextBox.Text == "")
            {
                
                MessageBox.Show("Filled text Field  First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BStore.BookId = Convert.ToInt32(Search_BS_TextBox.Text);
            Book_Store_Gateaway SRGateaway = new Book_Store_Gateaway();
            Book_Store newBStore = SRGateaway.search_into_Book_Store_Table(BStore);
            
            if (newBStore.BookId != -1)
            {
                BookID_BS_TextBox.Text = newBStore.BookId.ToString();
                BookName_BS_textbox.Text = newBStore.BookName;
                Author_BS_textbox.Text = newBStore.Author;
                Publisher_BS_textBox.Text = newBStore.Pubisher;
                Edition_BS_textbox.Text = newBStore.Edition;
                Year_BS_textbox.Text = newBStore.Year.ToString();
                Source_BS_textbook.Text = newBStore.Source;
                EntryDate_BS_datetimepicker.Text = newBStore.EntryDate;
                Quantity_BS_TextBox.Text = newBStore.Quantity1.ToString();
            }
            else
            {
                Search_BS_Button.Text = "search student id for update info";
                clear_Book_Store_panel_all_Field();
            }
        }
        private void book_Store_Submit_button_Click(object sender, EventArgs e)
        {
            if(all_TextField_isEmpty_Check_Book_Store_Panel() )
            {
                MessageBox.Show("Some TextBox isEmpty");
                return;
            }
            get_Input_From_Book_Store_Panel();
            Book_Store_Gateaway BSGateaway = new Book_Store_Gateaway();
            BSGateaway.insert_Into_Book_Store_Table(BStore);
            BSGateaway.insert_Into_Author_Table(BStore);
            BSGateaway.insert_Into_publisher_Table(BStore);

            Book_Store BStoree = BSGateaway.row_Count();
            BookNumber_BS_TextBox.Text = BStoree.BookNumber.ToString();
            clear_Book_Store_panel_all_Field();
        }
        private void Book_Store_Update_Button_Click(object sender, EventArgs e)
        {
            if(all_TextField_isEmpty_Check_Book_Store_Panel())
            {
                MessageBox.Show("Filled all Field First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            get_Input_From_Book_Store_Panel();
            Book_Store_Gateaway BSGateaway = new Book_Store_Gateaway();
            BSGateaway.update_Book_Store_Table(BStore);
            clear_Book_Store_panel_all_Field();
        }
        private void Book_Store_Clear_Button_Click(object sender, EventArgs e)
        {
            clear_Book_Store_panel_all_Field();
        }
        private void Book_Store_Panel_Quantity_textBox_keyprss_Action(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Book_Store_BookId_textBox_keypress_action(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Book_Store_Panel_Year_TextBox_keypress_Action(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// End Book Store Panel work;
























        /// Book Issue Pannel work start
        
        private void Book_Issue_Panel_Submit_Button_Click(object sender, EventArgs e)
        {
            
            if (StudentId_BI_textbox.Text == "" && BookId_BI_textbox.Text == "")
                return;
            get_inpt_from_book_issue_panel();
            Book_Issue_Gateaway BIGateaway = new Book_Issue_Gateaway();

            int quantity;
            List<Book_Issue> LBIssue = new List<Book_Issue>();
            LBIssue = BIGateaway.Book_Status_view(BIssue);
            quantity = BIGateaway.get_book_Quantity_form_Book_Store_Table(BIssue);
            if (LBIssue.Count() >= quantity && quantity != -1)
            {
                MessageBox.Show("This book all quantity already rent");
                return;
            }
            LBIssue = BIGateaway.student_Status_view(BIssue);
            if (LBIssue.Count() >= 3)
            {
                MessageBox.Show("This Student already taken 3 Books");
                return;
            }
            int count = BIGateaway.check_Student_book_already_rent(BIssue);
            if (count > 0)
            {
                MessageBox.Show("This student already taken this Book");
                return;
            }
            get_inpt_from_book_issue_panel();
            
            BIGateaway.insert_Into_Book_Issue_Table(BIssue);
            clear_Book_Issue_Panel_all_Field();

            //List<Book_Issue> LBIssue = new List<Book_Issue>();
            LBIssue = BIGateaway.student_Status_view(BIssue);
            StudentStatus_BI_DataGrideview.DataSource = LBIssue;
            LBIssue = BIGateaway.Book_Status_view(BIssue);
            BookStatus_BI_dataGridView.DataSource = LBIssue;
            //BIGateaway.insert_Into_Due_Book_Status_Table(BIssue);

            //BIGateaway.insert_Into_Student_Status_Table(BIssue);

        }
        private void SarchTextBox_Book_Issue_click(object sender, EventArgs e)
        {
            Search_BI_textbox.Text = "";
        }
        private void Book_Issue_Panel_Search_TextBox_keypres_Action(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Book_Issue_Panel_Search_button_Click(object sender, EventArgs e)
        {
            //enable_Text_Field_Book_Issue_Pannel();
            if (Search_BI_textbox.Text == "" || Search_BI_textbox.Text == "Search by student id for update info")
            {
                
                MessageBox.Show("Filled Text Field First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
              
            BIssue.StudentId = Convert.ToInt32(Search_BI_textbox.Text);
            
            Book_Issue_Gateaway BIGateaway = new Book_Issue_Gateaway();
            Book_Issue newBIssue = BIGateaway.Search_Into_Book_Issue_Table(BIssue);
            if (newBIssue.StudentId != -1)
            {
                StudentId_BI_textbox.Text = newBIssue.StudentId.ToString();
                StudentName_BI_textbox.Text = newBIssue.StudentName;
                
                Department_BI_textbox.Text = newBIssue.Department1;
                BookId_BI_textbox.Text = newBIssue.BookId.ToString();
                BookName_BI_textbox.Text = newBIssue.BookName;
                Author_BI_textbox.Text = newBIssue.Author;
                Publisher_BI_textbox.Text = newBIssue.Publisher;
                IssueDate_BI.Text = newBIssue.IssueDate;
                Search_BI_textbox.Text = "search by student id for update info";
            }
            else
            {
                Search_BI_textbox.Text = "search by student id for update info";
                clear_Book_Issue_Panel_all_Field();
            }

            List<Book_Issue> LBIssue = new List<Book_Issue>();
            LBIssue = BIGateaway.student_Status_view(BIssue);
            StudentStatus_BI_DataGrideview.DataSource = LBIssue;

            //List<Book_Issue> LBIssue = new List<Book_Issue>();
            BIssue.BookId = newBIssue.BookId;
            LBIssue = BIGateaway.Book_Status_view(BIssue);
            BookStatus_BI_dataGridView.DataSource = LBIssue;

        }
        private void Book_Issue_Panel_Update_Button_Click(object sender, EventArgs e)
        {
            if (StudentId_BI_textbox.Text == "" && BookId_BI_textbox.Text == "")
                return;
            get_inpt_from_book_issue_panel();
            Book_Issue_Gateaway BIGateaway = new Book_Issue_Gateaway();
            BIGateaway.update_into_book_issue_Table(BIssue);
            clear_Book_Issue_Panel_all_Field();

            List<Book_Issue> LBIssue = new List<Book_Issue>();
            LBIssue = BIGateaway.student_Status_view(BIssue);
            StudentStatus_BI_DataGrideview.DataSource = LBIssue;
            LBIssue = BIGateaway.Book_Status_view(BIssue);
            BookStatus_BI_dataGridView.DataSource = LBIssue;
        }
        private void Book_Issue_Panel_Clear_Button_Click(object sender, EventArgs e)
        {
            clear_Book_Issue_Panel_all_Field();
        }

        private void Book_Issue_Panel_Book_ID_textBox_leave_action(object sender, EventArgs e)
        {
            if (BookId_BI_textbox.Text == "")
            {
                return;
            }
            BIssue.BookId = Convert.ToInt32(BookId_BI_textbox.Text);
            BIssue.BookName = BookName_BI_textbox.Text;
            BIssue.Author = Author_BI_textbox.Text;
            BIssue.Publisher = Publisher_BI_textbox.Text;
            BIssue.IssueDate = IssueDate_BI.Text;

            Book_Issue_Gateaway BIGateaway = new Book_Issue_Gateaway();
            Book_Issue newBIssue = BIGateaway.bookId_textBox_leave_Action(BIssue);

            if (newBIssue.BookId == -1)
                MessageBox.Show("Book is not Found in our Library");

            BookName_BI_textbox.Text = newBIssue.BookName;
            Author_BI_textbox.Text = newBIssue.Author;
            Publisher_BI_textbox.Text = newBIssue.Publisher;


            List<Book_Issue> LBIssue = new List<Book_Issue>();
            LBIssue = BIGateaway.Book_Status_view(BIssue);
            BookStatus_BI_dataGridView.DataSource = LBIssue;

        }
        private void BookId_BI_keypress_action(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
        private void BookId_BI_keyUp_event(object sender, KeyEventArgs e)
        {
            if (BookId_BI_textbox.Text == "")
            {
                return;
            }
            BIssue.BookId = Convert.ToInt32(BookId_BI_textbox.Text);
            BIssue.BookName = BookName_BI_textbox.Text;
            BIssue.Author = Author_BI_textbox.Text;
            BIssue.Publisher = Publisher_BI_textbox.Text;
            BIssue.IssueDate = IssueDate_BI.Text;

            Book_Issue_Gateaway BIGateaway = new Book_Issue_Gateaway();
            Book_Issue newBIssue = BIGateaway.bookId_textBox_leave_Action(BIssue);
            

            BookName_BI_textbox.Text = newBIssue.BookName;
            Author_BI_textbox.Text = newBIssue.Author;
            Publisher_BI_textbox.Text = newBIssue.Publisher;


            List<Book_Issue> LBIssue = new List<Book_Issue>();
            LBIssue = BIGateaway.Book_Status_view(BIssue);
            BookStatus_BI_dataGridView.DataSource = LBIssue;

            int bookQuantity = BIGateaway.get_book_Quantity_form_Book_Store_Table(BIssue);
            if (LBIssue.Count() >= bookQuantity && bookQuantity != -1)
            {
                MessageBox.Show("This book all quantity alredy rent");
                ////BookName_BI_textbox.Clear();
                //Author_BI_textbox.Clear();

            }
        }



        private void StudentId_BI_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                
            }
        }
        private void StudentId_BI_textbox_Book_issue_panel_keyUP_Acton(object sender, KeyEventArgs e)
        {
            if ( StudentId_BI_textbox.Text == "")
                return;
            BIssue.StudentId = Convert.ToInt32(StudentId_BI_textbox.Text);
            Book_Issue_Gateaway BIGateaway = new Book_Issue_Gateaway();
            List<Book_Issue> LBIssue = new List<Book_Issue>();
            LBIssue = BIGateaway.student_Status_view(BIssue);
            StudentStatus_BI_DataGrideview.DataSource = LBIssue;
            if(LBIssue.Count() == 3)
            {
                MessageBox.Show("This student already rent 3 books");
            }


            BIssue.StudentId = Convert.ToInt32(StudentId_BI_textbox.Text);
            BIssue.StudentName = StudentName_BI_textbox.Text;
            BIssue.Department1 = Department_BI_textbox.Text;
            //get_inpt_from_book_issue_panel();
            //Book_Issue_Gateaway BIGateaway = new Book_Issue_Gateaway();
            Book_Issue newBIssue = BIGateaway.studentID_Textbox_leave_action(BIssue);
            StudentName_BI_textbox.Text = newBIssue.StudentName;
            Department_BI_textbox.Text = newBIssue.Department1;
        }
        private void StudentId_Textbox_Book_issue_panel_leave_Action(object sender, EventArgs e)
        {
            if (StudentId_BI_textbox.Text == "")
            {
                return;
            }
            BIssue.StudentId = Convert.ToInt32(StudentId_BI_textbox.Text);
            BIssue.StudentName = StudentName_BI_textbox.Text;
            BIssue.Department1 = Department_BI_textbox.Text;
            //get_inpt_from_book_issue_panel();
            Book_Issue_Gateaway BIGateaway = new Book_Issue_Gateaway();
            Book_Issue newBIssue = BIGateaway.studentID_Textbox_leave_action(BIssue);
            if(newBIssue.StudentId == -1)
            {
                MessageBox.Show("Student is not registered");
            }
            StudentName_BI_textbox.Text = newBIssue.StudentName;
            Department_BI_textbox.Text = newBIssue.Department1;

            List<Book_Issue> LBIssue = new List<Book_Issue>();
            LBIssue = BIGateaway.student_Status_view(BIssue);
            StudentStatus_BI_DataGrideview.DataSource = LBIssue;
        }
































































        private void StudentRegistrationPanel_Paint(object sender, PaintEventArgs e){}
        private void BookReceivePanel_Paint(object sender, PaintEventArgs e) { }
        private void BookStorePanel_Paint(object sender, PaintEventArgs e) { }

        private void dateTimePicker_SI_ValueChanged(object sender, EventArgs e)
        {
        }
        private void BookIssue_sutdent_id_text_Fie(object sender, EventArgs e)
        {
        }
        private void f(object sender, EventArgs e)
        {
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }
        
        private void Search_BS_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void StudentName_BR_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BookIssuePanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

























        
        private void SearchByPublisher_S_TextBox_keyUp_Action(object sender, KeyEventArgs e)
        {
            BSearch.Publisher = SearchByPublisher_S_TextBox.Text;
            Book_Search_Gateway BSGateway = new Book_Search_Gateway();
            List<Book_Search> LBIssue = new List<Book_Search>();
            LBIssue = BSGateway.search_by_Book_publisher(BSearch);
            Search_GrideView.DataSource = LBIssue;
        }

        private void SearchByAuthor_S_TextBox_keUp_Action(object sender, KeyEventArgs e)
        {
            BSearch.Author = SearchByAuthor_S_TextBox.Text;
            Book_Search_Gateway BSGateway = new Book_Search_Gateway();
            List<Book_Search> LBIssue = new List<Book_Search>();
            LBIssue = BSGateway.search_by_Book_Author(BSearch);
            Search_GrideView.DataSource = LBIssue;
        }

        private void SearchByName_S_TextBox_key_up_Action(object sender, KeyEventArgs e)
        {
            BSearch.BookName = SearchByName_S_TextBox.Text;
            Book_Search_Gateway BSGateway = new Book_Search_Gateway();
            List<Book_Search> LBIssue = new List<Book_Search>();
            LBIssue = BSGateway.search_by_Book_name(BSearch);
            Search_GrideView.DataSource = LBIssue;
        }

        private void Search_SS_textBox_key_press_Action(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Search_SS_textBox_key_Up_Action(object sender, KeyEventArgs e)
        {
            if (Search_SS_textBox.Text == "")
                return;
            BIssue.StudentId = Convert.ToInt32(Search_SS_textBox.Text);
            Book_Issue_Gateaway BIGateaway = new Book_Issue_Gateaway();
            List<Book_Issue> LBIssue = new List<Book_Issue>();
            LBIssue = BIGateaway.student_Status_view(BIssue);
            Search_SS_dataGridView.DataSource = LBIssue;
        }

        private void AdminForm_Load_1(object sender, EventArgs e)
        {}

        private void Search_DBS_textbox_keyPress_Action(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Search_DBS_textbox_keyUp_Action(object sender, KeyEventArgs e)
        {
            if (Search_DBS_textbox.Text == "")
                return;
            BIssue.BookId = Convert.ToInt32(Search_DBS_textbox.Text);
            Book_Issue_Gateaway BIGateaway = new Book_Issue_Gateaway();
            List<Book_Issue> LBIssue = new List<Book_Issue>();
            LBIssue = BIGateaway.Book_Status_view(BIssue);
            DBS_dataGridView.DataSource = LBIssue;
        }













        private void StudentId_FR_Textbox_keypress_Action(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
        
        Fine_Receive FReceive = new Fine_Receive();
        private void StudentId_FR_textBox_keyUp_Action(object sender, KeyEventArgs e)
        {
            if (StudentId_FR_TextBox.Text == "")
                return;
            FReceive.StudentId = Convert.ToInt32(StudentId_FR_TextBox.Text);
            Fine_Receive_Gateway FRGateway = new Fine_Receive_Gateway();
            List<Fine_Receive> LFReceive = new List<Fine_Receive>();
            LFReceive = FRGateway.all_Fine_Amount_view(FReceive);
            fine_dataGridView.DataSource = LFReceive;
        }

        private void Amount_FR_Textbox_keypress_event(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void ReceiveButton_FR_Click(object sender, EventArgs e)
        {
            if (StudentId_FR_TextBox.Text == "")
                return;
            FReceive.StudentId = Convert.ToInt32( StudentId_FR_TextBox.Text);
            FReceive.Amount = Convert.ToDouble(Amount_FR_Textbox.Text);
            Fine_Receive_Gateway FRGateway = new Fine_Receive_Gateway();
            FRGateway.fine_Recive(FReceive);


            List<Fine_Receive> LFReceive = new List<Fine_Receive>();
            LFReceive = FRGateway.all_Fine_Amount_view(FReceive);
            fine_dataGridView.DataSource = LFReceive;
        }

        private void Student_Status_BI_DataGridView_CellContextClick_Action(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.StudentStatus_BI_DataGrideview.Rows[e.RowIndex];

                StudentId_BI_textbox.Text = row.Cells["StudentId"].Value.ToString();
                StudentName_BI_textbox.Text = row.Cells["StudentName"].Value.ToString();
                Department_BI_textbox.Text = row.Cells["Department1"].Value.ToString();
                BookId_BI_textbox.Text = row.Cells["BookId"].Value.ToString();
                BookName_BI_textbox.Text = row.Cells["BookName"].Value.ToString();
                Author_BI_textbox.Text = row.Cells["Author"].Value.ToString();
                Publisher_BI_textbox.Text = row.Cells["Publisher"].Value.ToString();
                IssueDate_BI.Text = row.Cells["IssueDate"].Value.ToString();

                //BReceive.ReturnDate = ReturnDate_BR_Textbox.Text;


            }
        }
    }
}
