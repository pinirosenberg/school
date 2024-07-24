using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school
{
    public partial class login : Form
    {
        private string _name;
        //public DataGridView dataGridViewCourses;
        public DBContext dBContext;
        public CareWithGreed care;

        public login(string name, DBContext db)
        {
            InitializeComponent();
            this._name = name;
            dBContext = db;
            care = new CareWithGreed(db, dataGridView1);
            care.ChangeQuery(@"SELECT c.CourseName, C.SemesterName FROM Courses c");
            care.LoadDataBaseAsync();
        }

        private void buttonRishum_Click(object sender, EventArgs e)
        {
            SqlParameter _sqlParameter1 = new SqlParameter("@coursename", textBoxCourseName.Text);
            SqlParameter _sqlParameter2 = new SqlParameter("@semestername", textBoxSemesterName.Text);
            SqlParameter _sqlParameter3 = new SqlParameter("@semestername", _name);
            SqlParameter[] parameters = [_sqlParameter1, _sqlParameter2];
            string quest = @"DECLARE @name VARCHAR(25) = 'ניקול'\r\nDECLARE @id INT = (SELECT MAX(s.ID)\r\n\t\t\t\tFROM Student s\r\n\t\t\t\tWHERE s.NameStudent = @name)\r\nDECLARE @courseid INT = (SELECT MAX(c.ID)\r\n\t\t\t\t\t\tFROM Courses c\r\n\t\t\t\t\t\tWHERE c.CourseName = @coursename AND c.SemesterName = @semestername)\r\nDECLARE @price INT = (\r\n\t\t\tSELECT c.Price\r\n\t\t\tFROM Courses c\r\n\t\t\tWHERE C.ID = @courseid)\r\nINSERT INTO Registration(StudentID,CoursesID) \r\nVALUES(@id,@courseid)\r\n\r\nUPDATE Student\r\nSET Balance = Balance + @price\r\nWHERE ID = @id";
            care.ChangeQuery(quest);
            dBContext.ExecuteQuery(care.Query, parameters);
        }
    }
}
