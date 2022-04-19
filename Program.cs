using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4334
{
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat Objek
            Karyawan satu = new Karyawan(190302123, "Paijo", 3000000);
            Karyawan dua = new Karyawan(190302124, "Jono", 2000000);

            Console.WriteLine("No | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("================================================");
            Console.WriteLine("1. | {0} {1} \t\t | {2}\t", satu.Nik, satu.Nama, satu.GajiBulanan);
            Console.WriteLine("1. | {0} {1} \t\t | {2}\t", dua.Nik, dua.Nama, dua.GajiBulanan);

            Console.WriteLine("KENAIKAN GAJI 10%");

            Console.WriteLine("No | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("================================================");
            Console.WriteLine("1. | {0} {1} \t\t | {2}\t", satu.Nik, satu.Nama, satu.GajiNaik);
            Console.WriteLine("1. | {0} {1} \t\t | {2}\t", dua.Nik, dua.Nama, dua.GajiNaik);

            Console.ReadKey();
        }
    }
}
