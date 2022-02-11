using System;

namespace Ab_übung_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Kapital;
            int AnlagedauerinJahren;
            double ZinssatzproJahr;
            double KZ=0, Bilanz=0;
            double zinsen=0;
            Console.WriteLine("Geben Sie das Kapital ein.");
            Kapital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben sie ihr Zinssatz pro Jahr ein");
            ZinssatzproJahr = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben sie ihr Anlage Dauer in Jahr ein");
            AnlagedauerinJahren = Convert.ToInt32(Console.ReadLine());






            string J = "Jahr", G = "Guthaben", Zi = "Zinsen", Kz = "K.Zinsen", B = "Bilanz";
            Console.WriteLine("{0,4} {1,10} {2,8} {3,10} {4,8}",J,G,Zi,Kz,B);
            
            for ( int i=1; i<=43;i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            for(int i=1;i<=AnlagedauerinJahren ;i++ )
            {
                zinsen= Kapital * (ZinssatzproJahr/100);
                KZ = KZ + zinsen;
                Bilanz = Kapital + zinsen;



                Console.WriteLine("{0,4}|{1,9:F2}E|{2,7:F2}E|{3,9:F2}E|{4,7:F2}E|", i, Kapital, zinsen, KZ, Bilanz);
                Kapital = Kapital + zinsen;
            }
       









            }



    }
}
