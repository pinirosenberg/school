using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace school
{
    public partial class CoursesForm : Form
    {
        public DataGridView dataGridView_categories;
        public DBContext dBContext;
        public CareWithGreed care;
        public CoursesForm(DBContext db)
        {
            InitializeComponent();
            dBContext = db;
            care = new CareWithGreed(db, dataGridViewCourses);
            care.ChangeQuery(@"SELECT c.CourseName, C.SemesterName FROM Courses c");
            care.LoadDataBaseAsync();
        }

        private void ButtonPrice_Click(object sender, EventArgs e)
        {
            SqlParameter _sqlParameter1 = new SqlParameter("@coursename", textBoxCourseName.Text);
            SqlParameter _sqlParameter2 = new SqlParameter("@semestername", textBoxSemesterName.Text);
            SqlParameter[] parameters = [_sqlParameter1, _sqlParameter2];
            string quest = $"SELECT c.Price FROM Courses c WHERE c.CourseName = @coursename and c.SemesterName = @semestername";
            care.ChangeQuery(quest);
            DataTable dataTable = dBContext.ExecuteQuery(care.Query, parameters);
            care.LoadCategories(dataTable);
            int i = 0;
            //care.LoadDataBaseAsync();
        }

        private void buttonShowTeachers_Click(object sender, EventArgs e)
        {
            SqlParameter _sqlParameter1 = new SqlParameter("@coursename", textBoxCourseName.Text);
            SqlParameter[] parameters = [_sqlParameter1];
            string quest = $"SELECT t.TeacherName FROM dbo.Teacher t INNER JOIN Unit u on t.TeacherID = u.TeacherID WHERE u.CourseName = @coursename";
            care.ChangeQuery(quest);
            DataTable dataTable = dBContext.ExecuteQuery(care.Query, parameters);
            care.LoadCategories(dataTable);
        }
    }
}
