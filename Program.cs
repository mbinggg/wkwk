﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsipemrog2323
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan kry1 = new karyawan();
            kry1.Nik = "18112323";
            kry1.Nama = "Mbinggg";
            kry1.GajiBulanan = 3700000;

            karyawan kry2 = new karyawan();

            kry2.Nik = "18112323";
            kry2.Nama = "akbarprnw";
            kry2.GajiBulanan = 2300000;

            Console.WriteLine("No.\tNin/Nama\t\tGaji Bulanan");
            Console.WriteLine("=======================================");
            Console.WriteLine("1.\t{0} {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan);
            Console.WriteLine("2.\t{0} {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan);
            Console.WriteLine("=======================================");

            Console.WriteLine("\n\n");
            Console.WriteLine("Asyik Kenaikan Gaji 10%");
            Console.WriteLine("\n");
            Console.WriteLine("No.\tNin/Nama\t\tGaji Bulanan");
            Console.WriteLine("=======================================");
            Console.WriteLine("1.\t{0} {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan + (kry1.GajiBulanan * 0.10));
            Console.WriteLine("2.\t{0} {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan + (kry2.GajiBulanan * 0.10));
            Console.WriteLine("=======================================");
            Console.ReadKey();

        }
    }
}
