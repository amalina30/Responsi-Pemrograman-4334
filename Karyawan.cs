using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4334
{
    class Karyawan
    {
        //Properties
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int GajiNaik { get; set; }

        //Constructor
        public Karyawan(int Nik, string Nama, int GajiBulanan)
        {
            this.Nik = Nik;
            this.Nama = Nama;

            if (GajiBulanan < 0)
            {
                this.GajiBulanan = 0;
                GajiNaik = Convert.ToInt32((GajiBulanan * 1.1));
            }
            else
            {
                this.GajiBulanan = GajiBulanan;
                GajiNaik = Convert.ToInt32((GajiBulanan * 1.1));
            }
        }
    }
}