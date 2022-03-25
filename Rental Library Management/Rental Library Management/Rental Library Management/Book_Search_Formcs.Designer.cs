namespace Rental_Library_Management
{
    partial class Book_Search_Formcs
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
            this.SearchResult_S_DataGridView = new System.Windows.Forms.DataGridView();
            this.SearchByPublisherTextBox = new System.Windows.Forms.TextBox();
            this.SearchByAuthorTextBox = new System.Windows.Forms.TextBox();
            this.SearchByNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchByPublisherLabel = new System.Windows.Forms.Label();
            this.SearchByAuthorLabel = new System.Windows.Forms.Label();
            this.SearchByBookNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResult_S_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchResult_S_DataGridView
            // 
            this.SearchResult_S_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResult_S_DataGridView.Location = new System.Drawing.Point(245, 244);
            this.SearchResult_S_DataGridView.Name = "SearchResult_S_DataGridView";
            this.SearchResult_S_DataGridView.Size = new System.Drawing.Size(942, 369);
            this.SearchResult_S_DataGridView.TabIndex = 20;
            // 
            // SearchByPublisherTextBox
            // 
            this.SearchByPublisherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByPublisherTextBox.Location = new System.Drawing.Point(581, 156);
            this.SearchByPublisherTextBox.Name = "SearchByPublisherTextBox";
            this.SearchByPublisherTextBox.Size = new System.Drawing.Size(425, 31);
            this.SearchByPublisherTextBox.TabIndex = 19;
            this.SearchByPublisherTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchByPublisher_S_textbox_keyup_acton);
            // 
            // SearchByAuthorTextBox
            // 
            this.SearchByAuthorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByAuthorTextBox.Location = new System.Drawing.Point(581, 120);
            this.SearchByAuthorTextBox.Name = "SearchByAuthorTextBox";
            this.SearchByAuthorTextBox.Size = new System.Drawing.Size(425, 31);
            this.SearchByAuthorTextBox.TabIndex = 18;
            this.SearchByAuthorTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_By_Author_key_down_action);
            this.SearchByAuthorTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search_By_Author_key_Up_action);
            // 
            // SearchByNameTextBox
            // 
            this.SearchByNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByNameTextBox.Location = new System.Drawing.Point(581, 81);
            this.SearchByNameTextBox.Name = "SearchByNameTextBox";
            this.SearchByNameTextBox.Size = new System.Drawing.Size(425, 31);
            this.SearchByNameTextBox.TabIndex = 17;
            this.SearchByNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Search_By_Name_Action);
            // 
            // SearchByPublisherLabel
            // 
            this.SearchByPublisherLabel.AutoSize = true;
            this.SearchByPublisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByPublisherLabel.Location = new System.Drawing.Point(335, 156);
            this.SearchByPublisherLabel.Name = "SearchByPublisherLabel";
            this.SearchByPublisherLabel.Size = new System.Drawing.Size(240, 25);
            this.SearchByPublisherLabel.TabIndex = 16;
            this.SearchByPublisherLabel.Text = "Search By Publisher :";
            // 
            // SearchByAuthorLabel
            // 
            this.SearchByAuthorLabel.AutoSize = true;
            this.SearchByAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByAuthorLabel.Location = new System.Drawing.Point(365, 123);
            this.SearchByAuthorLabel.Name = "SearchByAuthorLabel";
            this.SearchByAuthorLabel.Size = new System.Drawing.Size(210, 25);
            this.SearchByAuthorLabel.TabIndex = 15;
            this.SearchByAuthorLabel.Text = "Search By Author :";
            // 
            // SearchByBookNameLabel
            // 
            this.SearchByBookNameLabel.AutoSize = true;
            this.SearchByBookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByBookNameLabel.Location = new System.Drawing.Point(307, 84);
            this.SearchByBookNameLabel.Name = "SearchByBookNameLabel";
            this.SearchByBookNameLabel.Size = new System.Drawing.Size(268, 25);
            this.SearchByBookNameLabel.TabIndex = 14;
            this.SearchByBookNameLabel.Text = "Search By Book  Name :";
            // 
            // Book_Search_Formcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.SearchResult_S_DataGridView);
            this.Controls.Add(this.SearchByPublisherTextBox);
            this.Controls.Add(this.SearchByAuthorTextBox);
            this.Controls.Add(this.SearchByNameTextBox);
            this.Controls.Add(this.SearchByPublisherLabel);
            this.Controls.Add(this.SearchByAuthorLabel);
            this.Controls.Add(this.SearchByBookNameLabel);
            this.Name = "Book_Search_Formcs";
            this.Text = "Book_Search_Formcs";
            ((System.ComponentModel.ISupportInitialize)(this.SearchResult_S_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SearchResult_S_DataGridView;
        private System.Windows.Forms.TextBox SearchByPublisherTextBox;
        private System.Windows.Forms.TextBox SearchByAuthorTextBox;
        private System.Windows.Forms.TextBox SearchByNameTextBox;
        private System.Windows.Forms.Label SearchByPublisherLabel;
        private System.Windows.Forms.Label SearchByAuthorLabel;
        private System.Windows.Forms.Label SearchByBookNameLabel;
    }
}