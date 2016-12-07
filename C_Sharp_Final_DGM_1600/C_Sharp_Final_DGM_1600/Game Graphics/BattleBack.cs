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
        bool musicOnOff = true;

        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();

        private PlayerCharacter wystan;
        private Equipment characterEquipment;
        private CombatSystem combatSystem;

        public C_Sharp_Final()
        {
            InitializeComponent();

            PlayerCharacter wystan = new PlayerCharacter();
            Equipment characterEquipment = new Equipment();
            CombatSystem combatSystem = new CombatSystem();
            
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
            TxtBoxMain.Text = ("Don't click me, scum! Click your buttons!");
        }

        private void BtnAttack_Click(object sender, EventArgs e)
        {
            TxtBoxMain.Text = ("You strike out at your enemies with vigor!");
        }

        /// <summary>
        /// Displays current equipment and gives an emboldening statement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFlailAbout_Click(object sender, EventArgs e)
        {
            TxtBoxMain.Text = ("You flail about helplessly!");
        }

        private void MnuSoundsButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Turns music On
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Picture box text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PBoxMonster2_Click(object sender, EventArgs e)
        {
            TxtBoxMain.Text = ("Don't click me, scum! Click your buttons!");
        }

        //Picture box text 
        private void PBoxMonster3_Click(object sender, EventArgs e)
        {
            TxtBoxMain.Text = ("Hands off, plebeian scum!");
        }

        //Turns music off
        private void BtnSoundOff_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnDefend_Click(object sender, EventArgs e)
        {
            TxtBoxMain.Text = ("You fiercely defend against the violent attacks of the enemy!");
        }
    }
}
