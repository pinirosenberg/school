namespace school
{
    partial class sighnin
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
            sighIn = new Button();
            name = new TextBox();
            listOfAll = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 87);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "אנא הכנס שם";
            // 
            // sighIn
            // 
            sighIn.Location = new Point(212, 239);
            sighIn.Name = "sighIn";
            sighIn.Size = new Size(142, 73);
            sighIn.TabIndex = 2;
            sighIn.Text = "הרשמה";
            sighIn.UseVisualStyleBackColor = true;
            sighIn.Click += sighnIn_Click;
            // 
            // name
            // 
            name.Location = new Point(295, 152);
            name.Multiline = true;
            name.Name = "name";
            name.Size = new Size(142, 51);
            name.TabIndex = 3;
            // 
            // listOfAll
            // 
            listOfAll.Location = new Point(50, 59);
            listOfAll.Name = "listOfAll";
            listOfAll.Size = new Size(95, 70);
            listOfAll.TabIndex = 4;
            listOfAll.Text = "רשימת קורסים";
            listOfAll.UseVisualStyleBackColor = true;
            listOfAll.Click += listOfAll_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(470, 239);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(136, 73);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "כניסה";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // sighnin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogin);
            Controls.Add(listOfAll);
            Controls.Add(name);
            Controls.Add(sighIn);
            Controls.Add(label1);
            Name = "sighnin";
            Text = "מתעניינים";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sighnIn;
        private Label label1;
        private Button sighIn;
        private TextBox name;
        private Button listOfAll;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonLogin;
    }
}
