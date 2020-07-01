using System;

namespace CollectionCRUD.ClassInduk
{
    public abstract class Karyawan
    {
        //Properties
        public abstract string Nik { get; set; }
        public abstract string Nama { get; set; }

        //method abstract
        public abstract double Gaji();
    }
}