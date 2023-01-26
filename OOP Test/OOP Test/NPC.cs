using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test
{
    enum Prace
    {
        obchodník, nepřítel, obyvatel
    }
    class NPC : HerniPostava
    {
        public int prace;
        public int sila;
        public NPC(string jmeno, int prace, int sila) : base(jmeno)
        {
            this.prace = prace;
            this.sila = sila;
        }
        public NPC(string jmeno, int prace) : base(jmeno)
        {
            this.prace = prace;
        }

        public sealed override void ZmenaPozice()
        {
            poziceX = 100;
            poziceY = 100;
        }
        public override string ToString()
        {
            return "Jmeno: " + this.jmeno + "\nLevel: " + this.level + "\nPráce: " + this.prace + "\nSíla: " + this.sila;
        }
    }
}
