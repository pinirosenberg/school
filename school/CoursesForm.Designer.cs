namespace school
{
    partial class CoursesForm
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
            dataGridViewCourses = new DataGridView();
            ButtonPrice = new Button();
            label1 = new Label();
            textBoxCourseName = new TextBox();
            textBoxSemesterName = new TextBox();
            label2 = new Label();
            buttonShowTeachers = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Location = new Point(207, 211);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.RowHeadersWidth = 51;
            dataGridViewCourses.Size = new Size(300, 188);
            dataGridViewCourses.TabIndex = 0;
            // 
            // ButtonPrice
            // 
            ButtonPrice.Location = new Point(617, 59);
            ButtonPrice.Name = "ButtonPrice";
            ButtonPrice.Size = new Size(113, 59);
            ButtonPrice.TabIndex = 1;
            ButtonPrice.Text = "מחיר קורס";
            ButtonPrice.UseVisualStyleBackColor = true;
            ButtonPrice.Click += ButtonPrice_Click;
            // 
            // label1
            // 
            label1.Location = new Point(617, 147);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 2;
            label1.Text = "הזן שם קורס";
            // 
            // textBoxCourseName
            // 
            textBoxCourseName.Location = new Point(605, 196);
            textBoxCourseName.Name = "textBoxCourseName";
            textBoxCourseName.Size = new Size(125, 27);
            textBoxCourseName.TabIndex = 3;
            // 
            // textBoxSemesterName
            // 
            textBoxSemesterName.Location = new Point(605, 301);
            textBoxSemesterName.Name = "textBoxSemesterName";
            textBoxSemesterName.Size = new Size(125, 27);
            textBoxSemesterName.TabIndex = 4;
            // 
            // label2
            // 
            label2.Location = new Point(611, 255);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 5;
            label2.Text = "הזן סמסטר";
            // 
            // buttonShowTeachers
            // 
            buttonShowTeachers.Location = new Point(60, 89);
            buttonShowTeachers.Name = "buttonShowTeachers";
            buttonShowTeachers.Size = new Size(112, 52);
            buttonShowTeachers.TabIndex = 6;
            buttonShowTeachers.Text = "ראה מרצים";
            buttonShowTeachers.UseVisualStyleBackColor = true;
            buttonShowTeachers.Click += buttonShowTeachers_Click;
            // 
            // CoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShowTeachers);
            Controls.Add(label2);
            Controls.Add(textBoxSemesterName);
            Controls.Add(textBoxCourseName);
            Controls.Add(label1);
            Controls.Add(ButtonPrice);
            Controls.Add(dataGridViewCourses);
            Name = "CoursesForm";
            Text = "קורסים";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCourses;
        private Button ButtonPrice;
        private Label label1;
        private TextBox textBoxCourseName;
        private TextBox textBoxSemesterName;
        private Label label2;
        private Button buttonShowTeachers;
    }
}