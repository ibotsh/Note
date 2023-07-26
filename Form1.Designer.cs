namespace NoteTakingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textTitle = new TextBox();
            textMessage = new TextBox();
            dataGridView1 = new DataGridView();
            newButton = new Button();
            saveButton = new Button();
            reloadButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 49);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 0;
            label1.Text = "Title";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 82);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Message ";
            // 
            // textTitle
            // 
            textTitle.BorderStyle = BorderStyle.FixedSingle;
            textTitle.Location = new Point(161, 43);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(162, 31);
            textTitle.TabIndex = 2;
            // 
            // textMessage
            // 
            textMessage.BorderStyle = BorderStyle.FixedSingle;
            textMessage.Location = new Point(161, 82);
            textMessage.Multiline = true;
            textMessage.Name = "textMessage";
            textMessage.Size = new Size(261, 205);
            textMessage.TabIndex = 3;
            textMessage.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(453, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(255, 244);
            dataGridView1.TabIndex = 4;
            // 
            // newButton
            // 
            newButton.BackColor = SystemColors.GradientActiveCaption;
            newButton.Location = new Point(161, 344);
            newButton.Name = "newButton";
            newButton.Size = new Size(112, 34);
            newButton.TabIndex = 5;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.GradientActiveCaption;
            saveButton.Location = new Point(310, 344);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // reloadButton
            // 
            reloadButton.BackColor = SystemColors.GradientActiveCaption;
            reloadButton.Location = new Point(453, 344);
            reloadButton.Name = "reloadButton";
            reloadButton.Size = new Size(112, 34);
            reloadButton.TabIndex = 7;
            reloadButton.Text = "Read";
            reloadButton.UseVisualStyleBackColor = false;
            reloadButton.Click += reloadButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.GradientActiveCaption;
            deleteButton.Location = new Point(596, 344);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(112, 34);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(reloadButton);
            Controls.Add(saveButton);
            Controls.Add(newButton);
            Controls.Add(dataGridView1);
            Controls.Add(textMessage);
            Controls.Add(textTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textTitle;
        private TextBox textMessage;
        private DataGridView dataGridView1;
        private Button newButton;
        private Button saveButton;
        private Button reloadButton;
        private Button deleteButton;
    }
}