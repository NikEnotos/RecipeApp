using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseworkApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginWin = new LogInWindow();
            Application.Run(loginWin);
            //Application.Run(new leaveComment());
        }

        // Admin password
        public static string AdminPWD = "qwe";

        // Login Form
        public static LogInWindow loginWin;

        // Home Form
        public static Home homeForm;

        // define an instance of the database
        public static mssql2303722Entities RecipesDB = new mssql2303722Entities();

        // declare var to store current user index
        public static int userIndex = -1;

        public static List<Ingredient> availableIngredients = new List<Ingredient>();
    }
}
