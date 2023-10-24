using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi05
{
    class Donthuc
    {
        private int heso;
        private int mu;
        private Donthuc next = null;
        private Donthuc previous = null;

        public int Heso
        {
            get { return heso; }
            set { heso = value; }
        }
        public int Mu
        {
            get { return mu; }
            set { mu = value; }
        }
        public Donthuc Next
        {
            get { return next; }
            set { next = value; }
        }
        public Donthuc Previous
        {
            get { return previous; }
            set { previous = value; }
        }

        public Donthuc() { }
        public Donthuc(int hs, int m)
        {
            Heso = hs;
            Mu = m;
            Next = null;
            Previous = null;
        }
        public Donthuc(Donthuc dt)
        {
            Heso = dt.Heso;
            Mu = dt.Mu;
            Next = null;
            Previous = null;
        }
    }
    class Dathuc
    {
        private Donthuc first = null;
        private Donthuc last = null;
        private int count = 0;

        public Donthuc First { get; set; }
        public Donthuc Last { get; set; }

        public bool IsEmpty()
        {
            return first == null;
        }

        public void AddDonthuc(int hs, int m)
        {
            Donthuc dt = new Donthuc(hs, m);

            if (IsEmpty())
            {
                first = last = dt;
            }
            else
            {
                last.Next = dt;
                dt.Previous = last;
                last = dt;
            }
            count++;
        }
        public void AddDonthuc(Donthuc ps)
        {
            //Donthuc dt = new Donthuc(hs, m);

            if (IsEmpty())
            {
                first = last = ps;
            }
            else
            {
                last.Next = ps;
                ps.Previous = last;
                last = ps;
            }
            count++;
        }

        public void Input()
        {
            Console.WriteLine("Nhap don thuc:  ");

            int sel;
            do
            {
                Console.Write("He so:  ");
                int hs = int.Parse(Console.ReadLine());
                Console.Write("So mu:  ");
                int m = int.Parse(Console.ReadLine());

                AddDonthuc(hs, m);

                Console.WriteLine("Continue? [1] - Yes  ||  [0] - No");
                sel = int.Parse(Console.ReadLine());

                Console.WriteLine();
            } while (sel != 0);
        }
        public void Display()
        {
            SortDathuc();

            Donthuc p = first;
            while(p != null)
            {
                if (p.Next == null)
                {
                    //Console.Write(" + " + p.Heso + "x^" + p.Mu + " \n\n");
                    if (p.Heso < 0)
                    {
                        Console.Write(" - " + p.Heso + "x^" + p.Mu + " \n\n");
                    }
                    else
                    {
                        Console.Write(" + " + p.Heso + "x^" + p.Mu + " \n\n");
                    }
                }
                else if(p == first)
                {
                    Console.Write(p.Heso + "x^" + p.Mu);
                }
                else
                {
                    //Console.Write(p.Heso + "x^" + p.Mu + " + ");
                    if (p.Heso < 0)
                    {
                        p.Heso = -p.Heso;
                        Console.Write(" - " + p.Heso + "x^" + p.Mu);
                    }
                    else
                    {
                        Console.Write(" + " + p.Heso + "x^" + p.Mu);
                    }
                }

                p = p.Next;
            }
        }
        public void SortDathuc()
        {
            for (int i = 1; i <= count; i++)
            {
                Donthuc p = first;

                while (p != null && p.Next != null)
                {
                    if (p.Mu < p.Next.Mu)
                    {
                        SwapDonthuc(p, p.Next);
                    }

                    p = p.Next;
                }
            }
        }
        public void SwapDonthuc(Donthuc l, Donthuc r)
        {
            int tmp1 = l.Heso;
            l.Heso = r.Heso;
            r.Heso = tmp1;

            int tmp2 = l.Mu;
            l.Mu = r.Mu;
            r.Mu = tmp2;
        }

        public void SimplyDonthuc()
        {
            
        }
        public void RemoveDonthuc(Donthuc p)
        {
            Donthuc dtNext1 = p.Next;
            Donthuc dtNext2 = dtNext1.Next;

            p.Heso = dtNext1.Heso;
            p.Mu = dtNext1.Mu;
            p.Next = dtNext2;
            dtNext1.Next = null;
            count--;
        }
        public void SumDonthuc(string P, int x)
        {
            string[] s = P.Split('+');
            for (int i = 0; i < s.Length; i++)
            {
                string[] v = s[i].Split('X');
                int hs = int.Parse(v[0]);
                int mu = int.Parse(v[1]);
                AddDonthuc(hs, mu);
            }

            Donthuc p = first;
            double sum = 0;
            while (p!=null)
            {
                sum += p.Heso * Math.Pow(x, p.Mu);

                p = p.Next;
            }
        }
    }
}
