using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Test
{
    class HerniPostava
    {
        protected string jmeno;
        protected int level = 1;
        protected int poziceX = 0;
        protected int poziceY = 0;
        
        public string Jmeno
        {
            get { return jmeno; }
            set
            {
                if(value.Length > 10)
                {
                    MessageBox.Show("Jméńo je příliš dlouhé, zadejte prosím jiné.");
                }
                else
                {
                    jmeno = value;
                }
            }
        }
        public int PoziceX { get { return poziceX; } }
        public int PoziceY { get { return poziceY; } }
        public HerniPostava(string jmeno)
        {
            this.Jmeno = jmeno;
        }

        public virtual void ZmenaPozice()
        {
            poziceX = Cursor.Position.X;
            poziceY = Cursor.Position.Y;
        }
        public override string ToString()
        {
            return "Jméno: " + this.jmeno + "\nLevel: " + this.level;
        }
    }
}
