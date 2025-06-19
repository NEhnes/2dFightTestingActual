﻿namespace _2dFightTesting
{
    partial class NameInputScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.player1NameTextBox = new System.Windows.Forms.TextBox();
            this.player2NameTextBox = new System.Windows.Forms.TextBox();
            this.player2Result = new System.Windows.Forms.Label();
            this.player1Result = new System.Windows.Forms.Label();
            this.player2PictureBox = new System.Windows.Forms.PictureBox();
            this.player1PictureBox = new System.Windows.Forms.PictureBox();
            this.confirmName = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // player1NameTextBox
            // 
            this.player1NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.player1NameTextBox.Location = new System.Drawing.Point(61, 314);
            this.player1NameTextBox.Name = "player1NameTextBox";
            this.player1NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.player1NameTextBox.TabIndex = 0;
            this.player1NameTextBox.Text = "INPUT NAME";
            this.player1NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player1NameTextBox.Enter += new System.EventHandler(this.player1NameTextBox_Enter);
            // 
            // player2NameTextBox
            // 
            this.player2NameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.player2NameTextBox.Location = new System.Drawing.Point(529, 314);
            this.player2NameTextBox.Name = "player2NameTextBox";
            this.player2NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.player2NameTextBox.TabIndex = 1;
            this.player2NameTextBox.Text = "INPUT NAME";
            this.player2NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player2NameTextBox.Enter += new System.EventHandler(this.player2NameTextBox_Enter);
            // 
            // player2Result
            // 
            this.player2Result.AutoSize = true;
            this.player2Result.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.player2Result.ForeColor = System.Drawing.Color.Crimson;
            this.player2Result.Location = new System.Drawing.Point(505, 77);
            this.player2Result.Name = "player2Result";
            this.player2Result.Size = new System.Drawing.Size(138, 44);
            this.player2Result.TabIndex = 24;
            this.player2Result.Text = "Player2: ";
            // 
            // player1Result
            // 
            this.player1Result.AutoSize = true;
            this.player1Result.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.player1Result.ForeColor = System.Drawing.Color.Crimson;
            this.player1Result.Location = new System.Drawing.Point(53, 77);
            this.player1Result.Name = "player1Result";
            this.player1Result.Size = new System.Drawing.Size(138, 44);
            this.player1Result.TabIndex = 23;
            this.player1Result.Text = "Player1: ";
            // 
            // player2PictureBox
            // 
            this.player2PictureBox.BackgroundImage = global::_2dFightTesting.Properties.Resources.blue_idle1;
            this.player2PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2PictureBox.Location = new System.Drawing.Point(491, 124);
            this.player2PictureBox.Name = "player2PictureBox";
            this.player2PictureBox.Size = new System.Drawing.Size(163, 167);
            this.player2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player2PictureBox.TabIndex = 22;
            this.player2PictureBox.TabStop = false;
            // 
            // player1PictureBox
            // 
            this.player1PictureBox.BackgroundImage = global::_2dFightTesting.Properties.Resources.idle1;
            this.player1PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player1PictureBox.Location = new System.Drawing.Point(39, 124);
            this.player1PictureBox.Name = "player1PictureBox";
            this.player1PictureBox.Size = new System.Drawing.Size(163, 167);
            this.player1PictureBox.TabIndex = 21;
            this.player1PictureBox.TabStop = false;
            // 
            // confirmName
            // 
            this.confirmName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmName.BackColor = System.Drawing.Color.Black;
            this.confirmName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.confirmName.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.confirmName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.confirmName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.confirmName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmName.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmName.ForeColor = System.Drawing.Color.Transparent;
            this.confirmName.Location = new System.Drawing.Point(251, 352);
            this.confirmName.Name = "confirmName";
            this.confirmName.Size = new System.Drawing.Size(194, 83);
            this.confirmName.TabIndex = 25;
            this.confirmName.Text = "Confirm";
            this.confirmName.UseVisualStyleBackColor = false;
            this.confirmName.Click += new System.EventHandler(this.confirmName_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.titleLabel.ForeColor = System.Drawing.Color.Crimson;
            this.titleLabel.Location = new System.Drawing.Point(81, 17);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(517, 44);
            this.titleLabel.TabIndex = 26;
            this.titleLabel.Text = "Please Enter Your Character Name:";
            // 
            // NameInputScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.confirmName);
            this.Controls.Add(this.player2Result);
            this.Controls.Add(this.player1Result);
            this.Controls.Add(this.player2PictureBox);
            this.Controls.Add(this.player1PictureBox);
            this.Controls.Add(this.player2NameTextBox);
            this.Controls.Add(this.player1NameTextBox);
            this.Name = "NameInputScreen";
            this.Size = new System.Drawing.Size(700, 450);
            ((System.ComponentModel.ISupportInitialize)(this.player2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox player1NameTextBox;
        private System.Windows.Forms.TextBox player2NameTextBox;
        private System.Windows.Forms.Label player2Result;
        private System.Windows.Forms.Label player1Result;
        private System.Windows.Forms.PictureBox player2PictureBox;
        private System.Windows.Forms.PictureBox player1PictureBox;
        private System.Windows.Forms.Button confirmName;
        private System.Windows.Forms.Label titleLabel;
    }
}
