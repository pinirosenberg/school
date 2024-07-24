using Microsoft.Extensions.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace school
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            string _connectionString;
            DBContext _dbContext;
            IConfiguration builder = new ConfigurationBuilder().
                AddJsonFile("DAL/secrets.json", optional: true).Build();
            _connectionString = builder["connectionString"];
            _dbContext = new DBContext(_connectionString);
            ApplicationConfiguration.Initialize();
            CoursesForm coursesForm = new CoursesForm(_dbContext);
            sighnin formSighn = new sighnin(_dbContext, coursesForm);
            formSighn.Show();
            Application.Run();
        }
    }
}