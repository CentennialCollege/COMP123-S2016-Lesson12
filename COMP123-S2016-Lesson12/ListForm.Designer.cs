namespace COMP123_S2016_Lesson12
{
    partial class ListForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.ListGroupBox = new System.Windows.Forms.GroupBox();
            this.ProvinceListBox = new System.Windows.Forms.ListBox();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.ProvinceTextBox = new System.Windows.Forms.TextBox();
            this.ListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(274, 457);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(115, 51);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ListGroupBox
            // 
            this.ListGroupBox.Controls.Add(this.ProvinceTextBox);
            this.ListGroupBox.Controls.Add(this.ProvinceLabel);
            this.ListGroupBox.Controls.Add(this.ProvinceListBox);
            this.ListGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ListGroupBox.Name = "ListGroupBox";
            this.ListGroupBox.Size = new System.Drawing.Size(377, 425);
            this.ListGroupBox.TabIndex = 1;
            this.ListGroupBox.TabStop = false;
            this.ListGroupBox.Text = "My ListView";
            // 
            // ProvinceListBox
            // 
            this.ProvinceListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProvinceListBox.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvinceListBox.FormattingEnabled = true;
            this.ProvinceListBox.ItemHeight = 22;
            this.ProvinceListBox.Items.AddRange(new object[] {
            "Alberta",
            "British Columbia",
            "Manitoba",
            "New Brunswick",
            "Newfoundland and Labrador",
            "Northwest Territories",
            "Nova Scotia",
            "Nunavut",
            "Ontario",
            "Prince Edward Island",
            "Quebec",
            "Saskatchewan",
            "Yukon"});
            this.ProvinceListBox.Location = new System.Drawing.Point(6, 30);
            this.ProvinceListBox.Name = "ProvinceListBox";
            this.ProvinceListBox.Size = new System.Drawing.Size(297, 154);
            this.ProvinceListBox.Sorted = true;
            this.ProvinceListBox.TabIndex = 0;
            this.ProvinceListBox.SelectedIndexChanged += new System.EventHandler(this.ProvinceListBox_SelectedIndexChanged);
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvinceLabel.Location = new System.Drawing.Point(7, 213);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(96, 22);
            this.ProvinceLabel.TabIndex = 1;
            this.ProvinceLabel.Text = "Province";
            // 
            // ProvinceTextBox
            // 
            this.ProvinceTextBox.BackColor = System.Drawing.Color.White;
            this.ProvinceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProvinceTextBox.Enabled = false;
            this.ProvinceTextBox.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvinceTextBox.ForeColor = System.Drawing.Color.Black;
            this.ProvinceTextBox.Location = new System.Drawing.Point(11, 248);
            this.ProvinceTextBox.Name = "ProvinceTextBox";
            this.ProvinceTextBox.ReadOnly = true;
            this.ProvinceTextBox.Size = new System.Drawing.Size(292, 30);
            this.ProvinceTextBox.TabIndex = 2;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 520);
            this.Controls.Add(this.ListGroupBox);
            this.Controls.Add(this.NextButton);
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Form";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.ListGroupBox.ResumeLayout(false);
            this.ListGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox ListGroupBox;
        private System.Windows.Forms.ListBox ProvinceListBox;
        private System.Windows.Forms.TextBox ProvinceTextBox;
        private System.Windows.Forms.Label ProvinceLabel;
    }
}

