namespace _2dFightTesting
{
    partial class DemoScreen
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
            this.returnButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnButton.BackColor = System.Drawing.Color.Transparent;
            this.returnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.returnButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.returnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.returnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.Transparent;
            this.returnButton.Location = new System.Drawing.Point(542, 380);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(137, 49);
            this.returnButton.TabIndex = 11;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 36F);
            this.titleLabel.ForeColor = System.Drawing.Color.Crimson;
            this.titleLabel.Location = new System.Drawing.Point(-34, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(747, 94);
            this.titleLabel.TabIndex = 28;
            this.titleLabel.Text = "Credits:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(-32, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 192);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ayush \r\nand \r\nNathan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DemoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.returnButton);
            this.Name = "DemoScreen";
            this.Size = new System.Drawing.Size(700, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
    }
}
