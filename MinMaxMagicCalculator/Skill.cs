using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxMagicCalculator
{
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
    public class EnergyBolt
    {
        public Skill[] ranks;

        public EnergyBolt() { 
            ranks = new Skill[20];
            
            {
                ranks[0] = new Skill(15, 20);
                ranks[1] = new Skill(15, 21);
                ranks[2] = new Skill(20, 22);
                ranks[3] = new Skill(20, 23);
                ranks[4] = new Skill(25, 26);
                ranks[5] = new Skill(25, 27);
                ranks[6] = new Skill(30, 28);
                ranks[7] = new Skill(30, 31);
                ranks[8] = new Skill(35, 32);
                ranks[9] = new Skill(35, 35);
                ranks[10] = new Skill(40, 36);
                ranks[11] = new Skill(40, 39);
                ranks[12] = new Skill(45, 40);
                ranks[13] = new Skill(45, 43);
                ranks[14] = new Skill(50, 44);
                ranks[15] = new Skill(50, 47);
                ranks[16] = new Skill(55, 48);
                ranks[17] = new Skill(55, 51);
                ranks[18] = new Skill(60, 52);
                ranks[19] = new Skill(60, 55);
            };
        }
    }
    public class MagicClaw
    {
        public Skill[] ranks;

        public MagicClaw()
        {
            ranks = new Skill[20];

            {
                ranks[0] = new Skill(15, 11);
                ranks[1] = new Skill(15, 12);
                ranks[2] = new Skill(20, 13);
                ranks[3] = new Skill(20, 14);
                ranks[4] = new Skill(25, 16);
                ranks[5] = new Skill(25, 17);
                ranks[6] = new Skill(30, 18);
                ranks[7] = new Skill(30, 20);
                ranks[8] = new Skill(35, 21);
                ranks[9] = new Skill(35, 23);
                ranks[10] = new Skill(40, 24);
                ranks[11] = new Skill(40, 26);
                ranks[12] = new Skill(45, 27);
                ranks[13] = new Skill(45, 29);
                ranks[14] = new Skill(50, 30);
                ranks[15] = new Skill(50, 32);
                ranks[16] = new Skill(55, 34);
                ranks[17] = new Skill(55, 36);
                ranks[18] = new Skill(60, 38);
                ranks[19] = new Skill(60, 40);
            };
        }
    }

    public class FireArrow
    {
        public Skill[] ranks;

        public FireArrow()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 33);
                ranks[1] = new Skill(15, 36);
                ranks[2] = new Skill(15, 39);
                ranks[3] = new Skill(20, 42);
                ranks[4] = new Skill(20, 45);
                ranks[5] = new Skill(20, 48);
                ranks[6] = new Skill(25, 51);
                ranks[7] = new Skill(25, 54);
                ranks[8] = new Skill(25, 57);
                ranks[9] = new Skill(30, 60);
                ranks[10] = new Skill(30, 63);
                ranks[11] = new Skill(30, 66);
                ranks[12] = new Skill(35, 69);
                ranks[13] = new Skill(35, 72);
                ranks[14] = new Skill(35, 75);
                ranks[15] = new Skill(40, 78);
                ranks[16] = new Skill(40, 81);
                ranks[17] = new Skill(40, 84);
                ranks[18] = new Skill(45, 87);
                ranks[19] = new Skill(45, 90);
                ranks[20] = new Skill(45, 93);
                ranks[21] = new Skill(50, 96);
                ranks[22] = new Skill(50, 99);
                ranks[23] = new Skill(50, 102);
                ranks[24] = new Skill(55, 105);
                ranks[25] = new Skill(55, 108);
                ranks[26] = new Skill(55, 111);
                ranks[27] = new Skill(60, 114);
                ranks[28] = new Skill(60, 117);
                ranks[29] = new Skill(60, 120);
            };
        }
    }

    public class PoisonBrace
    {
        public Skill[] ranks;

        public PoisonBrace()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 12);
                ranks[1] = new Skill(15, 14);
                ranks[2] = new Skill(15, 16);
                ranks[3] = new Skill(20, 18);
                ranks[4] = new Skill(20, 20);
                ranks[5] = new Skill(20, 22);
                ranks[6] = new Skill(25, 24);
                ranks[7] = new Skill(25, 26);
                ranks[8] = new Skill(25, 28);
                ranks[9] = new Skill(30, 30);
                ranks[10] = new Skill(30, 32);
                ranks[11] = new Skill(30, 34);
                ranks[12] = new Skill(35, 36);
                ranks[13] = new Skill(35, 38);
                ranks[14] = new Skill(35, 40);
                ranks[15] = new Skill(40, 42);
                ranks[16] = new Skill(40, 44);
                ranks[17] = new Skill(40, 46);
                ranks[18] = new Skill(45, 48);
                ranks[19] = new Skill(45, 50);
                ranks[20] = new Skill(45, 52);
                ranks[21] = new Skill(50, 54);
                ranks[22] = new Skill(50, 56);
                ranks[23] = new Skill(50, 58);
                ranks[24] = new Skill(55, 60);
                ranks[25] = new Skill(55, 62);
                ranks[26] = new Skill(55, 64);
                ranks[27] = new Skill(60, 66);
                ranks[28] = new Skill(60, 68);
                ranks[29] = new Skill(60, 70);
            };
        }
    }
    public class ColdBeam
    {
        public Skill[] ranks;

        public ColdBeam()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 13);
                ranks[1] = new Skill(15, 16);
                ranks[2] = new Skill(15, 19);
                ranks[3] = new Skill(20, 22);
                ranks[4] = new Skill(20, 25);
                ranks[5] = new Skill(20, 28);
                ranks[6] = new Skill(25, 31);
                ranks[7] = new Skill(25, 34);
                ranks[8] = new Skill(25, 37);
                ranks[9] = new Skill(30, 40);
                ranks[10] = new Skill(30, 43);
                ranks[11] = new Skill(30, 46);
                ranks[12] = new Skill(35, 49);
                ranks[13] = new Skill(35, 52);
                ranks[14] = new Skill(35, 55);
                ranks[15] = new Skill(40, 58);
                ranks[16] = new Skill(40, 61);
                ranks[17] = new Skill(40, 64);
                ranks[18] = new Skill(45, 67);
                ranks[19] = new Skill(45, 70);
                ranks[20] = new Skill(45, 73);
                ranks[21] = new Skill(50, 76);
                ranks[22] = new Skill(50, 79);
                ranks[23] = new Skill(50, 82);
                ranks[24] = new Skill(55, 85);
                ranks[25] = new Skill(55, 88);
                ranks[26] = new Skill(55, 91);
                ranks[27] = new Skill(60, 94);
                ranks[28] = new Skill(60, 97);
                ranks[29] = new Skill(60, 100);
            };
        }
    }
    public class ThunderBolt
    {
        public Skill[] ranks;

        public ThunderBolt()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 2);
                ranks[1] = new Skill(15, 4);
                ranks[2] = new Skill(15, 6);
                ranks[3] = new Skill(20, 8);
                ranks[4] = new Skill(20, 10);
                ranks[5] = new Skill(20, 12);
                ranks[6] = new Skill(25, 14);
                ranks[7] = new Skill(25, 16);
                ranks[8] = new Skill(25, 18);
                ranks[9] = new Skill(30, 20);
                ranks[10] = new Skill(30, 22);
                ranks[11] = new Skill(30, 24);
                ranks[12] = new Skill(35, 26);
                ranks[13] = new Skill(35, 28);
                ranks[14] = new Skill(35, 30);
                ranks[15] = new Skill(40, 32);
                ranks[16] = new Skill(40, 34);
                ranks[17] = new Skill(40, 36);
                ranks[18] = new Skill(45, 38);
                ranks[19] = new Skill(45, 40);
                ranks[20] = new Skill(45, 42);
                ranks[21] = new Skill(50, 44);
                ranks[22] = new Skill(50, 46);
                ranks[23] = new Skill(50, 48);
                ranks[24] = new Skill(55, 50);
                ranks[25] = new Skill(55, 52);
                ranks[26] = new Skill(55, 54);
                ranks[27] = new Skill(60, 56);
                ranks[28] = new Skill(60, 58);
                ranks[29] = new Skill(60, 60);
            };
        }
    }
    public class HolyArrow
    {
        public Skill[] ranks;

        public HolyArrow()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 22);
                ranks[1] = new Skill(15, 24);
                ranks[2] = new Skill(15, 26);
                ranks[3] = new Skill(20, 28);
                ranks[4] = new Skill(20, 30);
                ranks[5] = new Skill(20, 32);
                ranks[6] = new Skill(25, 34);
                ranks[7] = new Skill(25, 36);
                ranks[8] = new Skill(25, 38);
                ranks[9] = new Skill(30, 40);
                ranks[10] = new Skill(30, 42);
                ranks[11] = new Skill(30, 44);
                ranks[12] = new Skill(35, 46);
                ranks[13] = new Skill(35, 48);
                ranks[14] = new Skill(35, 50);
                ranks[15] = new Skill(40, 52);
                ranks[16] = new Skill(40, 54);
                ranks[17] = new Skill(40, 56);
                ranks[18] = new Skill(45, 58);
                ranks[19] = new Skill(45, 60);
                ranks[20] = new Skill(45, 62);
                ranks[21] = new Skill(50, 64);
                ranks[22] = new Skill(50, 66);
                ranks[23] = new Skill(50, 68);
                ranks[24] = new Skill(55, 70);
                ranks[25] = new Skill(55, 72);
                ranks[26] = new Skill(55, 74);
                ranks[27] = new Skill(60, 76);
                ranks[28] = new Skill(60, 78);
                ranks[29] = new Skill(60, 80);
            };
        }
    }
    public class Explosion
    {
        public Skill[] ranks;

        public Explosion()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 60);
                ranks[1] = new Skill(15, 64);
                ranks[2] = new Skill(15, 68);
                ranks[3] = new Skill(20, 71);
                ranks[4] = new Skill(20, 74);
                ranks[5] = new Skill(20, 77);
                ranks[6] = new Skill(25, 79);
                ranks[7] = new Skill(25, 81);
                ranks[8] = new Skill(25, 83);
                ranks[9] = new Skill(30, 86);
                ranks[10] = new Skill(30, 88);
                ranks[11] = new Skill(30, 90);
                ranks[12] = new Skill(35, 92);
                ranks[13] = new Skill(35, 94);
                ranks[14] = new Skill(35, 97);
                ranks[15] = new Skill(40, 99);
                ranks[16] = new Skill(40, 101);
                ranks[17] = new Skill(40, 103);
                ranks[18] = new Skill(45, 105);
                ranks[19] = new Skill(45, 108);
                ranks[20] = new Skill(45, 110);
                ranks[21] = new Skill(50, 112);
                ranks[22] = new Skill(50, 114);
                ranks[23] = new Skill(50, 116);
                ranks[24] = new Skill(55, 119);
                ranks[25] = new Skill(55, 121);
                ranks[26] = new Skill(55, 123);
                ranks[27] = new Skill(60, 125);
                ranks[28] = new Skill(60, 127);
                ranks[29] = new Skill(60, 130);
            };
        }
    }
    public class PoisonMist
    {
        public Skill[] ranks;

        public PoisonMist()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 32);
                ranks[1] = new Skill(15, 34);
                ranks[2] = new Skill(15, 36);
                ranks[3] = new Skill(20, 38);
                ranks[4] = new Skill(20, 40);
                ranks[5] = new Skill(20, 42);
                ranks[6] = new Skill(25, 44);
                ranks[7] = new Skill(25, 46);
                ranks[8] = new Skill(25, 48);
                ranks[9] = new Skill(30, 50);
                ranks[10] = new Skill(30, 52);
                ranks[11] = new Skill(30, 54);
                ranks[12] = new Skill(35, 56);
                ranks[13] = new Skill(35, 58);
                ranks[14] = new Skill(35, 60);
                ranks[15] = new Skill(40, 62);
                ranks[16] = new Skill(40, 64);
                ranks[17] = new Skill(40, 66);
                ranks[18] = new Skill(45, 68);
                ranks[19] = new Skill(45, 70);
                ranks[20] = new Skill(45, 72);
                ranks[21] = new Skill(50, 74);
                ranks[22] = new Skill(50, 76);
                ranks[23] = new Skill(50, 78);
                ranks[24] = new Skill(55, 80);
                ranks[25] = new Skill(55, 82);
                ranks[26] = new Skill(55, 84);
                ranks[27] = new Skill(60, 86);
                ranks[28] = new Skill(60, 88);
                ranks[29] = new Skill(60, 90);
            };
        }
    }
    public class ElementComposition
    {
        public Skill[] ranks;

        public ElementComposition()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 80);
                ranks[1] = new Skill(15, 84);
                ranks[2] = new Skill(15, 88);
                ranks[3] = new Skill(20, 92);
                ranks[4] = new Skill(20, 95);
                ranks[5] = new Skill(20, 98);
                ranks[6] = new Skill(25, 101);
                ranks[7] = new Skill(25, 104);
                ranks[8] = new Skill(25, 107);
                ranks[9] = new Skill(30, 110);
                ranks[10] = new Skill(30, 113);
                ranks[11] = new Skill(30, 116);
                ranks[12] = new Skill(35, 119);
                ranks[13] = new Skill(35, 122);
                ranks[14] = new Skill(35, 124);
                ranks[15] = new Skill(40, 126);
                ranks[16] = new Skill(40, 128);
                ranks[17] = new Skill(40, 130);
                ranks[18] = new Skill(45, 132);
                ranks[19] = new Skill(45, 134);
                ranks[20] = new Skill(45, 136);
                ranks[21] = new Skill(50, 138);
                ranks[22] = new Skill(50, 140);
                ranks[23] = new Skill(50, 142);
                ranks[24] = new Skill(55, 144);
                ranks[25] = new Skill(55, 146);
                ranks[26] = new Skill(55, 147);
                ranks[27] = new Skill(60, 148);
                ranks[28] = new Skill(60, 149);
                ranks[29] = new Skill(60, 150);
            };
        }
    }
    public class IceStrike
    {
        public Skill[] ranks;

        public IceStrike()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 32);
                ranks[1] = new Skill(15, 34);
                ranks[2] = new Skill(15, 36);
                ranks[3] = new Skill(20, 38);
                ranks[4] = new Skill(20, 40);
                ranks[5] = new Skill(20, 42);
                ranks[6] = new Skill(25, 44);
                ranks[7] = new Skill(25, 46);
                ranks[8] = new Skill(25, 48);
                ranks[9] = new Skill(30, 50);
                ranks[10] = new Skill(30, 52);
                ranks[11] = new Skill(30, 54);
                ranks[12] = new Skill(35, 56);
                ranks[13] = new Skill(35, 58);
                ranks[14] = new Skill(35, 60);
                ranks[15] = new Skill(40, 62);
                ranks[16] = new Skill(40, 64);
                ranks[17] = new Skill(40, 66);
                ranks[18] = new Skill(45, 68);
                ranks[19] = new Skill(45, 70);
                ranks[20] = new Skill(45, 72);
                ranks[21] = new Skill(50, 74);
                ranks[22] = new Skill(50, 76);
                ranks[23] = new Skill(50, 78);
                ranks[24] = new Skill(55, 80);
                ranks[25] = new Skill(55, 82);
                ranks[26] = new Skill(55, 84);
                ranks[27] = new Skill(60, 86);
                ranks[28] = new Skill(60, 88);
                ranks[29] = new Skill(60, 90);
            };
        }
    }
    public class ThunderSpear
    {
        public Skill[] ranks;

        public ThunderSpear()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 80);
                ranks[1] = new Skill(15, 90);
                ranks[2] = new Skill(15, 95);
                ranks[3] = new Skill(20, 100);
                ranks[4] = new Skill(20, 104);
                ranks[5] = new Skill(20, 108);
                ranks[6] = new Skill(25, 111);
                ranks[7] = new Skill(25, 115);
                ranks[8] = new Skill(25, 118);
                ranks[9] = new Skill(30, 121);
                ranks[10] = new Skill(30, 124);
                ranks[11] = new Skill(30, 127);
                ranks[12] = new Skill(35, 130);
                ranks[13] = new Skill(35, 133);
                ranks[14] = new Skill(35, 135);
                ranks[15] = new Skill(40, 138);
                ranks[16] = new Skill(40, 141);
                ranks[17] = new Skill(40, 143);
                ranks[18] = new Skill(45, 145);
                ranks[19] = new Skill(45, 148);
                ranks[20] = new Skill(45, 150);
                ranks[21] = new Skill(50, 153);
                ranks[22] = new Skill(50, 155);
                ranks[23] = new Skill(50, 157);
                ranks[24] = new Skill(55, 159);
                ranks[25] = new Skill(55, 162);
                ranks[26] = new Skill(55, 164);
                ranks[27] = new Skill(60, 166);
                ranks[28] = new Skill(60, 168);
                ranks[29] = new Skill(60, 170);
            };
        }
    }
    public class ShiningRay
    {
        public Skill[] ranks;

        public ShiningRay()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 60);
                ranks[1] = new Skill(15, 62);
                ranks[2] = new Skill(15, 64);
                ranks[3] = new Skill(20, 66);
                ranks[4] = new Skill(20, 68);
                ranks[5] = new Skill(20, 70);
                ranks[6] = new Skill(25, 72);
                ranks[7] = new Skill(25, 74);
                ranks[8] = new Skill(25, 76);
                ranks[9] = new Skill(30, 78);
                ranks[10] = new Skill(30, 80);
                ranks[11] = new Skill(30, 82);
                ranks[12] = new Skill(35, 84);
                ranks[13] = new Skill(35, 86);
                ranks[14] = new Skill(35, 88);
                ranks[15] = new Skill(40, 90);
                ranks[16] = new Skill(40, 92);
                ranks[17] = new Skill(40, 93);
                ranks[18] = new Skill(45, 94);
                ranks[19] = new Skill(45, 95);
                ranks[20] = new Skill(45, 96);
                ranks[21] = new Skill(50, 97);
                ranks[22] = new Skill(50, 98);
                ranks[23] = new Skill(50, 99);
                ranks[24] = new Skill(55, 100);
                ranks[25] = new Skill(55, 101);
                ranks[26] = new Skill(55, 102);
                ranks[27] = new Skill(60, 103);
                ranks[28] = new Skill(60, 104);
                ranks[29] = new Skill(60, 105);
            };
        }
    }
    public class Heal
    {
        public Skill[] ranks;

        public Heal()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 22);
                ranks[1] = new Skill(15, 24);
                ranks[2] = new Skill(15, 26);
                ranks[3] = new Skill(20, 28);
                ranks[4] = new Skill(20, 30);
                ranks[5] = new Skill(20, 32);
                ranks[6] = new Skill(25, 34);
                ranks[7] = new Skill(25, 36);
                ranks[8] = new Skill(25, 38);
                ranks[9] = new Skill(30, 40);
                ranks[10] = new Skill(30, 42);
                ranks[11] = new Skill(30, 44);
                ranks[12] = new Skill(35, 46);
                ranks[13] = new Skill(35, 48);
                ranks[14] = new Skill(35, 50);
                ranks[15] = new Skill(40, 52);
                ranks[16] = new Skill(40, 54);
                ranks[17] = new Skill(40, 56);
                ranks[18] = new Skill(45, 58);
                ranks[19] = new Skill(45, 60);
                ranks[20] = new Skill(45, 62);
                ranks[21] = new Skill(50, 64);
                ranks[22] = new Skill(50, 66);
                ranks[23] = new Skill(50, 68);
                ranks[24] = new Skill(55, 70);
                ranks[25] = new Skill(55, 72);
                ranks[26] = new Skill(55, 74);
                ranks[27] = new Skill(60, 76);
                ranks[28] = new Skill(60, 78);
                ranks[29] = new Skill(60, 80);
            };
        }
    }
    public class FireDemon
    {
        public Skill[] ranks;

        public FireDemon()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 82);
                ranks[1] = new Skill(15, 84);
                ranks[2] = new Skill(15, 86);
                ranks[3] = new Skill(20, 88);
                ranks[4] = new Skill(20, 90);
                ranks[5] = new Skill(20, 92);
                ranks[6] = new Skill(25, 94);
                ranks[7] = new Skill(25, 96);
                ranks[8] = new Skill(25, 98);
                ranks[9] = new Skill(30, 100);
                ranks[10] = new Skill(30, 102);
                ranks[11] = new Skill(30, 104);
                ranks[12] = new Skill(35, 106);
                ranks[13] = new Skill(35, 108);
                ranks[14] = new Skill(35, 110);
                ranks[15] = new Skill(40, 112);
                ranks[16] = new Skill(40, 114);
                ranks[17] = new Skill(40, 116);
                ranks[18] = new Skill(45, 118);
                ranks[19] = new Skill(45, 120);
                ranks[20] = new Skill(45, 122);
                ranks[21] = new Skill(50, 124);
                ranks[22] = new Skill(50, 126);
                ranks[23] = new Skill(50, 128);
                ranks[24] = new Skill(55, 130);
                ranks[25] = new Skill(55, 132);
                ranks[26] = new Skill(55, 134);
                ranks[27] = new Skill(60, 136);
                ranks[28] = new Skill(60, 138);
                ranks[29] = new Skill(60, 140);
            };
        }
    }
    public class Elquines
    {
        public Skill[] ranks;

        public Elquines()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 153);
                ranks[1] = new Skill(15, 156);
                ranks[2] = new Skill(15, 159);
                ranks[3] = new Skill(20, 162);
                ranks[4] = new Skill(20, 165);
                ranks[5] = new Skill(20, 168);
                ranks[6] = new Skill(25, 171);
                ranks[7] = new Skill(25, 174);
                ranks[8] = new Skill(25, 177);
                ranks[9] = new Skill(30, 180);
                ranks[10] = new Skill(30, 184);
                ranks[11] = new Skill(30, 188);
                ranks[12] = new Skill(35, 192);
                ranks[13] = new Skill(35, 196);
                ranks[14] = new Skill(35, 200);
                ranks[15] = new Skill(40, 204);
                ranks[16] = new Skill(40, 208);
                ranks[17] = new Skill(40, 212);
                ranks[18] = new Skill(45, 216);
                ranks[19] = new Skill(45, 220);
                ranks[20] = new Skill(45, 225);
                ranks[21] = new Skill(50, 230);
                ranks[22] = new Skill(50, 235);
                ranks[23] = new Skill(50, 240);
                ranks[24] = new Skill(55, 245);
                ranks[25] = new Skill(55, 250);
                ranks[26] = new Skill(55, 255);
                ranks[27] = new Skill(60, 260);
                ranks[28] = new Skill(60, 265);
                ranks[29] = new Skill(60, 270);
            };
        }
    }
    public class Paralyze
    {
        public Skill[] ranks;

        public Paralyze()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 134);
                ranks[1] = new Skill(15, 138);
                ranks[2] = new Skill(15, 142);
                ranks[3] = new Skill(20, 146);
                ranks[4] = new Skill(20, 150);
                ranks[5] = new Skill(20, 154);
                ranks[6] = new Skill(25, 158);
                ranks[7] = new Skill(25, 162);
                ranks[8] = new Skill(25, 166);
                ranks[9] = new Skill(30, 170);
                ranks[10] = new Skill(30, 174);
                ranks[11] = new Skill(30, 178);
                ranks[12] = new Skill(35, 182);
                ranks[13] = new Skill(35, 186);
                ranks[14] = new Skill(35, 190);
                ranks[15] = new Skill(40, 194);
                ranks[16] = new Skill(40, 198);
                ranks[17] = new Skill(40, 202);
                ranks[18] = new Skill(45, 206);
                ranks[19] = new Skill(45, 210);
                ranks[20] = new Skill(45, 213);
                ranks[21] = new Skill(50, 216);
                ranks[22] = new Skill(50, 219);
                ranks[23] = new Skill(50, 222);
                ranks[24] = new Skill(55, 225);
                ranks[25] = new Skill(55, 228);
                ranks[26] = new Skill(55, 231);
                ranks[27] = new Skill(60, 234);
                ranks[28] = new Skill(60, 237);
                ranks[29] = new Skill(60, 240);
            };
        }
    }
    public class MeteorShower
    {
        public Skill[] ranks;

        public MeteorShower()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(100, 330);
                ranks[1] = new Skill(100, 340);
                ranks[2] = new Skill(100, 350);
                ranks[3] = new Skill(100, 360);
                ranks[4] = new Skill(100, 370);
                ranks[5] = new Skill(100, 380);
                ranks[6] = new Skill(100, 390);
                ranks[7] = new Skill(100, 400);
                ranks[8] = new Skill(100, 410);
                ranks[9] = new Skill(100, 420);
                ranks[10] = new Skill(100, 430);
                ranks[11] = new Skill(100, 440);
                ranks[12] = new Skill(100, 450);
                ranks[13] = new Skill(100, 460);
                ranks[14] = new Skill(100, 470);
                ranks[15] = new Skill(100, 480);
                ranks[16] = new Skill(100, 490);
                ranks[17] = new Skill(100, 500);
                ranks[18] = new Skill(100, 510);
                ranks[19] = new Skill(100, 520);
                ranks[20] = new Skill(100, 530);
                ranks[21] = new Skill(100, 540);
                ranks[22] = new Skill(100, 550);
                ranks[23] = new Skill(100, 560);
                ranks[24] = new Skill(100, 570);
                ranks[25] = new Skill(100, 580);
                ranks[26] = new Skill(100, 590);
                ranks[27] = new Skill(100, 600);
                ranks[28] = new Skill(100, 610);
                ranks[29] = new Skill(100, 620);
            };
        }
    }
    public class IceDemon
    {
        public Skill[] ranks;

        public IceDemon()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 62);
                ranks[1] = new Skill(15, 64);
                ranks[2] = new Skill(15, 66);
                ranks[3] = new Skill(20, 68);
                ranks[4] = new Skill(20, 70);
                ranks[5] = new Skill(20, 72);
                ranks[6] = new Skill(25, 74);
                ranks[7] = new Skill(25, 76);
                ranks[8] = new Skill(25, 78);
                ranks[9] = new Skill(30, 80);
                ranks[10] = new Skill(30, 82);
                ranks[11] = new Skill(30, 84);
                ranks[12] = new Skill(35, 86);
                ranks[13] = new Skill(35, 88);
                ranks[14] = new Skill(35, 90);
                ranks[15] = new Skill(40, 92);
                ranks[16] = new Skill(40, 94);
                ranks[17] = new Skill(40, 96);
                ranks[18] = new Skill(45, 98);
                ranks[19] = new Skill(45, 100);
                ranks[20] = new Skill(45, 102);
                ranks[21] = new Skill(50, 104);
                ranks[22] = new Skill(50, 106);
                ranks[23] = new Skill(50, 108);
                ranks[24] = new Skill(55, 110);
                ranks[25] = new Skill(55, 112);
                ranks[26] = new Skill(55, 114);
                ranks[27] = new Skill(60, 116);
                ranks[28] = new Skill(60, 118);
                ranks[29] = new Skill(60, 120);
            };
        }
    }
    public class Ifrit
    {
        public Skill[] ranks;

        public Ifrit()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 183);
                ranks[1] = new Skill(15, 186);
                ranks[2] = new Skill(15, 189);
                ranks[3] = new Skill(20, 192);
                ranks[4] = new Skill(20, 195);
                ranks[5] = new Skill(20, 198);
                ranks[6] = new Skill(25, 201);
                ranks[7] = new Skill(25, 204);
                ranks[8] = new Skill(25, 207);
                ranks[9] = new Skill(30, 210);
                ranks[10] = new Skill(30, 214);
                ranks[11] = new Skill(30, 218);
                ranks[12] = new Skill(35, 222);
                ranks[13] = new Skill(35, 226);
                ranks[14] = new Skill(35, 230);
                ranks[15] = new Skill(40, 234);
                ranks[16] = new Skill(40, 238);
                ranks[17] = new Skill(40, 242);
                ranks[18] = new Skill(45, 246);
                ranks[19] = new Skill(45, 250);
                ranks[20] = new Skill(45, 255);
                ranks[21] = new Skill(50, 260);
                ranks[22] = new Skill(50, 265);
                ranks[23] = new Skill(50, 270);
                ranks[24] = new Skill(55, 275);
                ranks[25] = new Skill(55, 280);
                ranks[26] = new Skill(55, 285);
                ranks[27] = new Skill(60, 290);
                ranks[28] = new Skill(60, 295);
                ranks[29] = new Skill(60, 300);
            };
        }
    }
    public class ChainLightning
    {
        public Skill[] ranks;

        public ChainLightning()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 104);
                ranks[1] = new Skill(15, 108);
                ranks[2] = new Skill(15, 112);
                ranks[3] = new Skill(20, 116);
                ranks[4] = new Skill(20, 120);
                ranks[5] = new Skill(20, 124);
                ranks[6] = new Skill(25, 128);
                ranks[7] = new Skill(25, 132);
                ranks[8] = new Skill(25, 136);
                ranks[9] = new Skill(30, 140);
                ranks[10] = new Skill(30, 144);
                ranks[11] = new Skill(30, 148);
                ranks[12] = new Skill(35, 152);
                ranks[13] = new Skill(35, 156);
                ranks[14] = new Skill(35, 160);
                ranks[15] = new Skill(40, 164);
                ranks[16] = new Skill(40, 164);
                ranks[17] = new Skill(40, 172);
                ranks[18] = new Skill(45, 176);
                ranks[19] = new Skill(45, 180);
                ranks[20] = new Skill(45, 183);
                ranks[21] = new Skill(50, 186);
                ranks[22] = new Skill(50, 189);
                ranks[23] = new Skill(50, 192);
                ranks[24] = new Skill(55, 195);
                ranks[25] = new Skill(55, 198);
                ranks[26] = new Skill(55, 201);
                ranks[27] = new Skill(60, 204);
                ranks[28] = new Skill(60, 207);
                ranks[29] = new Skill(60, 210);
            };
        }
    }
    public class Blizzard
    {
        public Skill[] ranks;

        public Blizzard()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(100, 330);
                ranks[1] = new Skill(100, 340);
                ranks[2] = new Skill(100, 350);
                ranks[3] = new Skill(100, 360);
                ranks[4] = new Skill(100, 370);
                ranks[5] = new Skill(100, 380);
                ranks[6] = new Skill(100, 390);
                ranks[7] = new Skill(100, 400);
                ranks[8] = new Skill(100, 410);
                ranks[9] = new Skill(100, 420);
                ranks[10] = new Skill(100, 430);
                ranks[11] = new Skill(100, 440);
                ranks[12] = new Skill(100, 450);
                ranks[13] = new Skill(100, 460);
                ranks[14] = new Skill(100, 470);
                ranks[15] = new Skill(100, 480);
                ranks[16] = new Skill(100, 490);
                ranks[17] = new Skill(100, 500);
                ranks[18] = new Skill(100, 510);
                ranks[19] = new Skill(100, 520);
                ranks[20] = new Skill(100, 530);
                ranks[21] = new Skill(100, 540);
                ranks[22] = new Skill(100, 550);
                ranks[23] = new Skill(100, 560);
                ranks[24] = new Skill(100, 570);
                ranks[25] = new Skill(100, 580);
                ranks[26] = new Skill(100, 585);
                ranks[27] = new Skill(100, 590);
                ranks[28] = new Skill(100, 595);
                ranks[29] = new Skill(100, 600);
            };
        }
    }
    public class Bahamut
    {
        public Skill[] ranks;

        public Bahamut()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(100, 113);
                ranks[1] = new Skill(100, 116);
                ranks[2] = new Skill(100, 119);
                ranks[3] = new Skill(100, 122);
                ranks[4] = new Skill(100, 125);
                ranks[5] = new Skill(100, 128);
                ranks[6] = new Skill(100, 131);
                ranks[7] = new Skill(100, 134);
                ranks[8] = new Skill(100, 137);
                ranks[9] = new Skill(100, 140);
                ranks[10] = new Skill(100, 144);
                ranks[11] = new Skill(100, 148);
                ranks[12] = new Skill(100, 152);
                ranks[13] = new Skill(100, 156);
                ranks[14] = new Skill(100, 160);
                ranks[15] = new Skill(100, 164);
                ranks[16] = new Skill(100, 168);
                ranks[17] = new Skill(100, 172);
                ranks[18] = new Skill(100, 176);
                ranks[19] = new Skill(100, 180);
                ranks[20] = new Skill(100, 185);
                ranks[21] = new Skill(100, 190);
                ranks[22] = new Skill(100, 195);
                ranks[23] = new Skill(100, 200);
                ranks[24] = new Skill(100, 205);
                ranks[25] = new Skill(100, 210);
                ranks[26] = new Skill(100, 215);
                ranks[27] = new Skill(100, 220);
                ranks[28] = new Skill(100, 225);
                ranks[29] = new Skill(100, 230);
            };
        }
    }
    public class AngelRay
    {
        public Skill[] ranks;

        public AngelRay()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(15, 123);
                ranks[1] = new Skill(15, 126);
                ranks[2] = new Skill(15, 129);
                ranks[3] = new Skill(20, 132);
                ranks[4] = new Skill(20, 135);
                ranks[5] = new Skill(20, 138);
                ranks[6] = new Skill(25, 141);
                ranks[7] = new Skill(25, 144);
                ranks[8] = new Skill(25, 147);
                ranks[9] = new Skill(30, 150);
                ranks[10] = new Skill(30, 154);
                ranks[11] = new Skill(30, 158);
                ranks[12] = new Skill(35, 162);
                ranks[13] = new Skill(35, 166);
                ranks[14] = new Skill(35, 170);
                ranks[15] = new Skill(40, 174);
                ranks[16] = new Skill(40, 174);
                ranks[17] = new Skill(40, 182);
                ranks[18] = new Skill(45, 186);
                ranks[19] = new Skill(45, 190);
                ranks[20] = new Skill(45, 195);
                ranks[21] = new Skill(50, 200);
                ranks[22] = new Skill(50, 205);
                ranks[23] = new Skill(50, 210);
                ranks[24] = new Skill(55, 215);
                ranks[25] = new Skill(55, 220);
                ranks[26] = new Skill(55, 225);
                ranks[27] = new Skill(60, 230);
                ranks[28] = new Skill(60, 235);
                ranks[29] = new Skill(60, 240);
            };
        }
    }
    public class Genesis
    {
        public Skill[] ranks;

        public Genesis()
        {
            ranks = new Skill[30];

            {
                ranks[0] = new Skill(100, 430);
                ranks[1] = new Skill(100, 440);
                ranks[2] = new Skill(100, 450);
                ranks[3] = new Skill(100, 460);
                ranks[4] = new Skill(100, 470);
                ranks[5] = new Skill(100, 480);
                ranks[6] = new Skill(100, 490);
                ranks[7] = new Skill(100, 500);
                ranks[8] = new Skill(100, 510);
                ranks[9] = new Skill(100, 520);
                ranks[10] = new Skill(100, 530);
                ranks[11] = new Skill(100, 540);
                ranks[12] = new Skill(100, 550);
                ranks[13] = new Skill(100, 560);
                ranks[14] = new Skill(100, 570);
                ranks[15] = new Skill(100, 580);
                ranks[16] = new Skill(100, 590);
                ranks[17] = new Skill(100, 600);
                ranks[18] = new Skill(100, 610);
                ranks[19] = new Skill(100, 620);
                ranks[20] = new Skill(100, 625);
                ranks[21] = new Skill(100, 630);
                ranks[22] = new Skill(100, 635);
                ranks[23] = new Skill(100, 640);
                ranks[24] = new Skill(100, 645);
                ranks[25] = new Skill(100, 650);
                ranks[26] = new Skill(100, 655);
                ranks[27] = new Skill(100, 660);
                ranks[28] = new Skill(100, 665);
                ranks[29] = new Skill(100, 670);
            };
        }
    }
}




