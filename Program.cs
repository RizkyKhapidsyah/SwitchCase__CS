using System;

namespace IfElse__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nilai;
            string Hasil = null, Input;

            Console.Write("Masukkan Nilai (1-100) : ");
            Nilai = Convert.ToInt32(Input = Console.ReadLine());


            switch (Nilai)
            {
                case (90):
                    Hasil = "Suhu";
                    break;
                case (70):
                    Hasil = "Master";
                    break;
                case (50):
                    Hasil = "Jago";
                    break;
                case (30):
                    Hasil = "Standard";
                    break;
                case (10):
                    Hasil = "Newbie";
                    break;
                default:
                    break;
            }

            Console.WriteLine("Anda {0}", Hasil);
            Console.ReadLine();
        }
    }
}
