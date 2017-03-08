using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCombat
{
    public partial class Form1 : Form
    {
    

        public Form1()
        {
            InitializeComponent();

        }

        Character cOne;
        Character cTwo;

        /// <summary>
        /// Gives "Character" information and loads stats into the corresponding text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Give_Character_One_Click(object sender, EventArgs e)
        {
            cOne = new Character(new Stats(100, 15, 25, 12, 2), "Jerry");
            Character_One_Health.Text = cOne.CharStats.Health.ToString();
            Character_One_Defense.Text = cOne.CharStats.Defense.ToString();
            Character_One_Strength.Text = cOne.CharStats.Strength.ToString();
            Character_One_Luck.Text = cOne.CharStats.Luck.ToString();
            Character_One_Speed.Text = cOne.CharStats.Speed.ToString();

        }

        /// <summary>
        /// Gives "Character" information and loads stats into the corresponding text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Give_Character_Two_Click(object sender, EventArgs e)
        {
            cTwo = new Character(new Stats(100, 20, 20, 18, 9), "Tom");
            Character_Two_Health.Text = cTwo.CharStats.Health.ToString();
            Character_Two_Defense.Text = cTwo.CharStats.Defense.ToString();
            Character_Two_Strength.Text = cTwo.CharStats.Strength.ToString();
            Character_Two_Luck.Text = cTwo.CharStats.Luck.ToString();
            Character_Two_Speed.Text = cTwo.CharStats.Speed.ToString();
        }

        /// <summary>
        /// Saves player information by running serilize function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Button_Click(object sender, EventArgs e)
        {            
            DataManager.Serialize("Saved_Fighter_A", cOne);
            DataManager.Serialize("Saved_Fighter_B", cTwo);
        }

        /// <summary>
        /// Loadsyer information by running deserilize function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_Button_Click_1(object sender, EventArgs e)
        {
            cOne = DataManager.Deserialize<Character>("Saved_Fighter_A");
            cTwo = DataManager.Deserialize<Character>("Saved_Fighter_B");
        }
        

        private void Character_One_Health_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Character_One_Defense_TextChanged(object sender, EventArgs e)
        {

        }

        private void Character_One_Strength_TextChanged(object sender, EventArgs e)
        {

        }

        private void Character_One_Luck_TextChanged(object sender, EventArgs e)
        {

        }

        private void Character_One_Speed_TextChanged(object sender, EventArgs e)
        {

        }

        private void Character_Two_Health_TextChanged(object sender, EventArgs e)
        {

        }

        private void Character_Two_Defense_TextChanged(object sender, EventArgs e)
        {

        }

        private void Character_Two_Strength_TextChanged(object sender, EventArgs e)
        {

        }

        private void Character_Two_Luck_TextChanged(object sender, EventArgs e)
        {

        }

        private void Character_Two_Speed_TextChanged(object sender, EventArgs e)
        {

        }

        /*
        private void Attack_Click(object sender, EventArgs e)
        {
            
        }
        */
    }
}
