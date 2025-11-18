namespace AppointmentApp.UserInterface
{
    partial class MainCustomerForm
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
            customerDataGridView = new DataGridView();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            addButton = new Button();
            modifyButton = new Button();
            deleteButton = new Button();
            searchButton = new Button();
            searchTextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // customerDataGridView
            // 
            customerDataGridView.AllowUserToAddRows = false;
            customerDataGridView.AllowUserToDeleteRows = false;
            customerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataGridView.Location = new Point(61, 91);
            customerDataGridView.MultiSelect = false;
            customerDataGridView.Name = "customerDataGridView";
            customerDataGridView.RowHeadersVisible = false;
            customerDataGridView.RowHeadersWidth = 51;
            customerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerDataGridView.Size = new Size(834, 268);
            customerDataGridView.TabIndex = 0;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // addButton
            // 
            addButton.Location = new Point(556, 387);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(679, 387);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(94, 29);
            modifyButton.TabIndex = 2;
            modifyButton.Text = "Modify";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(801, 387);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(508, 34);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Location = new Point(622, 36);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(273, 27);
            searchTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 38);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 6;
            label1.Text = "Customers";
            // 
            // MainCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 453);
            Controls.Add(label1);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(deleteButton);
            Controls.Add(modifyButton);
            Controls.Add(addButton);
            Controls.Add(customerDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Management";
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView customerDataGridView;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Button addButton;
        private Button modifyButton;
        private Button deleteButton;
        private Button searchButton;
        private TextBox searchTextBox;
        private Label label1;
    }
}