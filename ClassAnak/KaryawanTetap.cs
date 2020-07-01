using System;
using CollectionCRUD.ClassInduk;

namespace CollectionCRUD.ClassAnak
{
    public class KaryawanTetap : Karyawan
    {
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public double GajiBulanan { get; set; }
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}