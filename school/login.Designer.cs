namespace school
{
    partial class login
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
            buttonRishum = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxCourseName = new TextBox();
            textBoxSemesterName = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonRishum
            // 
            buttonRishum.Location = new Point(626, 209);
            buttonRishum.Name = "buttonRishum";
            buttonRishum.Size = new Size(153, 94);
            buttonRishum.TabIndex = 0;
            buttonRishum.Text = "הרשמה לקורס";
            buttonRishum.UseVisualStyleBackColor = true;
            buttonRishum.Click += buttonRishum_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(654, 29);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 1;
            label1.Text = "בחר שם קורס";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(654, 115);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "בחר סמסטר";
            // 
            // textBoxCourseName
            // 
            textBoxCourseName.Location = new Point(642, 69);
            textBoxCourseName.Name = "textBoxCourseName";
            textBoxCourseName.Size = new Size(125, 27);
            textBoxCourseName.TabIndex = 3;
            // 
            // textBoxSemesterName
            // 
            textBoxSemesterName.Location = new Point(642, 156);
            textBoxSemesterName.Name = "textBoxSemesterName";
            textBoxSemesterName.Size = new Size(125, 27);
            textBoxSemesterName.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(256, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 5;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxSemesterName);
            Controls.Add(textBoxCourseName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonRishum);
            Name = "login";
            Text = "כניסה";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRishum;
        private Label label1;
        private Label label2;
        private TextBox textBoxCourseName;
        private TextBox textBoxSemesterName;
        private DataGridView dataGridView1;
    }
}