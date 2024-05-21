using System.Reflection.PortableExecutable;


namespace MinMaxMagicCalculator
{
    public partial class MinMax : Form
    {
        public MinMax()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string skill = skillChoice.SelectedItem as string;

            switch (skill)
            {
                case null:
                    skillPicture.Image = null;
                    break;
                case "Energy Bolt":
                    setSkillChoice(20, Properties.Resources.energyBolt);
                    break;
                case "Magic Claw":
                    setSkillChoice(20, Properties.Resources.magicClaw);
                    break;
                case "Fire Arrow":
                    setSkillChoice(30, Properties.Resources.fireArrow);
                    break;
                case "Poison Brace":
                    setSkillChoice(30, Properties.Resources.poisonBrace);
                    break;
                case "Cold Beam":
                    setSkillChoice(30, Properties.Resources.coldBeam);
                    break;
                case "Thunderbolt":
                    setSkillChoice(30, Properties.Resources.thunderbolt);
                    break;
                case "Holy Arrow":
                    setSkillChoice(30, Properties.Resources.holyArrow);
                    break;
                case "Heal":
                    skillRank.Value = 1;
                    LUKlabel.Visible = true;
                    LUKbox.Visible = true;
                    LUKbox.ReadOnly = false;
                    numMobs.Visible = true;
                    numMobsValue.Visible = true;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.heal;
                    break;
                case "Explosion":
                    setSkillChoice(30, Properties.Resources.explosion);
                    break;
                case "Poison Mist":
                    setSkillChoice(30, Properties.Resources.poisonMist);
                    break;
                case "Element Composition":
                    setSkillChoice(30, Properties.Resources.elementalComposition);
                    break;
                case "Ice Strike":
                    setSkillChoice(30, Properties.Resources.iceStrike);
                    break;
                case "Thunder Spear":
                    setSkillChoice(30, Properties.Resources.thunderSpear);
                    break;
                case "Shining Ray":
                    setSkillChoice(30, Properties.Resources.shiningRay);
                    break;
                case "Fire Demon":
                    setSkillChoice(30, Properties.Resources.fireDemon);
                    break;
                case "Elquines":
                    setSkillChoice(30, Properties.Resources.elquines);
                    break;
                case "Paralyze":
                    setSkillChoice(30, Properties.Resources.paralyze);
                    break;
                case "Meteor Shower":
                    setSkillChoice(30, Properties.Resources.meteorShower);
                    break;
                case "Ice Demon":
                    setSkillChoice(30, Properties.Resources.iceDemon);
                    break;
                case "Ifrit":
                    setSkillChoice(30, Properties.Resources.ifrit);
                    break;
                case "Chain Lightning":
                    setSkillChoice(30, Properties.Resources.chainLightning);
                    break;
                case "Blizzard":
                    setSkillChoice(30, Properties.Resources.blizzard);
                    break;
                case "Bahamut":
                    setSkillChoice(30, Properties.Resources.bahamut);
                    break;
                case "Angel Ray":
                    setSkillChoice(30, Properties.Resources.angelRay);
                    break;
                case "Genesis":
                    setSkillChoice(30, Properties.Resources.genesis);
                    break;
            }
        }

        private void setSkillChoice(int max, Image skillImage)
        {
            LUKlabel.Visible = false;
            LUKbox.Visible = false;
            LUKbox.ReadOnly = true;
            numMobs.Visible = false;
            numMobsValue.Visible = false;
            skillRank.Value = 1;
            skillRank.Maximum = max;
            skillRank.Minimum = 1;
            skillPicture.Image = skillImage;
        }



        private void CalcButton_MouseClick(object sender, MouseEventArgs e)
        {
            string? skillChoice = this.skillChoice.SelectedItem as string;
            skillChoice ??= "Energy Bolt";

            maxValue.Text = calculateMax(int.Parse(intBox.Text), int.Parse(magicBox.Text), skillChoice).ToString("F1");
            minValue.Text = calculateMin(int.Parse(intBox.Text), int.Parse(magicBox.Text), skillChoice).ToString("F1");
        }

        private double calculateMax(double INT, double MAGIC, string SKILL)
        {
            if (SKILL.Equals("Heal"))
            {
                return maxHealCalculation(INT, MAGIC, double.Parse(LUKbox.Text), (int)numMobsValue.Value);
            }
            if (Constants.skillMapping.TryGetValue(SKILL, out SkillSet skillSet))
            {
                // Perform the calculation once using the appropriate object from the dictionary
                return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * skillSet.ranks[(int)skillRank.Value - 1].magicDamage;
            }
            return 0;
        }


        private double calculateMin(double INT, double MAGIC, String SKILL)
        {
            if (SKILL.Equals("Heal"))
            {
                return minHealCalculation(INT, MAGIC, double.Parse(LUKbox.Text), (int)numMobsValue.Value);
            }
            if (Constants.skillMapping.TryGetValue(SKILL, out SkillSet skillSet))
            {

                return ((((MAGIC * MAGIC) / 1000 + MAGIC * (skillSet.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * skillSet.ranks[(int)skillRank.Value - 1].magicDamage);

            }
            return 0;
        }
        
        private double maxHealCalculation(double INT, double MAGIC, double LUK, int targetNum)
        {
            return ((INT * 1.2 + LUK) * MAGIC / 1000) * (1.5 + 5/(targetNum + 1));
        }

        private double minHealCalculation(double INT, double MAGIC, double LUK, int targetNum)
        {
            return ((INT * 0.3 + LUK) * MAGIC / 1000) * (1.5 +5 /targetNum + 1);
        }

        //Ensure only integers can be input into the input boxes
        private void intBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Reject the input
            }
        }
    }
}
