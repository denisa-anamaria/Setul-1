using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1
{
    internal class Program
    {
        static bool nrprim(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            for (int i = 3; i * i < n; i += 2)
                if (n % i == 0)
                    return false;
            return true;
        }
        static void p1()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine(-b / a);
            Console.ReadKey();
        }

        static void p2()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = b * b - 4 * a * c;
            if (d >= 0)
            {
                float x1 = (-b - (float)Math.Sqrt(d)) / (2 * a);
                float x2 = (-b + (float)Math.Sqrt(d)) / (2 * a);
                Console.WriteLine(x1 + " " + x2);
            }
            else
                Console.WriteLine("ecuatia nu are solutii");
            Console.ReadKey();
        }

        static void p3()
        {
            float n = float.Parse(Console.ReadLine());
            float k = float.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine("{0} divide cu {1}", n, k);
            }
            else
            {
                Console.WriteLine(n + " nu se divide cu " + k);
            }
            Console.ReadKey();
        }

        static void p4()
        {
            int y = int.Parse(Console.ReadLine());
            if ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
            {
                Console.WriteLine(y + " este an bisect");
            }
            else
            {
                Console.WriteLine(y + " nu este an bisect");
            }
            Console.ReadKey();
        }

        static void p5()
        {
            int n, k, i;
            string[] t = Console.ReadLine().Split(' ');
            n = int.Parse(t[0]);
            k = int.Parse(t[1]);
            for (i = 1; i < k; i++)
                n = n / 10;
            Console.WriteLine(n % 10);
            Console.ReadKey();

        }

        static void p6()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("{0}, {1} si {2} pot fi laturile unui triunghi", a, b, c);
            }
            else
            {
                Console.WriteLine("{0}, {1} si {2} nu pot fi laturile unui triunghi", a, b, c);
            }
            Console.ReadKey();
        }

        static void p7()
        {
            int a, b, aux;
            string[] t = Console.ReadLine().Split(' ');
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            {
                aux = a;
                a = b;
                b = aux;
            }
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }

        static void p8()
        {
            int a, b;
            string[] t = Console.ReadLine().Split(' ');
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }

        static void p9()
        {
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    Console.Write(i + " ");
        }

        static void p10()
        {
            int n = int.Parse(Console.ReadLine());

            if (nrprim(n))
                Console.WriteLine("Este prim");
            else
                Console.WriteLine("Nu este prim");
        }

        static void p11()
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                Console.Write(n % 10 + " ");
                n /= 10;
            }
        }

        static void p12()
        {
            Console.Write("Introduceti un numar : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un interval: ");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                    nr++;

            }
            Console.WriteLine("Sunt " + nr + " numere divizibile cu n in intervalul [a,b]");
        }

        static void p13()
        {
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int y, nr = 0;
            for (y = y1; y <= y2; y++)
            {
                if ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
                    nr++;
            }
            Console.WriteLine(nr);
            Console.ReadKey();
        }

        static void p14()
        {
            int n = int.Parse(Console.ReadLine());
            int inv = 0;
            int aux = n;
            while (aux > 0)
            {
                inv = inv * 10 + aux % 10;
                aux = aux / 10;
            }
            if (inv == n)
                Console.WriteLine("Este palindrom");
            else
                Console.WriteLine("Nu este palindrom");
        }

        static void p15()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = 0;
            if (a > b)
            { d = a; a = b; b = d; }
            if (a > c)
            { d = a; a = c; c = d; }
            if (b > c)
            { d = b; b = c; c = d; }
            Console.WriteLine("{0} {1} {2}", a, b, c);
            Console.ReadKey();
        }

        static void p16()
        {
            string[] t = Console.ReadLine().Split(' ');
            int a = int.Parse(t[0]);
            int b = int.Parse(t[1]);
            int c = int.Parse(t[2]);
            int d = int.Parse(t[3]);
            int e = int.Parse(t[4]);
            int aux = 0;
            if (a > b) { aux = a; a = b; b = aux; }
            if (a > c) { aux = a; a = c; c = aux; }
            if (a > d) { aux = a; a = d; d = aux; }
            if (a > e) { aux = a; a = e; e = aux; }
            if (b > c) { aux = b; b = c; c = aux; }
            if (b > d) { aux = b; b = d; d = aux; }
            if (b > e) { aux = b; b = e; e = aux; }
            if (c > d) { aux = c; c = d; d = aux; }
            if (c > e) { aux = c; c = e; e = aux; }
            if (d > e) { aux = d; d = e; e = aux; }
            Console.Write("Numerele in ordine crescatoare:" + a + "," + b + "," + c + "," + d + "," + e + ".");
        }

        static void p17()
        {
            string[] t = Console.ReadLine().Split(' ');
            int a = int.Parse(t[0]);
            int b = int.Parse(t[1]);
            int a1 = a;
            int b1 = b;
            int r = 0;
            int cmmmc = 0;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;

            }
            Console.WriteLine("Cel mai mare divizor comun este: " + a);
            cmmmc = (a1 * b1) / a;
            Console.WriteLine("Cel mai mic multiplu comun este: " + cmmmc);

        }

        static void p18()
        {
            int n = int.Parse(Console.ReadLine());
            int d = 2;
            int p = 0;
            int ok = 0;
            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    p++;
                    n = n / d;
                }
                if (p > 0 && ok == 1)
                    Console.Write("+" + d + "^" + p);
                if (p > 0 && ok == 0)
                {
                    Console.Write(d + "^" + p);
                    ok = 1;
                }

                d++;

            }
        }

        static void p19()
        {
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int s = 0;
            int[] a = new int[10];
            while (temp > 0)
            {
                int aux = temp % 10;
                a[aux]++;
                temp = temp / 10;
            }
            for (int i = 0; i < 10; i++)
            {
                if (a[i] != 0)
                    s++;
            }
            if (s == 2)
                Console.WriteLine("Numarul " + n + " este format din doua cifre care se repeta");
            else
                Console.WriteLine("Numarul " + n + " nu este format din doua cifre care se repeta");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul problemei:");
            int nrp = int.Parse(Console.ReadLine());
            if (nrp == 1)
            {
                Console.WriteLine("Problema " + nrp);
                p1();
                
            }
            if (nrp == 2)
            {
                Console.WriteLine("Problema " + nrp);
                p2();
            }
            if (nrp == 3)
            {
                Console.WriteLine("Problema " + nrp);
                p3();
            }
            if (nrp == 4)
            {
                Console.WriteLine("Problema " + nrp);
                p4();
            }
            if (nrp == 5)
            {
                Console.WriteLine("Problema " + nrp);
                p5();
            }
            if (nrp == 6)
            {
                Console.WriteLine("Problema " + nrp);
                p6();
            }
            if (nrp == 7)
            {
                Console.WriteLine("Problema " + nrp);
                p7();
            }
            if (nrp == 8)
            {
                Console.WriteLine("Problema " + nrp);
                p8();
            }
            if (nrp == 9)
            {
                Console.WriteLine("Problema " + nrp);
                p9();
            }
            if (nrp == 10)
            {
                Console.WriteLine("Problema " + nrp);
                p10();
            }
            if (nrp == 11)
            {
                Console.WriteLine("Problema " + nrp);
                p11();
            }
            if (nrp == 12)
            {
                Console.WriteLine("Problema " + nrp);
                p12();
            }
            if (nrp == 13)
            {
                Console.WriteLine("Problema " + nrp);
                p13();
            }
            if (nrp == 14)
            {
                Console.WriteLine("Problema " + nrp);
               p14();
            }
            if (nrp == 15)
            {
                Console.WriteLine("Problema " + nrp);
                p15();
            }
            if (nrp == 16)
            {
                Console.WriteLine("Problema " + nrp);
                p16();
            }
            if (nrp == 17)
            {
                Console.WriteLine("Problema " + nrp);
                p17();
            }
            if (nrp == 18)
            {
                Console.WriteLine("Problema " + nrp);
                p18();
            }
            if (nrp == 19)
            {
                Console.WriteLine("Problema " + nrp);
                p19();
            }
            if (nrp == 20)
            {
                Console.WriteLine("Problema " + nrp);
                //p20();
            }
            if (nrp == 21)
            {
                Console.WriteLine("Problema " + nrp);
                //p21();
            }
            Console.ReadKey();
        }
    }
}
