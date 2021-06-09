using System;

namespace interface23
{
    class Program
    {

        /*  abstract class Class
          {
              public string GName;
              public Class(string gn)
              {
                  GName = gn;
              }
          }*/
        class Dekanat //: Class
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
            public void Writenew()
            {
                Console.WriteLine($"Group:{Group} Number:{Number} Specialty:{Specialty} ");
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
            public void Writenew()
            {
                Console.WriteLine($"Surname:{Surname} Pass:{Pass} Greason:{Greason} ");
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
        //static void Main(string[] args)
        //{
        //    Dekanat group = new Dekanat("PMa-21", 4, "System analysis");
        //    Visiting visiting = new Visiting("Shevchuk", 200, 2);
        //    Visiting visiting2 = new Visiting("Bereziak", 3, 2);
        //    Visiting visiting3 = new Visiting("Boretska", 59, 2);
        //    Visiting visiting4 = new Visiting("Babiy", 1, 1);

        //    int a = visiting.Subtract();

        //    int b = visiting2.Subtract();
        //    int d = visiting3.Subtract();
        //    int f = visiting4.Subtract();
        //    int a1 = visiting.Subtract1();
        //    int b1 = visiting2.Subtract1();
        //    int d1 = visiting3.Subtract1();
        //    int f1 = visiting4.Subtract1();
        //    string a2 = visiting.Subtract2();
        //    string b2 = visiting2.Subtract2();
        //    string d2 = visiting3.Subtract2();
        //    string f2 = visiting4.Subtract2();
        //    group.Writenew();
        //    visiting.Writenew();
        //    visiting2.Writenew();
        //    visiting3.Writenew();
        //    visiting4.Writenew();
        //    Console.WriteLine($"Pass without reason:{a} - {a1}% {a2}");
        //    Console.WriteLine($"Pass without reason:{b} - {b1}% {b2}");
        //    Console.WriteLine($"Pass without reason:{d} - {d1}% {d2}");
        //    Console.WriteLine($"Pass without reason:{f} - {f1}% {f2}");



        //}

    }
}