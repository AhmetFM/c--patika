using System;

namespace tip_donusumleri{
    class Program{
        static void Main(string[] args){
            //implicit conversion
            byte a=1;
            sbyte b=2;
            short c=3;
            int d=a+b+c;
            Console.WriteLine(d);

            long h=d;
            Console.WriteLine(h);

            float i=h;
            Console.WriteLine(i);

            string e="Ahmet";
            char f = 'k';
            object g = e+f+g;
            Console.WriteLine(g);

            //explicit conversion
            int x=4;
            byte y=(byte)x;
            Console.WriteLine(x);
            
            int z = 100;
            byte t = (byte)z;
            Console.WriteLine(z);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine(w);

            //To string methodu
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine(yy);
            
            string zz = 12.5f.ToString();
            Console.WriteLine(zz);

            //System.Convert
            string s1="10", s2="20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1+sayi2;
            Console.WriteLine(Toplam);

            //Parse
            ParseMethod();
        }
        public static void ParseMethod(){
            string metin1="10";
            string metin2="10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine(rakam1);
            Console.WriteLine(double1);
        }
    }
}