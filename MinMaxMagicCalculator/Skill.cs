using MinMaxMagicCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxMagicCalculator
{
    public static class Constants
    {
        public static readonly int[] masteryPercentsLv30 = [ 15, 15, 15, 20, 20, 20, 25, 25, 25, 30, 30, 30, 35, 35, 35, 
                                                         40, 40, 40, 45, 45, 45, 50, 50, 50, 55, 55, 55, 60, 60, 60 ];
        
        public static readonly int[] masteryPercentsLv20 = [ 15, 15, 20, 20, 25, 25, 30, 30, 35, 35,
                                                             40, 40, 45, 45, 50, 50, 55, 55, 60, 60 ];

        public static readonly Dictionary<string, SkillSet> skillMapping = new Dictionary<string, SkillSet>
            {
                { "Energy Bolt", new EnergyBolt() },
                { "Magic Claw", new MagicClaw() },
                { "Fire Arrow", new FireArrow() },
                { "Poison Brace", new PoisonBrace() },
                { "Cold Beam", new ColdBeam() },
                { "Thunderbolt", new ThunderBolt() },
                { "Holy Arrow", new HolyArrow() },
                { "Heal", null },
                { "Explosion", new Explosion() },
                { "PoisonMist", new PoisonMist() },
                { "Element Composition", new ElementComposition() },
                { "Ice Strike", new IceStrike() },
                { "Thunder Spear", new ThunderBolt() },
                { "Shining Ray", new ShiningRay() },
                { "Fire Demon", new FireDemon() },
                { "Elquines", new Elquines() },
                { "Paralyze", new Paralyze() },
                { "Meteor Shower", new MeteorShower() },
                { "Ice Demon", new IceDemon() },
                { "Ifrit", new Ifrit() },
                { "Chain Lightning", new ChainLightning() },
                { "Blizzard", new Blizzard() },
                { "Bahamut", new Bahamut() },
                { "Angel Ray", new AngelRay() },
                { "Genesis", new Genesis() }
            };
    }

    public struct Skill
    {
        public double masteryPercent;
        public double magicDamage;

        public Skill(int masteryPercent, int magicDamage)
        {
            this.masteryPercent = masteryPercent;
            this.magicDamage = magicDamage;
        }
    }

    public class SkillSet
    {
        public Skill[] ranks;
        public SkillSet(int rankCount, int[] masteryPercents, int[] magicDamages)
        {
            ranks = new Skill[rankCount];
            for (int i = 0; i < rankCount; i++)
            {
                ranks[i] = new Skill(masteryPercents[i], magicDamages[i]);
            }
        }
    }
    public class EnergyBolt : SkillSet
    {
        public EnergyBolt() : base(20,
            //Make these first arrays consts. 20 and 30 follow their own respective patterns
            Constants.masteryPercentsLv20,
            new int[] { 20, 21, 22, 23, 26, 27, 28, 31, 32, 35,
                        36, 39, 40, 43, 44, 47, 48, 51, 52, 55 })
        { }
    }

    public class MagicClaw : SkillSet
    {
        public MagicClaw() : base(20, 
            Constants.masteryPercentsLv20,
            new int[] { 11, 12, 13, 14, 16, 17, 18, 20, 21, 23, 
                        24, 26, 27, 29, 30, 32, 34, 36, 38, 40 })
        { }
    }


public class FireArrow : SkillSet
{
    public FireArrow() : base(30, 
        Constants.masteryPercentsLv30,
        new int[] { 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72, 75, 
                    78, 81, 84, 87, 90, 93, 96, 99, 102, 105, 108, 111, 114, 117, 120 })
    { }
}
public class PoisonBrace : SkillSet
{
    public PoisonBrace() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40,
                    42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68, 70 })
    { }
}

public class ColdBeam : SkillSet
{
    public ColdBeam() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52, 55, 
                    58, 61, 64, 67, 70, 73, 76, 79, 82, 85, 88, 91, 94, 97, 100 })
    { }
}
public class ThunderBolt : SkillSet
{
    public ThunderBolt() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32,
                    34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60 })
    { }
}public class HolyArrow : SkillSet
{

    public HolyArrow() : base(30,
        Constants.masteryPercentsLv30,
        new int[] {22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50,
               52, 54, 56, 58, 60, 62, 64, 66, 68, 70, 72, 74, 76, 78, 80 })
    { }
}
public class Explosion : SkillSet
{
    public Explosion() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 60, 64, 68, 71, 74, 77, 79, 81, 83, 86, 88, 90, 92, 94, 97, 99, 
                    101,  103, 105, 108, 110, 112, 114, 116, 119, 121, 123, 125, 127, 130 })
    { }
}
public class PoisonMist : SkillSet
{
    public PoisonMist() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60,
                    62, 64, 66, 68, 70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90 })
    { }
}

public class ElementComposition : SkillSet
{
    public ElementComposition() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 80, 84, 88, 92, 95, 98, 101, 104, 107, 110, 113, 116, 119, 
                    122, 124, 126, 128, 130, 132, 134, 136, 138, 140, 142, 144, 146, 147, 148, 149, 150 })
    { }
}

public class IceStrike : SkillSet
{
    public IceStrike() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 
                    62, 64, 66, 68, 70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90 }) 
    { }
}
public class ThunderSpear : SkillSet
{
    public ThunderSpear() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 80, 90, 95, 100, 104, 108, 111, 115, 118, 121, 124, 127, 130, 133, 135, 138, 
                    141, 143, 145, 148, 150, 153, 155, 157, 159, 162, 164, 166, 168, 170 }) 
    { }
}
public class ShiningRay : SkillSet
{
    public ShiningRay() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 60, 62, 64, 66, 68, 70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90, 
                    92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105 }) 
    { }
}
public class FireDemon : SkillSet
{
    public FireDemon() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 82, 84, 86, 88, 90, 92, 94, 96, 98, 100, 102, 104, 106, 108, 110, 
                    112, 114, 116, 118, 120, 122, 124, 126, 128, 130, 132, 134, 136, 138, 140 }) 
    { }
}
public class Elquines : SkillSet
{
    public Elquines() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 153, 156, 159, 162, 165, 168, 171, 174, 177, 180, 184, 188, 192, 
                    196, 200, 204, 208, 212, 216, 220, 225, 230, 235, 240, 245, 250, 255, 260, 265, 270 }) 
    { }
}
public class Paralyze : SkillSet
{
    public Paralyze() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 134, 138, 142, 146, 150, 154, 158, 162, 166, 170, 174, 178, 182, 186, 190, 
                    194, 198, 202, 206, 210, 213, 216, 219, 222, 225, 228, 231, 234, 237, 240 }) 
    { }
}
public class MeteorShower : SkillSet
{
    public MeteorShower() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 330, 340, 350, 360, 370, 380, 390, 400, 410, 420, 430, 440, 450, 460, 470, 480,
                    490, 500, 510, 520, 530, 540, 550, 560, 570, 580, 590, 600, 610, 620 }) 
    { }
}

public class IceDemon : SkillSet
{
    public IceDemon() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 62, 64, 66, 68, 70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90, 92, 94, 
                    96, 98, 100, 102, 104, 106, 108, 110, 112, 114, 116, 118, 120 }) 
    { }
}

public class Ifrit : SkillSet
{
    public Ifrit() : base(30, 
        Constants.masteryPercentsLv30,
        new int[] { 183, 186, 189, 192, 195, 198, 201, 204, 207, 210, 214, 218, 222, 226, 230, 234, 238,
                     242, 246, 250, 255, 260, 265, 270, 275, 280, 285, 290, 295, 300 }) { }
}

public class ChainLightning : SkillSet
{
    public ChainLightning() : base(30,
        Constants.masteryPercentsLv30,
        new int[] { 104, 108, 112, 116, 120, 124, 128, 132, 136, 140, 144, 148, 152, 156, 160, 164, 164, 
                    172, 176, 180, 183, 186, 189, 192, 195, 198, 201, 204, 207, 210 }) { }
}

public class Blizzard : SkillSet
{
    public Blizzard() : base(30, Constants.masteryPercentsLv30 , 
        new int[] { 330, 340, 350, 360, 370, 380, 390, 400, 410, 420, 430, 440, 450, 460, 470, 480, 
                    490, 500, 510, 520, 530, 540, 550, 560, 570, 580, 585, 590, 595, 600 }) 
    { }
}

public class Bahamut : SkillSet
{
    public Bahamut() : base(30, Constants.masteryPercentsLv30, 
        new int[] { 113, 116, 119, 122, 125, 128, 131, 134, 137, 140, 144, 148, 152, 156, 160,
                    164, 168, 172, 176, 180, 185, 190, 195, 200, 205, 210, 215, 220, 225, 230 }) 
    { }
}

public class AngelRay : SkillSet
{
    public AngelRay() : base(30, Constants.masteryPercentsLv30, 
        new int[] { 123, 126, 129, 132, 135, 138, 141, 144, 147, 150, 154, 158, 162, 166, 170, 174, 
                    174, 182, 186, 190, 195, 200, 205, 210, 215, 220, 225, 230, 235, 240 }) 
    { }
}

public class Genesis : SkillSet
{
    public Genesis() : base(30, Constants.masteryPercentsLv30, 
        new int[] { 430, 440, 450, 460, 470, 480, 490, 500, 510, 520, 530, 540, 550, 560, 570,
                    580, 590, 600, 610, 620, 625, 630, 635, 640, 645, 650, 655, 660, 665, 670 }) 
    { }
}


}



