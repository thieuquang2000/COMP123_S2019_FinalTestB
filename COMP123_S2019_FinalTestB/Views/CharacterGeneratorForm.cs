using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME: Thieu Quang Ngo    
 * STUDENT ID: 301033257
 * DESCRIPTION: This is the Character Generator Form
 *              
 */
namespace COMP123_S2019_FinalTestB.Views
{
    public partial class CharacterGeneratorForm : MasterForm
    {

        List<string> FirstNameList;
        List<string> LastNameList;
        List<string> FisrtName;
        List<string> LastName;
        List<string> InventoryList;
        public static CharacterGeneratorForm characterForm;
        public void LoadNames(Random FirstName, Random LastName)
        {
            FirstName =  "..\\..\\Data\\firstName.txt";
            LastName = "..\\..Data\\lastName.txt";
        }
        public void GenerateNames()
        {
            Random FirstNames = FirstNameList();
            Random LastNames = LastNameList();
        }



        public CharacterGeneratorForm()
        {
            InitializeComponent();
        }
/// <summary>
        /// This is he event for the backButton
        /// </summary>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }
        /// <summary>
        /// This is he event for the nextButton
        /// </summary>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }
        
        
        private void GenerrateNameButton_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            characterForm = new CharacterGeneratorForm();
            Application.Exit(characterForm);
        }
    }
}
