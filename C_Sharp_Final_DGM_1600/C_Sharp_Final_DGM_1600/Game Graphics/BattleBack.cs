using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Final_DGM_1600
{
    public partial class C_Sharp_Final : Form
    {
        private PlayerCharacter wystan;
        

        public C_Sharp_Final()
        {
            InitializeComponent();
            PlayerCharacter wystan = new PlayerCharacter();
        }

        //About message box displays developer information
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game was conceived and constructed by Paul Awesome Weaver, Lord and Savior of mankind and a scholarly gentleman to boot!\nCopyright DP3 Softworks 2016");
        }

        //Closes the program
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Initializes a new game 
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void BoxMonster1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAttack_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Displays current equipment and gives an emboldening statement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFlailAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{wystan.Charm}");
        }
    }
}
