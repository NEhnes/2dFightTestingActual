using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2dFightTesting.Properties;


namespace _2dFightTesting
{
    public partial class NameInputScreen : UserControl
    {
        SoundPlayer chooseYourCharacter = new SoundPlayer(Properties.Resources.chooseYourCharacter);
        public NameInputScreen()
        {
            InitializeComponent();
            chooseYourCharacter.Play();
        }

        private void confirmName_Click(object sender, EventArgs e)
        {
            // Validate player names

            Form1.ChangeScreen(this, new GameScreen(player1NameTextBox.Text, player2NameTextBox.Text));
            chooseYourCharacter.Stop();
        }

        private void player1NameTextBox_Enter(object sender, EventArgs e)
        {
            player1NameTextBox.Text = "";
        }

        private void player2NameTextBox_Enter(object sender, EventArgs e)
        {
            player2NameTextBox.Text = "";
        }
    }
}
