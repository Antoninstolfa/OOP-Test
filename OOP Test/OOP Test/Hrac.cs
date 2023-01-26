using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Test
{
    
    class Hrac : HerniPostava
    {
        private int oblicej = 0;
        private int vlasy = 0;
        private int barvavlasu = 0;
        private string specializace;
        public int XP = 0;

        public string Specializace
        {
            get
            {
                return specializace;
            }
            set
            {
                if(specializace == "Kouzelník" || specializace == "Berserker" || specializace == "Inženýr" || specializace == "Cizák")
                {
                    specializace = value;
                }
                /*else
                {
                    MessageBox.Show("Tato specializace neexistuje, Vyberte si z nabídky níže:\nKouzelník,Berserker,Inženýr,Cizák");
                }*/
            }
        }
        public Hrac(string jmeno, string specializace, int oblicej, int vlasy, int barvavlasu) : base(jmeno)
        {
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barvavlasu = barvavlasu;
            this.Specializace = specializace;
        }

        public void PridejXP(int xp)
        {
            XP += xp;
            if(XP > 100 * level)
            {
                MessageBox.Show("Gratulace\nLevel se zvýšil!\n-------------------\nLevel: " + this.level);
                level++;
            }
        }

        public override string ToString()
        {
            return "Jméno: " + this.jmeno + "\nLevel: " + this.level + "\nObličej: " + this.oblicej + "\nVlasy: " + this.vlasy + "\nbarva vlasů: " + this.barvavlasu + "\nSpecializace: " + this.specializace;
        }
    }
}
