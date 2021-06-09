using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_ex1form
{
    class Dekanat
    {
        public string Specialty;
        public int Number;
        public string Group;

        public Dekanat(string g, int n, string sp)
        {
            Specialty = sp;
            Number = n;
            Group = g;

        }
        public string Writenew()
        {
            string sf;
        sf=($"Group:{Group} Number:{Number} Specialty:{Specialty} ");
            return sf;
        }
    }
    class Visiting //: Class
    {
        public string Surname;
        public int Pass;
        public int Greason;

        public Visiting(string s, int p, int gr)
        {
            Surname = s;
            Pass = p;
            Greason = gr;

        }
        public string Writenew()
        {
            string sg;
           sg=($"Surname:{Surname} Pass:{Pass} Greason:{Greason} ");
            return sg;
        }
        public int Subtract()
        {
             
            return Pass - Greason;
        }
        public int Subtract1()
        {
            int x;
            x = (Greason * 100) / Pass;
            return 100 - x;
        }
        public string Subtract2()
        {
            string y;
            if (Subtract() > 20)
            {
                y = "More then 20 hours!";
            }
            else
            {
                y = null;
            }
            return y;
        }
    }
}
