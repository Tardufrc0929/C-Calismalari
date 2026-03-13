using System;

namespace aplikas.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Operatörü giriniz: ");
            char islem = Convert.ToChar(Console.ReadLine());

            if (islem == '+')
            {
                double sonuc = sayi1 + sayi2;
                Console.WriteLine(sayi1 +" + " + sayi2 +" = "+ sonuc);
                Console.ReadLine();
            }
            else if (islem == '-')
            {
                double sonuc = sayi1 - sayi2;
                Console.WriteLine(sayi1 + " - " + sayi2 + " = " + sonuc);
                Console.ReadLine();
            }
            else if (islem == '*')
            {
                double sonuc = sayi1 * sayi2;
                Console.WriteLine(sayi1 + " * " + sayi2 + " = " + sonuc);
                Console.ReadLine();
            }
            else if (islem == '/')
            {
                double sonuc = sayi1 / sayi2;
                Console.WriteLine(sayi1 + " / " + sayi2 + " = " + sonuc);
                Console.ReadLine();
            }
            else if (islem == '%')
            {
                double sonuc = sayi1 % sayi2;
                Console.WriteLine(sayi1 + "'in " + sayi2 + "'ye bölümünden kalan: " + sonuc);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Onu yapamıyoruz maalesef. Lütfen dört işlem veya mod almadan birini giriniz.");
                Console.ReadLine();
            }

        }
    }
}
