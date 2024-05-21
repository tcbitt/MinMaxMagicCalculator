namespace MinMaxMagicCalculator
{
    partial class MinMax
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinMax));
            label1 = new Label();
            intBox = new TextBox();
            label2 = new Label();
            magicBox = new TextBox();
            skillChoice = new ComboBox();
            label3 = new Label();
            skillPicture = new PictureBox();
            label4 = new Label();
            skillRank = new NumericUpDown();
            calculateButton = new Button();
            maxValue = new TextBox();
            maxLabel = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            minValue = new TextBox();
            LUKlabel = new Label();
            LUKbox = new TextBox();
            pictureBox3 = new PictureBox();
            numMobs = new Label();
            numMobsValue = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)skillPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)skillRank).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMobsValue).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Current INT:";
            // 
            // intBox
            // 
            intBox.Location = new Point(101, 6);
            intBox.Name = "intBox";
            intBox.PlaceholderText = "Your INT";
            intBox.Size = new Size(110, 23);
            intBox.TabIndex = 1;
            intBox.KeyPress += intBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 37);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Current Magic:";
            // 
            // magicBox
            // 
            magicBox.Location = new Point(101, 34);
            magicBox.Name = "magicBox";
            magicBox.PlaceholderText = "Your Magic";
            magicBox.Size = new Size(110, 23);
            magicBox.TabIndex = 3;
            magicBox.KeyPress += intBox_KeyPress;
            // 
            // skillChoice
            // 
            skillChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            skillChoice.FormattingEnabled = true;
            skillChoice.Items.AddRange(new object[] { "Energy Bolt", "Magic Claw", "Fire Arrow", "Poison Brace", "Cold Beam", "Thunderbolt", "Holy Arrow", "Heal", "Explosion", "Poison Mist", "Element Compos.", "Ice Strike", "Thunder Spear", "Shining Ray", "Fire Demon", "Elquines", "Paralyze", "Meteor Shower", "Ice Demon", "Ifrit", "Chain Lightning", "Blizzard", "Bahamut", "Angel Ray", "Genesis" });
            skillChoice.Location = new Point(101, 63);
            skillChoice.Name = "skillChoice";
            skillChoice.Size = new Size(110, 23);
            skillChoice.TabIndex = 4;
            skillChoice.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 66);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Skill Used:";
            // 
            // skillPicture
            // 
            skillPicture.Location = new Point(146, 121);
            skillPicture.Name = "skillPicture";
            skillPicture.Size = new Size(32, 34);
            skillPicture.TabIndex = 8;
            skillPicture.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 122);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "Skill Rank:";
            // 
            // skillRank
            // 
            skillRank.Location = new Point(101, 120);
            skillRank.Name = "skillRank";
            skillRank.Size = new Size(39, 23);
            skillRank.TabIndex = 10;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(67, 160);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(128, 23);
            calculateButton.TabIndex = 11;
            calculateButton.Text = "Calculate!";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.MouseClick += CalcButton_MouseClick;
            // 
            // maxValue
            // 
            maxValue.Location = new Point(318, 5);
            maxValue.Name = "maxValue";
            maxValue.ReadOnly = true;
            maxValue.Size = new Size(100, 23);
            maxValue.TabIndex = 12;
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Location = new Point(279, 8);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(33, 15);
            maxLabel.TabIndex = 13;
            maxLabel.Text = "Max:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.theBoss;
            pictureBox1.Location = new Point(279, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 147);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 90);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 37);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 16;
            label5.Text = "Min:";
            // 
            // minValue
            // 
            minValue.Location = new Point(318, 34);
            minValue.Name = "minValue";
            minValue.ReadOnly = true;
            minValue.Size = new Size(100, 23);
            minValue.TabIndex = 17;
            // 
            // LUKlabel
            // 
            LUKlabel.AutoSize = true;
            LUKlabel.Location = new Point(21, 95);
            LUKlabel.Name = "LUKlabel";
            LUKlabel.Size = new Size(74, 15);
            LUKlabel.TabIndex = 18;
            LUKlabel.Text = "Current LUK:";
            LUKlabel.Visible = false;
            // 
            // LUKbox
            // 
            LUKbox.Location = new Point(101, 92);
            LUKbox.Name = "LUKbox";
            LUKbox.PlaceholderText = "Your LUK";
            LUKbox.ReadOnly = true;
            LUKbox.Size = new Size(110, 23);
            LUKbox.TabIndex = 19;
            LUKbox.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.signature;
            pictureBox3.Location = new Point(110, 229);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(308, 50);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // numMobs
            // 
            numMobs.AutoSize = true;
            numMobs.Location = new Point(184, 122);
            numMobs.Name = "numMobs";
            numMobs.Size = new Size(45, 30);
            numMobs.TabIndex = 21;
            numMobs.Text = "Mobs \r\nhealed:";
            numMobs.Visible = false;
            // 
            // numMobsValue
            // 
            numMobsValue.Location = new Point(235, 121);
            numMobsValue.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numMobsValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMobsValue.Name = "numMobsValue";
            numMobsValue.Size = new Size(35, 23);
            numMobsValue.TabIndex = 22;
            numMobsValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numMobsValue.Visible = false;
            // 
            // MinMax
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 287);
            Controls.Add(numMobsValue);
            Controls.Add(numMobs);
            Controls.Add(pictureBox3);
            Controls.Add(LUKbox);
            Controls.Add(LUKlabel);
            Controls.Add(minValue);
            Controls.Add(label5);
            Controls.Add(maxLabel);
            Controls.Add(maxValue);
            Controls.Add(calculateButton);
            Controls.Add(skillRank);
            Controls.Add(label4);
            Controls.Add(skillPicture);
            Controls.Add(label3);
            Controls.Add(skillChoice);
            Controls.Add(magicBox);
            Controls.Add(label2);
            Controls.Add(intBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MinMax";
            Text = "Min Max Mapleroyals Magic Calculator";
            ((System.ComponentModel.ISupportInitialize)skillPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)skillRank).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMobsValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox intBox;
        private Label label2;
        private TextBox magicBox;
        private ComboBox skillChoice;
        private Label label3;
        private PictureBox skillPicture;
        private Label label4;
        private NumericUpDown skillRank;
        private Button calculateButton;
        private TextBox maxValue;
        private Label maxLabel;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private TextBox minValue;
        private ColorDialog colorDialog1;
        private Label LUKlabel;
        private TextBox LUKbox;
        private PictureBox pictureBox3;
        private Label numMobs;
        private NumericUpDown numMobsValue;
    }
}
