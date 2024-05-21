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
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 20; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.energyBolt;
                    break;
                case "Magic Claw":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 20; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.magicClaw;
                    break;
                case "Fire Arrow":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.fireArrow;
                    break;
                case "Poison Brace":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.poisonBrace;
                    break;
                case "Cold Beam":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.coldBeam;
                    break;
                case "Thunderbolt":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.thunderbolt;
                    break;
                case "Holy Arrow":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.holyArrow;
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
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.explosion;
                    break;
                case "Poison Mist":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.poisonMist;
                    break;
                case "Element Composition":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.elementalComposition;
                    break;
                case "Ice Strike":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.iceStrike;
                    break;
                case "Thunder Spear":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.thunderSpear;
                    break;
                case "Shining Ray":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.shiningRay;
                    break;
                case "Fire Demon":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.fireDemon;
                    break;
                case "Elquines":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.elquines;
                    break;
                case "Paralyze":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.paralyze;
                    break;
                case "Meteor Shower":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.meteorShower;
                    break;
                case "Ice Demon":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.iceDemon;
                    break;
                case "Ifrit":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.ifrit;
                    break;
                case "Chain Lightning":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.chainLightning;
                    break;
                case "Blizzard":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.blizzard;
                    break;
                case "Bahamut":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.bahamut;
                    break;
                case "Angel Ray":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.angelRay;
                    break;
                case "Genesis":
                    LUKlabel.Visible = false;
                    LUKbox.Visible = false;
                    LUKbox.ReadOnly = true;
                    numMobs.Visible = false;
                    numMobsValue.Visible = false;
                    skillRank.Value = 1;
                    skillRank.Maximum = 30; skillRank.Minimum = 1;
                    skillPicture.Image = Properties.Resources.genesis;
                    break;
            }
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
            switch (SKILL)
            {
                case "Energy Bolt":
                    EnergyBolt energyBolt = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * energyBolt.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Magic Claw":
                    MagicClaw magicClaw = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * magicClaw.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Fire Arrow":
                    FireArrow fireArrow = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * fireArrow.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Poison Brace":
                    PoisonBrace poisonBrace = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * poisonBrace.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Cold Beam":
                    ColdBeam coldBeam = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * coldBeam.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Thunderbolt":
                    ThunderBolt thunderbolt = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * thunderbolt.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Holy Arrow":
                    HolyArrow holyArrow = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * holyArrow.ranks[(int)skillRank.Value - 1].magicDamage;

                //will do this at the end due to external infomation (LUK) required
                case "Heal":  
                    return maxHealCalculation(INT, MAGIC, double.Parse(LUKbox.Text), (int)numMobsValue.Value);

                case "Explosion":
                    Explosion explosion = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * explosion.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Poison Mist":
                    PoisonMist poisonMist = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * poisonMist.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Element Composition":
                    ElementComposition elementComposition = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * elementComposition.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Ice Strike":
                    IceStrike iceStrike = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * iceStrike.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Thunder Spear":
                    ThunderSpear thunderSpear = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * thunderSpear.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Shining Ray":
                    ShiningRay shiningRay = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * shiningRay.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Fire Demon":
                    FireDemon fireDemon = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * fireDemon.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Elquines":
                    Elquines elquines = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * elquines.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Paralyze":
                    Paralyze paralyze = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * paralyze.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Meteor Shower":
                    MeteorShower meteorShower = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * meteorShower.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Ice Demon":
                    IceDemon iceDemon = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * iceDemon.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Ifrit":
                    Ifrit ifrit = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * ifrit.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Chain Lightning":
                    ChainLightning chainLightning = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * chainLightning.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Blizzard":
                    Blizzard blizzard = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * blizzard.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Bahamut":
                    Bahamut bahamut = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * bahamut.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Angel Ray":
                    AngelRay angelRay = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * angelRay.ranks[(int)skillRank.Value - 1].magicDamage;

                case "Genesis":
                    Genesis genesis = new();
                    return (((MAGIC * MAGIC) / 1000 + MAGIC) / 30 + INT / 200) * genesis.ranks[(int)skillRank.Value - 1].magicDamage;
            }
            return 0;
        }

        private double calculateMin(double INT, double MAGIC, String SKILL)
        {
            switch (SKILL)
            {
                case "Energy Bolt":
                    EnergyBolt energyBolt = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (energyBolt.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * energyBolt.ranks[(int)skillRank.Value - 1].magicDamage);

                case "Magic Claw":
                    MagicClaw magicClaw = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (magicClaw.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * magicClaw.ranks[(int)skillRank.Value - 1].magicDamage);
                
                case "Fire Arrow":
                    FireArrow fireArrow = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (fireArrow.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * fireArrow.ranks[(int)skillRank.Value - 1].magicDamage);
                
                case "Poison Brace":
                    PoisonBrace poisonBrace = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (poisonBrace.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * poisonBrace.ranks[(int)skillRank.Value - 1].magicDamage);
                
                case "Cold Beam":
                    ColdBeam coldBeam = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (coldBeam.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * coldBeam.ranks[(int)skillRank.Value - 1].magicDamage);
                
                case "Thunderbolt":
                    ThunderBolt thunderbolt = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (thunderbolt.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * thunderbolt.ranks[(int)skillRank.Value - 1].magicDamage);

                case "Holy Arrow":
                    HolyArrow holyArrow = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (holyArrow.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * holyArrow.ranks[(int)skillRank.Value - 1].magicDamage);

                //will do this at the end due to external infomation (LUK) required
                case "Heal":
                   return minHealCalculation(INT, MAGIC, double.Parse(LUKbox.Text), (int)numMobsValue.Value);

                case "Explosion":
                    Explosion explosion = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (explosion.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * explosion.ranks[(int)skillRank.Value - 1].magicDamage);
                
                case "Poison Mist":
                    PoisonMist poisonMist = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (poisonMist.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * poisonMist.ranks[(int)skillRank.Value - 1].magicDamage);

                case "Element Composition":
                    ElementComposition elementComposition = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (elementComposition.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * elementComposition.ranks[(int)skillRank.Value - 1].magicDamage);
                case "Ice Strike":
                    IceStrike iceStrike = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (iceStrike.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * iceStrike.ranks[(int)skillRank.Value - 1].magicDamage);
                case "Thunder Spear":
                    ThunderSpear thunderSpear = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (thunderSpear.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * thunderSpear.ranks[(int)skillRank.Value - 1].magicDamage);
                case "Shining Ray":
                    ShiningRay shiningRay = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (shiningRay.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * shiningRay.ranks[(int)skillRank.Value - 1].magicDamage);
                case "Fire Demon":
                    FireDemon fireDemon = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (fireDemon.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * fireDemon.ranks[(int)skillRank.Value - 1].magicDamage);
                case "Elquines":
                    Elquines elquines = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (elquines.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * elquines.ranks[(int)skillRank.Value - 1].magicDamage);
                case "Paralyze":
                    Paralyze paralyze = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (paralyze.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * paralyze.ranks[(int)skillRank.Value - 1].magicDamage);
                case "Meteor Shower":
                    MeteorShower meteorShower = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (meteorShower.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * meteorShower.ranks[(int)skillRank.Value - 1].magicDamage);
                case "Ice Demon":
                    IceDemon iceDemon = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (iceDemon.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * iceDemon.ranks[(int)skillRank.Value - 1].magicDamage);
                case "Ifrit":
                    Ifrit ifrit = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (ifrit.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * ifrit.ranks[(int)skillRank.Value - 1].magicDamage);
                case "Chain Lightning":
                    ChainLightning chainLightning = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (chainLightning.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * chainLightning.ranks[(int)skillRank.Value - 1].magicDamage);
                case "Blizzard":
                    Blizzard blizzard = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (blizzard.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * blizzard.ranks[(int)skillRank.Value - 1].magicDamage);
                case "Bahamut":
                    Bahamut bahamut = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (bahamut.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * bahamut.ranks[(int)skillRank.Value - 1].magicDamage);
                case "Angel Ray":
                    AngelRay angelRay = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (angelRay.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * angelRay.ranks[(int)skillRank.Value - 1].magicDamage);
                case "Genesis":
                    Genesis genesis = new();
                    return ((((MAGIC * MAGIC) / 1000 + MAGIC * (genesis.ranks[(int)skillRank.Value - 1].masteryPercent / 100) * 0.9) / 30 + INT / 200) * genesis.ranks[(int)skillRank.Value - 1].magicDamage);
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
