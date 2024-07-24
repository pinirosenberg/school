using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
namespace school
{
    public partial class sighnin : Form
    {
        private string _connectionString;

        private DBContext _dbContext;
        private CoursesForm courses;
        private CareWithGreed care;
        public sighnin(DBContext dBContext, CoursesForm coursesForm)
        {
            InitializeComponent();
            _dbContext = dBContext;
            courses = coursesForm;
            
            int i = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sighnIn_Click(object sender, EventArgs e)
        {
            SqlParameter _sqlParameter = new SqlParameter("@student", name.Text);
            SqlParameter[] parameters = [_sqlParameter];
            int isInsert = _dbContext.ExecuteNonQuery("INSERT INTO Student(NameStudent, Balance) VALUES(@student, 0);", parameters);

        }

        private void listOfAll_Click(object sender, EventArgs e)
        {
            courses.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlParameter _sqlParameter1 = new SqlParameter("@name", name.Text);
            SqlParameter[] parameters = [_sqlParameter1];
            DataTable dataTable = _dbContext.ExecuteQuery("select * from student s where s.NameStudent = @name", parameters);
            if (dataTable.Rows.Count > 0)
            {
                //courses.Show();
                login log = new login(name.Text, _dbContext);
                log.Show();
                this.Hide();
            }
            }
    }
}
