namespace Rental_Library_Management
{
    partial class Book_Receive_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReturnDate_BR_Textbox = new System.Windows.Forms.DateTimePicker();
            this.Clear_SR_Button = new System.Windows.Forms.Button();
            this.Receive_BR_button = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Fine_TextBox = new System.Windows.Forms.TextBox();
            this.Date_Over_Due_TextBox = new System.Windows.Forms.TextBox();
            this.Issue_Date_textbox = new System.Windows.Forms.TextBox();
            this.Publisher_BR_TextBox = new System.Windows.Forms.TextBox();
            this.Author_BR_TextBox = new System.Windows.Forms.TextBox();
            this.BookName_BR_TextBox = new System.Windows.Forms.TextBox();
            this.BookID_BR_TextBox = new System.Windows.Forms.TextBox();
            this.Department_BR_TextBox = new System.Windows.Forms.TextBox();
            this.StudentId_BR_TextBox = new System.Windows.Forms.TextBox();
            this.StudentName_BR_TextBox = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.BookReciveLabel = new System.Windows.Forms.Label();
            this.studentstatus_BR_Grideview = new System.Windows.Forms.DataGridView();
            this.Back_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentstatus_BR_Grideview)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnDate_BR_Textbox
            // 
            this.ReturnDate_BR_Textbox.CustomFormat = "yyyy-MM-dd";
            this.ReturnDate_BR_Textbox.Enabled = false;
            this.ReturnDate_BR_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDate_BR_Textbox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReturnDate_BR_Textbox.Location = new System.Drawing.Point(255, 492);
            this.ReturnDate_BR_Textbox.Name = "ReturnDate_BR_Textbox";
            this.ReturnDate_BR_Textbox.Size = new System.Drawing.Size(270, 31);
            this.ReturnDate_BR_Textbox.TabIndex = 62;
            // 
            // Clear_SR_Button
            // 
            this.Clear_SR_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_SR_Button.Location = new System.Drawing.Point(300, 644);
            this.Clear_SR_Button.Name = "Clear_SR_Button";
            this.Clear_SR_Button.Size = new System.Drawing.Size(142, 46);
            this.Clear_SR_Button.TabIndex = 61;
            this.Clear_SR_Button.Text = "Clear";
            this.Clear_SR_Button.UseVisualStyleBackColor = true;
            this.Clear_SR_Button.Click += new System.EventHandler(this.Clear_SR_Button_Click);
            // 
            // Receive_BR_button
            // 
            this.Receive_BR_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receive_BR_button.Location = new System.Drawing.Point(121, 644);
            this.Receive_BR_button.Name = "Receive_BR_button";
            this.Receive_BR_button.Size = new System.Drawing.Size(142, 46);
            this.Receive_BR_button.TabIndex = 60;
            this.Receive_BR_button.Text = "Receive";
            this.Receive_BR_button.UseVisualStyleBackColor = true;
            this.Receive_BR_button.Click += new System.EventHandler(this.Receive_BR_button_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(137, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 25);
            this.label15.TabIndex = 59;
            this.label15.Text = "Author :";
            // 
            // Fine_TextBox
            // 
            this.Fine_TextBox.Enabled = false;
            this.Fine_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fine_TextBox.Location = new System.Drawing.Point(255, 577);
            this.Fine_TextBox.Name = "Fine_TextBox";
            this.Fine_TextBox.Size = new System.Drawing.Size(272, 31);
            this.Fine_TextBox.TabIndex = 58;
            // 
            // Date_Over_Due_TextBox
            // 
            this.Date_Over_Due_TextBox.Enabled = false;
            this.Date_Over_Due_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Over_Due_TextBox.Location = new System.Drawing.Point(255, 533);
            this.Date_Over_Due_TextBox.Name = "Date_Over_Due_TextBox";
            this.Date_Over_Due_TextBox.Size = new System.Drawing.Size(272, 31);
            this.Date_Over_Due_TextBox.TabIndex = 57;
            // 
            // Issue_Date_textbox
            // 
            this.Issue_Date_textbox.Enabled = false;
            this.Issue_Date_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issue_Date_textbox.Location = new System.Drawing.Point(255, 453);
            this.Issue_Date_textbox.Name = "Issue_Date_textbox";
            this.Issue_Date_textbox.Size = new System.Drawing.Size(272, 31);
            this.Issue_Date_textbox.TabIndex = 56;
            // 
            // Publisher_BR_TextBox
            // 
            this.Publisher_BR_TextBox.Enabled = false;
            this.Publisher_BR_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher_BR_TextBox.Location = new System.Drawing.Point(255, 412);
            this.Publisher_BR_TextBox.Name = "Publisher_BR_TextBox";
            this.Publisher_BR_TextBox.Size = new System.Drawing.Size(272, 31);
            this.Publisher_BR_TextBox.TabIndex = 55;
            // 
            // Author_BR_TextBox
            // 
            this.Author_BR_TextBox.Enabled = false;
            this.Author_BR_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_BR_TextBox.Location = new System.Drawing.Point(255, 373);
            this.Author_BR_TextBox.Name = "Author_BR_TextBox";
            this.Author_BR_TextBox.Size = new System.Drawing.Size(272, 31);
            this.Author_BR_TextBox.TabIndex = 54;
            // 
            // BookName_BR_TextBox
            // 
            this.BookName_BR_TextBox.Enabled = false;
            this.BookName_BR_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookName_BR_TextBox.Location = new System.Drawing.Point(255, 334);
            this.BookName_BR_TextBox.Name = "BookName_BR_TextBox";
            this.BookName_BR_TextBox.Size = new System.Drawing.Size(272, 31);
            this.BookName_BR_TextBox.TabIndex = 53;
            // 
            // BookID_BR_TextBox
            // 
            this.BookID_BR_TextBox.Enabled = false;
            this.BookID_BR_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookID_BR_TextBox.Location = new System.Drawing.Point(255, 294);
            this.BookID_BR_TextBox.Name = "BookID_BR_TextBox";
            this.BookID_BR_TextBox.Size = new System.Drawing.Size(272, 31);
            this.BookID_BR_TextBox.TabIndex = 52;
            // 
            // Department_BR_TextBox
            // 
            this.Department_BR_TextBox.Enabled = false;
            this.Department_BR_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_BR_TextBox.Location = new System.Drawing.Point(255, 212);
            this.Department_BR_TextBox.Name = "Department_BR_TextBox";
            this.Department_BR_TextBox.Size = new System.Drawing.Size(272, 31);
            this.Department_BR_TextBox.TabIndex = 51;
            // 
            // StudentId_BR_TextBox
            // 
            this.StudentId_BR_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentId_BR_TextBox.Location = new System.Drawing.Point(255, 122);
            this.StudentId_BR_TextBox.Name = "StudentId_BR_TextBox";
            this.StudentId_BR_TextBox.Size = new System.Drawing.Size(272, 31);
            this.StudentId_BR_TextBox.TabIndex = 50;
            this.StudentId_BR_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentId_keypress_action);
            this.StudentId_BR_TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StudentId_keyUp_Action);
            this.StudentId_BR_TextBox.Leave += new System.EventHandler(this.StudenId_leave_Action);
            // 
            // StudentName_BR_TextBox
            // 
            this.StudentName_BR_TextBox.Enabled = false;
            this.StudentName_BR_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName_BR_TextBox.Location = new System.Drawing.Point(255, 164);
            this.StudentName_BR_TextBox.Name = "StudentName_BR_TextBox";
            this.StudentName_BR_TextBox.Size = new System.Drawing.Size(272, 31);
            this.StudentName_BR_TextBox.TabIndex = 49;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(58, 170);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(174, 25);
            this.label42.TabIndex = 48;
            this.label42.Text = "Student Name :";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(96, 125);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(136, 25);
            this.label41.TabIndex = 47;
            this.label41.Text = "Student ID :";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(87, 215);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(147, 25);
            this.label40.TabIndex = 46;
            this.label40.Text = "Department :";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(227, 256);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(145, 25);
            this.label39.TabIndex = 45;
            this.label39.Text = "Book Details";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(124, 297);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(108, 25);
            this.label38.TabIndex = 44;
            this.label38.Text = "Book ID :";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(86, 337);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(146, 25);
            this.label37.TabIndex = 43;
            this.label37.Text = "Book Name :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(107, 415);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(125, 25);
            this.label35.TabIndex = 42;
            this.label35.Text = "Publisher :";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(87, 455);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(147, 25);
            this.label34.TabIndex = 41;
            this.label34.Text = "Taken Date :";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(55, 491);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(179, 25);
            this.label33.TabIndex = 40;
            this.label33.Text = "Date to Return :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(162, 577);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(72, 25);
            this.label32.TabIndex = 39;
            this.label32.Text = "Fine :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(51, 536);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(181, 25);
            this.label31.TabIndex = 38;
            this.label31.Text = "Date Over Due :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(216, 94);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(170, 25);
            this.label28.TabIndex = 37;
            this.label28.Text = "Student details";
            // 
            // BookReciveLabel
            // 
            this.BookReciveLabel.AutoSize = true;
            this.BookReciveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookReciveLabel.Location = new System.Drawing.Point(712, 43);
            this.BookReciveLabel.Name = "BookReciveLabel";
            this.BookReciveLabel.Size = new System.Drawing.Size(311, 42);
            this.BookReciveLabel.TabIndex = 36;
            this.BookReciveLabel.Text = "BOOK RECEIVE";
            // 
            // studentstatus_BR_Grideview
            // 
            this.studentstatus_BR_Grideview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentstatus_BR_Grideview.Location = new System.Drawing.Point(547, 175);
            this.studentstatus_BR_Grideview.Name = "studentstatus_BR_Grideview";
            this.studentstatus_BR_Grideview.Size = new System.Drawing.Size(811, 178);
            this.studentstatus_BR_Grideview.TabIndex = 63;
            this.studentstatus_BR_Grideview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentstatus_BR_Grideview_Cell_content_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Image = global::Rental_Library_Management.Properties.Resources.backbutton;
            this.Back_Button.Location = new System.Drawing.Point(12, 12);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(48, 43);
            this.Back_Button.TabIndex = 64;
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Book_Receive_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.studentstatus_BR_Grideview);
            this.Controls.Add(this.ReturnDate_BR_Textbox);
            this.Controls.Add(this.Clear_SR_Button);
            this.Controls.Add(this.Receive_BR_button);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Fine_TextBox);
            this.Controls.Add(this.Date_Over_Due_TextBox);
            this.Controls.Add(this.Issue_Date_textbox);
            this.Controls.Add(this.Publisher_BR_TextBox);
            this.Controls.Add(this.Author_BR_TextBox);
            this.Controls.Add(this.BookName_BR_TextBox);
            this.Controls.Add(this.BookID_BR_TextBox);
            this.Controls.Add(this.Department_BR_TextBox);
            this.Controls.Add(this.StudentId_BR_TextBox);
            this.Controls.Add(this.StudentName_BR_TextBox);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.BookReciveLabel);
            this.Name = "Book_Receive_Form";
            this.Text = "Book_Receive_Form";
            ((System.ComponentModel.ISupportInitialize)(this.studentstatus_BR_Grideview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ReturnDate_BR_Textbox;
        private System.Windows.Forms.Button Clear_SR_Button;
        private System.Windows.Forms.Button Receive_BR_button;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Fine_TextBox;
        private System.Windows.Forms.TextBox Date_Over_Due_TextBox;
        private System.Windows.Forms.TextBox Issue_Date_textbox;
        private System.Windows.Forms.TextBox Publisher_BR_TextBox;
        private System.Windows.Forms.TextBox Author_BR_TextBox;
        private System.Windows.Forms.TextBox BookName_BR_TextBox;
        private System.Windows.Forms.TextBox BookID_BR_TextBox;
        private System.Windows.Forms.TextBox Department_BR_TextBox;
        private System.Windows.Forms.TextBox StudentId_BR_TextBox;
        private System.Windows.Forms.TextBox StudentName_BR_TextBox;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label BookReciveLabel;
        private System.Windows.Forms.DataGridView studentstatus_BR_Grideview;
        private System.Windows.Forms.Button Back_Button;
    }
}