using System;
using System.Collections.Generic;

using CollectionCRUD.ClassInduk;
using CollectionCRUD.ClassAnak;

namespace CollectionCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 9 (Pertemuan 12) - Inheritance, Polymorphism, Abstraction & Collection dengan CRUD";

            string nik, nama;

            List<KaryawanTetap> listKaryawanTetap = new List<KaryawanTetap>();
            List<KaryawanHarian> listKaryawanHarian = new List<KaryawanHarian>();
            List<Sales> listSales = new List<Sales>();

            Menu:
            Console.WriteLine("  Pilihan Menu Aplikasi");
            Console.WriteLine("==========================");
            Console.WriteLine("1. Tambah Data Karyawan");
            Console.WriteLine("2. Hapus Data Karyawan");
            Console.WriteLine("3. Tampilkan Data Karyawan");
            Console.WriteLine("4. Keluar");
            Console.WriteLine("==========================");
            Console.Write("Pilih Menu [1/2/3/4] : ");
            int pil = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (pil == 1)
            {
                Console.WriteLine();
                Console.WriteLine("       Tambah Data Karyawan");
                Console.WriteLine();
                Console.WriteLine("         Jenis Karyawan");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Karyawan Tetap");
                Console.WriteLine("2. Karyawan Harian");
                Console.WriteLine("3. Sales");
                Console.WriteLine("=================================");
                Console.Write("Pilih Jenis Karyawan [1/2/3] : ");
                int pilkar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (pilkar == 1)
                {
                    Console.Write("NIK\t\t: ");
                    nik = Console.ReadLine();
                    Console.Write("Nama\t\t: ");
                    nama = Console.ReadLine();
                    Console.Write("Gaji Bulanan\t: ");
                    double gajibulan = Convert.ToDouble(Console.ReadLine());

                    listKaryawanTetap.Add(new KaryawanTetap() {Nik = nik, Nama = nama, GajiBulanan = gajibulan});
                }
                else if (pilkar == 2)
                {
                    Console.Write("NIK\t\t\t: ");
                    nik = Console.ReadLine();
                    Console.Write("Nama\t\t\t: ");
                    nama = Console.ReadLine();
                    Console.Write("Upah per Jam\t\t: ");
                    double upah = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Jumlah Jam Kerja\t: ");
                    double jamkerja = Convert.ToDouble(Console.ReadLine());

                    listKaryawanHarian.Add(new KaryawanHarian() {Nik = nik, Nama = nama, UpahPerJam = upah, JumlahJamKerja = jamkerja});
                }
                else if (pilkar == 3)
                {
                    Console.Write("NIK\t\t: ");
                    nik = Console.ReadLine();
                    Console.Write("Nama\t\t: ");
                    nama = Console.ReadLine();
                    Console.Write("Jumlah Penjualan: ");
                    double penjualan = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Komisi\t\t: ");
                    double komisi = Convert.ToDouble(Console.ReadLine());

                    listSales.Add(new Sales() {Nik = nik, Nama = nama, JumlahPenjualan = penjualan, Komisi = komisi});
                }

                Console.WriteLine();
                Console.Write("Tekan enter untuk kembali ke Menu");
                Console.ReadKey();
                Console.Clear();
                goto Menu;
            }

            else if (pil == 2)
            {
                Console.WriteLine("Hapus Data Karyawan");
                Console.WriteLine("===================");
                Console.Write("Masukan NIK : ");
                string hapus = Console.ReadLine();
                int n = 0;
                foreach (Karyawan karyawan in listKaryawanTetap)
                {
                    if (hapus == karyawan.Nik)
                    {
                        listKaryawanTetap.RemoveAt(n);
                        break;
                    }
                    n++;
                }
                
                n=0;
                foreach (Karyawan karyawan in listKaryawanHarian)
                {
                    if (hapus == karyawan.Nik)
                    {
                        listKaryawanHarian.RemoveAt(n);
                        break;
                    }
                    n++;
                }
                
                n=0;
                foreach (Karyawan karyawan in listSales)
                {
                    if (hapus == karyawan.Nik)
                    {
                        listSales.RemoveAt(n);
                        break;
                    }
                    n++;
                }

                Console.WriteLine();
                Console.Write("Tekan enter untuk kembali ke Menu");
                Console.ReadKey();
                Console.Clear();
                goto Menu;
            }

            else if (pil == 3)
            {
                Console.WriteLine("Data Karyawan");
                Console.WriteLine();
                int noUrut = 1;
                foreach (Karyawan karyawan in listKaryawanTetap)
                {
                    Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3:N0}, Karyawan Tetap", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                    noUrut++;
                }

                foreach (Karyawan karyawan in listKaryawanHarian)
                {
                    Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3:N0}, Karyawan Harian", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                    noUrut++;
                }

                foreach (Karyawan karyawan in listSales)
                {
                    Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3:N0}, Sales", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                    noUrut++;
                }

                Console.WriteLine();
                Console.Write("Tekan enter untuk kembali ke Menu");
                Console.ReadKey();
                Console.Clear();
                goto Menu;
            }

            else 
            {
                System.Environment.Exit(0);
            }
        }
    }
}
