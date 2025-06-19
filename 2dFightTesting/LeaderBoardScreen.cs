﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _2dFightTesting
{
    public partial class LeaderBoardScreen : UserControl
    {
        List<Player> players = new List<Player>();
        String winnerName;

        class Player
        {
            public string name;
            public string wins;
        }
        public LeaderBoardScreen(String _winnerName)
        {
            winnerName = _winnerName;

            InitializeComponent();
            LoadStats();

            outputLabel.Text = "Leader Board\n\n";

            foreach (Player p in players)
            {
                outputLabel.Text += $"{p.name} : {p.wins} wins\n";
            }
        }
        private void LoadStats()
        {
            XmlReader reader = XmlReader.Create("Resources/WinRecords.xml", null);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Player")
                {
                    Player p = new Player();

                    p.name = reader.GetAttribute("name");
                    p.wins = reader.GetAttribute("wins");

                    players.Add(p);
                }
            }
            Console.WriteLine("LeadeBoard_LoadStats(): --------------");
            foreach (Player p in players)
            {
                Console.WriteLine("Player: " + p.name + " Wins: " + p.wins);
            }
            Console.WriteLine("-----------------------------");
            reader.Close();
        }

        private void OverwriteXml()
        {
            XmlWriter writer = XmlWriter.Create("Resources/WinRecords.xml", null);

            writer.WriteStartDocument();
            writer.WriteStartElement("Players");
            foreach (Player p in players)
            {
                writer.WriteStartElement("Player");
                writer.WriteAttributeString("name", p.name);
                writer.WriteAttributeString("wins", p.wins);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Close();
        }

        private void LeaderBoardScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            OverwriteXml();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new WinScreen(winnerName, "lbScreen"));
        }
    }
}
