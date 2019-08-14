using COMP123_S2019_FinalTestB.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * STUDENT NAME:
 * STUDENT ID:
 * DESCRIPTION: This is the entry Form for the application
 *              
 */
namespace COMP123_S2019_FinalTestB
{
    public class Character
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public static class Program   
    {
        
        public static CharacterGeneratorForm characterForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            characterForm = new CharacterGeneratorForm();
            Application.Run(characterForm);
            Application.Exit(characterForm);
        }
    }
}
