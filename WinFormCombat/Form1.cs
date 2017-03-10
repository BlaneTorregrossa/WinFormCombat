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

       

        

        //private string m_CharacterName;
        //private int m_CharacterStat;

        //public string CharacterName { get { return m_CharacterName; }
        //                              set { m_CharacterName = value; } }

        //public int CharacterStat { get { return m_CharacterStat; }
        //                           set { m_CharacterStat = value; } }

        public void UpdateCharacterOne()
        {
            Character_One_Health.Text = Singleton.Instance.cOne.CharStats.Health.ToString();
            Character_One_Defense.Text = Singleton.Instance.cOne.CharStats.Defense.ToString();
            Character_One_Strength.Text = Singleton.Instance.cOne.CharStats.Strength.ToString();
            Character_One_Luck.Text = Singleton.Instance.cOne.CharStats.Luck.ToString();
            Character_One_Speed.Text = Singleton.Instance.cOne.CharStats.Speed.ToString();
        }

        public void UpdateCharacterTwo()
        {
            Character_Two_Health.Text = Singleton.Instance.cTwo.CharStats.Health.ToString();
            Character_Two_Defense.Text = Singleton.Instance.cTwo.CharStats.Defense.ToString();
            Character_Two_Strength.Text = Singleton.Instance.cTwo.CharStats.Strength.ToString();
            Character_Two_Luck.Text = Singleton.Instance.cTwo.CharStats.Luck.ToString();
            Character_Two_Speed.Text = Singleton.Instance.cTwo.CharStats.Speed.ToString();
            
        }

  

        /// <summary>
        /// Gives "Character" information and loads stats into the corresponding text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Give_Character_One_Click(object sender, EventArgs e)
        {
            Singleton.Instance.cOne = new Character("Jerry", new Stats(100, 15, 25, 12, 2));
            UpdateCharacterOne();
            //Character_One_Health.Text = cOne.CharStats.Health.ToString();
            //Character_One_Defense.Text = cOne.CharStats.Defense.ToString();
            //Character_One_Strength.Text = cOne.CharStats.Strength.ToString();
            //Character_One_Luck.Text = cOne.CharStats.Luck.ToString();
            //Character_One_Speed.Text = cOne.CharStats.Speed.ToString();

        }

        /// <summary>
        /// Gives "Character" information and loads stats into the corresponding text box
        /// makes use of singleton to call
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Give_Character_Two_Click(object sender, EventArgs e)
        {
            Singleton.Instance.cTwo = new Character("Tom", new Stats(100, 20, 20, 18, 9));
            UpdateCharacterTwo();
            //Character_Two_Health.Text = cTwo.CharStats.Health.ToString();
            //Character_Two_Defense.Text = cTwo.CharStats.Defense.ToString();
            //Character_Two_Strength.Text = cTwo.CharStats.Strength.ToString();
            //Character_Two_Luck.Text = cTwo.CharStats.Luck.ToString();
            //Character_Two_Speed.Text = cTwo.CharStats.Speed.ToString();

        }


        /// <summary>
        /// Saves player information by running serilize function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Button_Click(object sender, EventArgs e)
        {            
            DataManager.Serialize("Saved_Fighter_A", Singleton.Instance.cOne);
            DataManager.Serialize("Saved_Fighter_B", Singleton.Instance.cTwo);
        }

        /// <summary>
        /// Loadsyer information by running deserilize function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_Button_Click_1(object sender, EventArgs e)
        {
            Singleton.Instance.cOne = DataManager.Deserialize<Character>("Saved_Fighter_A");
            Singleton.Instance.cTwo = DataManager.Deserialize<Character>("Saved_Fighter_B");
            UpdateCharacterOne();
            UpdateCharacterTwo();
        }


        private void Attack_Character_1_Click(object sender, EventArgs e)
        {
            Singleton.Instance.cTwo.Attack(Singleton.Instance.cOne);
            UpdateCharacterOne();
            

            //Character_One_Health.Text = cOne.CharStats.Health.ToString();
            //Character_One_Defense.Text = cOne.CharStats.Defense.ToString();
            //Character_One_Strength.Text = cOne.CharStats.Strength.ToString();
            //Character_One_Luck.Text = cOne.CharStats.Luck.ToString();
            //Character_One_Speed.Text = cOne.CharStats.Speed.ToString();
        }

        private void Attack_Character_2_Click(object sender, EventArgs e)
        {
            Singleton.Instance.cOne.Attack(Singleton.Instance.cTwo);
            UpdateCharacterTwo();
            //Character_Two_Health.Text = cTwo.CharStats.Health.ToString();
            //Character_Two_Defense.Text = cTwo.CharStats.Defense.ToString();
            //Character_Two_Strength.Text = cTwo.CharStats.Strength.ToString();
            //Character_Two_Luck.Text = cTwo.CharStats.Luck.ToString();
            //Character_Two_Speed.Text = cTwo.CharStats.Speed.ToString();
        }


        private void Defend_Character_1_Click(object sender, EventArgs e)
        {
            Singleton.Instance.cOne.Defend(Singleton.Instance.cOne);
            UpdateCharacterOne();
            //Character_One_Health.Text = cOne.CharStats.Health.ToString();
            //Character_One_Defense.Text = cOne.CharStats.Defense.ToString();
            //Character_One_Strength.Text = cOne.CharStats.Strength.ToString();
            //Character_One_Luck.Text = cOne.CharStats.Luck.ToString();
            //Character_One_Speed.Text = cOne.CharStats.Speed.ToString();
        }

        private void Defend_Character_2_Click(object sender, EventArgs e)
        {
            Singleton.Instance.cTwo.Defend(Singleton.Instance.cTwo);
            UpdateCharacterTwo();
            //Character_Two_Health.Text = cTwo.CharStats.Health.ToString();
            //Character_Two_Defense.Text = cTwo.CharStats.Defense.ToString();
            //Character_Two_Strength.Text = cTwo.CharStats.Strength.ToString();
            //Character_Two_Luck.Text = cTwo.CharStats.Luck.ToString();
            //Character_Two_Speed.Text = cTwo.CharStats.Speed.ToString();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        //private void Health_Compare_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void Defense_Compare_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void Strength_Compare_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void Luck_Compare_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void Speed_Compare_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
