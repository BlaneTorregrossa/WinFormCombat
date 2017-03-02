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


            //Stats cOneStats = new Stats(100, 10, 25, 12, 2);
            //Stats cTwoStats = new Stats(100, 5, 20, 15, 6);


            //Character cOne = new Character(cOneStats, "Bob");
            //Character cTwo = new Character(cTwoStats, "Blane");


        }

        Character cOne;
        Character cTwo;
        private void Save_Button_Click(object sender, EventArgs e)
        {            
            cOne = new Character(new Stats(100, 10, 25, 12, 2), "Jerry");
            cTwo = new Character(new Stats(100, 20, 20, 18, 9), "Tom");
            DataManager.Serialize("Saved_Fighter_A", cOne);
            DataManager.Serialize("Saved_Fighter_B", cTwo);


        }

        private void Load_Button_Click_1(object sender, EventArgs e)
        {
            cOne = DataManager.Deserialize<Character>("Saved_Fighter_A");
            cTwo = DataManager.Deserialize<Character>("Saved_Fighter_B");

        }
    }
}
