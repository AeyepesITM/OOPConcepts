namespace OOPConcepts.UserInterface
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
            label3 = new Label();
            txtYear = new TextBox();
            txtMonth = new TextBox();
            txtDay = new TextBox();
            btnValidate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 44);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Year:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 75);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Month:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 106);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Day:";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(157, 41);
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = "Enter the year...";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 3;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(157, 74);
            txtMonth.Name = "txtMonth";
            txtMonth.PlaceholderText = "Enter the month...";
            txtMonth.Size = new Size(125, 27);
            txtMonth.TabIndex = 4;
            // 
            // txtDay
            // 
            txtDay.Location = new Point(157, 107);
            txtDay.Name = "txtDay";
            txtDay.PlaceholderText = "Enter the day...";
            txtDay.Size = new Size(125, 27);
            txtDay.TabIndex = 5;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(81, 183);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(201, 29);
            btnValidate.TabIndex = 6;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 314);
            Controls.Add(btnValidate);
            Controls.Add(txtDay);
            Controls.Add(txtMonth);
            Controls.Add(txtYear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Date Validator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtYear;
        private TextBox txtMonth;
        private TextBox txtDay;
        private Button btnValidate;
    }
}
