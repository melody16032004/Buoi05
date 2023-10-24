using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi05
{
    class Phanso
    {
        #region
        private int tu = 1;
        private int mau = 1;
        private Phanso next = null;
        private Phanso previous = null;

        public int Tu
        {
            get { return tu; }
            set { tu = value; }
        }
        public int Mau
        {
            get { return mau; }
            set { mau = value; }
        }
        public Phanso Next
        {
            get { return next; }
            set { next = value; }
        }
        public Phanso Previous
        {
            get { return previous; }
            set { previous = value; }
        }

        public Phanso() { }
        public Phanso(int t, int m)
        {
            Tu = t;
            Mau = m;
            Next = null;
            Previous = null;
        }
        public float Ps_Value(int t, int m)
        {
            Tu = t;
            Mau = m;
            return (float)(Tu*1.0f / Mau);
        }
        #endregion

        #region
        //int tu, mau;
        //Phanso next = null;
        //Phanso previous = null;

        //public int Tu
        //{
        //    get { return tu; }
        //    set { tu = value; }
        //}
        //public int Mau
        //{
        //    get { return mau; }
        //    set { mau = value; }
        //}
        //public Phanso Next
        //{
        //    get { return next; }
        //    set { next = value; }
        //}
        //public Phanso Previous
        //{
        //    get { return previous; }
        //    set { previous = value; }
        //}

        //public Phanso(int t, int m)
        //{
        //    Tu = t;
        //    Mau = m;
        //    Next = null;
        //    Previous = null;
        //}
        //public float PS_Value()
        //{
        //    return (float)(tu / mau);
        //}
        #endregion
    }

    class BT_Phanso
    {
        #region

        private Phanso first = null;
        private Phanso last = null;
        private int count = 0;

        public Phanso First { get; set; }
        public Phanso Last { get; set; }

        //LinkedList<Phanso> dsps = new LinkedList<Phanso>();
        Phanso dsps = new Phanso();
        public bool IsEmpty()
        {
            return first == null;
        }
        public void AddPhanso(int t, int m)
        {
            Phanso ps = new Phanso(t, m);

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
        }
        public void Outbtps()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\nBiểu thức:  ");
            Console.ForegroundColor = ConsoleColor.White;


            Phanso p = first;
            while (p != null)
            {
                if (p.Next == null)
                {
                    //Console.Write(p.Tu + "/" + p.Mau + "  \n\n");
                    if (p.Tu < 0)
                    {
                        //p.Tu = -p.Tu;
                        Console.Write(" - " + -p.Tu + "/" + p.Mau + " \n\n");
                    }
                    else
                    {
                        Console.Write(" + " + p.Tu + "/" + p.Mau + " \n\n");
                    }
                }
                else if(p == first)
                {
                    if (p.Tu < 0)
                    {
                        //p.Tu = -p.Tu;
                        Console.Write(" - " + -p.Tu + "/" + p.Mau);
                    }
                    else
                    {
                        Console.Write(p.Tu + "/" + p.Mau);
                    }
                }
                else
                {
                    //Console.Write(p.Tu + "/" + p.Mau + " + ");
                    if (p.Tu < 0)
                    {
                        //p.Tu = -p.Tu;
                        Console.Write(" - " + -p.Tu + "/" + p.Mau);
                    }
                    else
                    {
                        Console.Write(" + " + p.Tu + "/" + p.Mau);
                    }
                }
                p = p.Next;
            }
        }
        public float TinhTong()
        {
            float sum = 0;
            Phanso p = first;
            while (p != null)
            {
                int t = p.Tu;
                int m = p.Mau;
                sum += dsps.Ps_Value(t, m);
                p = p.Next;
            }
            return sum;
        }

        #endregion

        #region
        //LinkedList<Phanso> ds;

        //public bool IsEmpty()
        //{
        //    return ds.First() == null;
        //}
        //public void AddPhanso(int t, int m)
        //{
        //    if (IsEmpty())
        //    {

        //    }
        //    Phanso ps = new Phanso(t, m);
        //    ds.AddLast(ps);
        //}
        //public void Outbtps()
        //{
        //    Phanso p = ds.First();
        //    while (p != null)
        //    {
        //        if (p.Next == null)
        //        {
        //            Console.Write(p.Tu + "/" + p.Mau + "  \n\n");
        //        }
        //        else
        //        {
        //            Console.Write(p.Tu + "/" + p.Mau + " -> ");
        //        }
        //        p = p.Next;
        //    }
        //}
        #endregion
    }
}
