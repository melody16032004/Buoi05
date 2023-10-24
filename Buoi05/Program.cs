using Buoi05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("**  Bai 1");
        Console.WriteLine("**  Bai 2");
        Console.WriteLine("**  Bai 3");
        Console.WriteLine();
        int number;

        do
        {
            Console.Write("Nhap so:  ");
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        int[] a = { 15, 12, 9, 13, 6, 21, 27, 36 };
                        LinkedList ds = new LinkedList();

                        for (int i = 0; i < a.Length; i++)
                        {
                            ds.AddLast(a[i]);
                        }
                        Console.WriteLine("Chiều xuôi:");
                        ds.DisplayNext();
                        Console.WriteLine("Chiều ngược:");
                        ds.DisplayPrevious();
                        break;
                    }
                case 2:
                    {
                        BT_Phanso btps = new BT_Phanso();
                        int sel = 0;
                        do
                        {
                            Console.Write("Nhap phan so [tu/mau]:   ");
                            string ps = Console.ReadLine();
                            string[] num = ps.Split('/');
                            int t = int.Parse(num[0]);
                            int m = int.Parse(num[1]);
                            btps.AddPhanso(t, m);

                            #region Display
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Continue? ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("[1] - yes || ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[0] - no");
                            Console.ForegroundColor = ConsoleColor.White;
                            #endregion

                            sel = int.Parse(Console.ReadLine());
                        } while (sel != 0);

                        btps.Outbtps();

                        Console.WriteLine("Tong =  " + btps.TinhTong());
                        break;
                    }
                default:
                    break;
            }


        } while (number != 0);

        switch (number)
        {
            case 1:
                {
                    int[] a = { 15, 12, 9, 13, 6, 21, 27, 36 };
                    LinkedList ds = new LinkedList();

                    for (int i = 0; i < a.Length; i++)
                    {
                        ds.AddLast(a[i]);
                    }
                    Console.WriteLine("Chiều xuôi:");
                    ds.DisplayNext();
                    Console.WriteLine("Chiều ngược:");
                    ds.DisplayPrevious();
                    break;
                }
            case 2:
                {
                    BT_Phanso btps = new BT_Phanso();
                    int sel = 0;
                    do
                    {
                        Console.Write("Nhap phan so [tu/mau]:   ");
                        string ps = Console.ReadLine();
                        string[] num = ps.Split('/');
                        int t = int.Parse(num[0]);
                        int m = int.Parse(num[1]);
                        btps.AddPhanso(t, m);

                        #region Display
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Continue? ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("[1] - yes || ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[0] - no");
                        Console.ForegroundColor = ConsoleColor.White;
                        #endregion

                        sel = int.Parse(Console.ReadLine());
                    } while (sel != 0);

                    btps.Outbtps();

                    Console.WriteLine("Tong =  " + btps.TinhTong());
                    break;
                }
            default:
                break;
        }
        #region Bai 1
        /*
        int[] a = { 15, 12, 9, 13, 6, 21, 27, 36 };
        LinkedList ds = new LinkedList();

        for (int i = 0; i < a.Length; i++)
        {
            ds.AddLast(a[i]);
        }
        Console.WriteLine("Chiều xuôi:");
        ds.DisplayNext();
        Console.WriteLine("Chiều ngược:");
        ds.DisplayPrevious();
        */
        #endregion

        #region Bai 2

        //BT_Phanso btps = new BT_Phanso();
        //int sel = 0;
        //do
        //{
        //    Console.Write("Nhap phan so [tu/mau]:   ");
        //    string ps = Console.ReadLine();
        //    string[] num = ps.Split('/');
        //    int t = int.Parse(num[0]);
        //    int m = int.Parse(num[1]);
        //    btps.AddPhanso(t, m);

        //    #region Display
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.Write("Continue? ");
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.Write("[1] - yes || ");
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("[0] - no");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    #endregion

        //    sel = int.Parse(Console.ReadLine());
        //} while (sel != 0);

        //btps.Outbtps();

        //Console.WriteLine("Tong =  " + btps.TinhTong());

        #endregion

        //Dathuc dt = new Dathuc();
        ////dt.Input();

        //string P = "3X0 + 4X2 + 2X3 + 5X2";
        //int x = 3;
        // P = "3X0 + 4X2 + 2X3 + 5X2"
        //dt.Display();
        //dt.SumDonthuc(P, x);
        //dt.SimplyDonthuc();

        #region Example
        /*
        Console.WriteLine("CÁC THAO TÁC với LinkedList C#");
       
        LinkedList<string> dslk = new LinkedList<string>();

        
        int[] a = { 15, 12, 9, 13, 6, 21, 27, 36 };
        LinkedList<int> ds = new LinkedList<int>(a);

        
        XuatDS(ds);

        
        Console.WriteLine("  So phan tu : " + ds.Count);

       
        ds.AddFirst(39);

        
        ds.AddLast(79);

        
        if (ds.Find(36) != null) Console.WriteLine(" 36 co trong ds");

        
        ds.AddBefore(ds.Find(36), 63);

       
        LinkedListNode<int> p = ds.Find(36);
        ds.AddAfter(p, 33);

        XuatDS(ds);
        Console.WriteLine();

        
        if (ds.Contains(13)) Console.WriteLine("  co 13 trong ds");

    
        ds.Remove(33);

        ds.RemoveFirst();

        
        ds.RemoveLast();

        XuatDS(ds);
        Console.WriteLine();
        */
        #endregion
    }
    static void XuatDS(LinkedList<int> ds)
    {
        Console.WriteLine();
       
        LinkedListNode<int> p = ds.First;
        Console.Write("  DSLK : ");
        while (p != null)
        {
            Console.Write(p.Value + " -> ");
            p = p.Next;
        }
    }

}