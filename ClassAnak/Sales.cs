using System;
using CollectionCRUD.ClassInduk;

namespace CollectionCRUD.ClassAnak
{
    public class Sales : Karyawan
    {
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double Gaji()
        {
            return JumlahPenjualan*Komisi;
        }
    }
}