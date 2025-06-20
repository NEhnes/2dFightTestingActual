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

            if (string.IsNullOrWhiteSpace(player1NameTextBox.Text) || string.IsNullOrWhiteSpace(player2NameTextBox.Text))
            {
                MessageBox.Show("Please enter names for both players.");
                return;
            }

            if (player1NameTextBox.Text.Length > 8 || player2NameTextBox.Text.Length > 8)
            {
                MessageBox.Show("Names must be 8 characters or less.");
                return;
            }

            if (player1NameTextBox.Text.Length < 2 || player2NameTextBox.Text.Length < 2)
            {
                MessageBox.Show("Names must be at least 2 characters long.");
                return;
            }

            if (player1NameTextBox.Text == player2NameTextBox.Text)
            {
                MessageBox.Show("Players must have different names.");
                return;
            }

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
