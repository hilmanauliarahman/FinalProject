using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinalProject.Utama;
using FinalProject.Subclass;
namespace FinalProject
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Aplikasi Sistem Pendataan Barang Dealer";
            int input;
            string user;
            List<Kendaraan> listKendaraan = new List<Kendaraan>();
            List<Pelanggan> listPelanggan = new List<Pelanggan>();
            Console.Write("Username : ");
            user = Console.ReadLine();
            string pass = "";
            Console.Write("Password : ");
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, (pass.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
            while (true);
            if (user == "admin" && pass == "admin")
            {
                do
                {
                    Console.WriteLine("\nPilih Menu Aplikasi");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("1. Tambah Data Kendaraan");
                    Console.WriteLine("2. Tampilkan Data Kendaraan");
                    Console.WriteLine("3. Ubah Data Kendaraan");
                    Console.WriteLine("4. Hapus Data Kendaraan");
                    Console.WriteLine("5. Transaksi");
                    Console.WriteLine("6. Riwayat Transaksi");
                    Console.WriteLine("7. Logout");
                    Console.WriteLine("8. Keluar");
                    Console.WriteLine("=========================================");
                    Console.Write("Pilihan (1 sd 8): ");
                    input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Tambah Data Kendaraan\n");
                            Console.WriteLine("Jenis Kendaraan\n1. Mobil \n2. Motor \n");
                            Console.Write("Pilihan (1 atau 2): ");
                            int pil = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            switch (pil)
                            {
                                case 1:
                                    Mobil Mobil = new Mobil();
                                    Mobil.jenis = "Mobil";
                                    //Mobil.jenis = Console.ReadLine();
                                    Console.Write("Kode Barang : ");
                                    Mobil.kodebarang = Console.ReadLine();
                                    Console.Write("Nama Barang : ");
                                    Mobil.namabarang = Console.ReadLine();
                                    Console.Write("Merek : ");
                                    Mobil.merek = Console.ReadLine();
                                    Mobil.jumlah = 1;
                                    Console.Write("Pilih Status\n1. Baru datang \n2. Dipajang di dealer \n");
                                    Console.Write("Status : ");
                                    Mobil.status = Convert.ToInt32(Console.ReadLine());
                                    if (Mobil.status == 1)
                                    {
                                        Mobil.lokasi = "Gudang";
                                    }
                                    else
                                    {
                                        Mobil.lokasi = "Dealer";
                                    }
                                    listKendaraan.Add(Mobil);
                                    Console.Clear();
                                    break;
                                case 2:
                                    Motor Motor = new Motor();
                                    Motor.jenis = "Motor";
                                    //Motor.jenis = Console.ReadLine();
                                    Console.Write("Kode Barang : ");
                                    Motor.kodebarang = Console.ReadLine();
                                    Console.Write("Nama Barang : ");
                                    Motor.namabarang = Console.ReadLine();
                                    Console.Write("Merek : ");
                                    Motor.merek = Console.ReadLine();
                                    Motor.jumlah = 1;
                                    Console.Write("Pilih Status\n1. Baru datang \n2. Dipajang di dealer \n");
                                    Console.Write("Status : ");
                                    Motor.status = Convert.ToInt32(Console.ReadLine());
                                    if (Motor.status == 1)
                                    {
                                        Motor.lokasi = "Gudang";
                                    }
                                    else
                                    {
                                        Motor.lokasi = "Dealer";
                                    }
                                    listKendaraan.Add(Motor);
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Menu Yang Anda Masukkan Salah!!!");
                                    Console.Clear();
                                    break;
                            }
                            Console.Clear();
                            break;
                        case 2:
                            string status = " ";
                            int noUrut = 0;
                            Console.WriteLine("Data Kendaraan\n");
                            foreach (Kendaraan Kendaraan in listKendaraan)
                            {
                                if (Kendaraan.status == 1)
                                {
                                    status = "Baru Datang";
                                }
                                else if (Kendaraan.status == 2)
                                {
                                    status = "Dipajang di dealer";
                                }
                                else
                                {
                                    status = "Terjual";
                                }
                                if (Kendaraan.jumlah < 1)
                                {
                                    Console.WriteLine("");
                                }
                                else { 
                                noUrut++;
                                Console.WriteLine("No. : {0}", noUrut);
                                Console.WriteLine("Jenis : {0}", Kendaraan.jenis);
                                Console.WriteLine("Kode Kendaraan : {0}", Kendaraan.kodebarang);
                                Console.WriteLine("Nama Kendaraan : {0}", Kendaraan.namabarang);
                                Console.WriteLine("Merk : {0}", Kendaraan.merek);
                                Console.WriteLine("Jumlah : {0}", Kendaraan.jumlah);
                                Console.WriteLine("Lokasi : {0}", Kendaraan.lokasi);
                                Console.WriteLine("Status : {0}", status);
                                Console.WriteLine("\n");
                                }
                            }
                            if (noUrut < 1)
                            {
                                Console.WriteLine("Data Kendaraan Kosong");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            Console.WriteLine("Ubah Data Kendaraan\n");
                            Console.Write("Kode Barang : ");
                            string gantibarang = Console.ReadLine();

                            foreach (Kendaraan Kendaraan in listKendaraan)
                            {

                                if (Kendaraan.kodebarang == gantibarang)
                                {
                                    Console.WriteLine("Kode Kendaraan : {0}", Kendaraan.kodebarang);
                                    Console.WriteLine("Nama Kendaraan : {0}", Kendaraan.namabarang);
                                    Console.WriteLine("Merk : {0}", Kendaraan.merek);
                                    Console.WriteLine("Jumlah : {0}", Kendaraan.jumlah);
                                    Console.WriteLine("Lokasi : {0}", Kendaraan.lokasi);
                                    Console.WriteLine("Status : {0}", Kendaraan.status);
                                    Console.WriteLine("\n");

                                    Console.Write("Kode Barang : ");
                                    Kendaraan.kodebarang = Console.ReadLine();
                                    Console.Write("Nama Barang : ");
                                    Kendaraan.namabarang = Console.ReadLine();
                                    Console.Write("Merek : ");
                                    Kendaraan.merek = Console.ReadLine();
                                    Console.Write("Pilih Status\n1. Baru datang \n2. Dipajang di dealer \n");
                                    Console.Write("Status : ");
                                    Kendaraan.status = Convert.ToInt32(Console.ReadLine());
                                    if (Kendaraan.status == 1)
                                    {
                                        Kendaraan.lokasi = "Gudang";
                                    }
                                    else
                                    {
                                        Kendaraan.lokasi = "Dealer";
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\n");
                                }
                            }
                            Console.Clear();
                            break;
                        case 4:
                            int no = -1, hapus = -1;
                            Console.WriteLine("Hapus Data Kendaraan\n");
                            Console.Write("Kode Kendaraan : ");
                            string kb = Console.ReadLine();
                            foreach (Kendaraan Kendaraan in listKendaraan)
                            {
                                no++;
                                if (Kendaraan.kodebarang == kb)
                                {
                                    hapus = no;
                                }
                            }
                            if (hapus != -1)
                            {
                                listKendaraan.RemoveAt(hapus);
                                Console.WriteLine("\nData Berhasil dihapus");
                            }
                            else
                            {
                                Console.WriteLine("\nData tidak ditemukan");
                            }
                            Console.Clear();
                            break;
                        case 5:
                            Console.WriteLine("Pembelian\n");
                            Console.Write("Kode Barang : ");
                            string gantibarangx = Console.ReadLine();

                            foreach (Kendaraan Kendaraan in listKendaraan)
                            {

                                if (Kendaraan.kodebarang == gantibarangx)
                                {
                                    Console.WriteLine("Kode Kendaraan : {0}", Kendaraan.kodebarang);
                                    Console.WriteLine("Nama Kendaraan : {0}", Kendaraan.namabarang);
                                    Console.WriteLine("Merk : {0}", Kendaraan.merek);
                                    Console.WriteLine("Jumlah : {0}", Kendaraan.jumlah);
                                    Console.WriteLine("Lokasi : {0}", Kendaraan.lokasi);
                                    Console.WriteLine("Status : {0}", Kendaraan.status);
                                    Console.WriteLine("\n");

                                    Pelanggan Pelanggan = new Pelanggan();
                                    Console.Write("Kode Pelanggan : ");
                                    Pelanggan.kodepelanggan = Console.ReadLine();
                                    Console.Write("Nama Pelanggan : ");
                                    Pelanggan.namapelanggan = Console.ReadLine();
                                    Console.Write("Alamat Pelanggan : ");
                                    Pelanggan.alamat = Console.ReadLine();
                                    Kendaraan.jumlah = 0;
                                    Kendaraan.status = 3;
                                    Pelanggan.kodebarang = gantibarangx;
                                    Kendaraan.lokasi = "telah diambil pelanggan";
                                    listPelanggan.Add(Pelanggan);
                                }
                                else
                                {
                                    Console.WriteLine("");
                                }
                            }
                            Console.Clear();
                            break;
                        case 6:
                            string riwayatstatus = " ";
                            Console.WriteLine("Riwayat Pembelian\n");
                            int noUrut3 = 0;
                            foreach (Kendaraan Kendaraan in listKendaraan)
                            {
                                if (Kendaraan.status == 3)
                                {
                                    riwayatstatus = "Terjual";
                                }
                                foreach (Pelanggan Pelanggan in listPelanggan)
                                {
                                    if (Pelanggan.kodebarang == Kendaraan.kodebarang)
                                    {
                                        noUrut3++;
                                        Console.WriteLine("No. : {0}", noUrut3);
                                        Console.WriteLine("Kode Pelanggan : {0}", Pelanggan.kodepelanggan);
                                        Console.WriteLine("Nama Pelanggan : {0}", Pelanggan.namapelanggan);
                                        Console.WriteLine("Alamat : {0}", Pelanggan.alamat);
                                        Console.WriteLine("Kode Barang : {0}", Pelanggan.kodebarang);
                                        Console.WriteLine("Kode Kendaraan : {0}", Kendaraan.kodebarang);
                                        Console.WriteLine("Nama Kendaraan : {0}", Kendaraan.namabarang);
                                        Console.WriteLine("Merk : {0}", Kendaraan.merek);
                                        Console.WriteLine("Jumlah : 1");
                                        Console.WriteLine("Lokasi : {0}", Kendaraan.lokasi);
                                        Console.WriteLine("Status : {0}", riwayatstatus);
                                        Console.WriteLine("\n");
                                    }
                                    else {
                                        Console.WriteLine(" ");
                                    }
                                }
                            }

                            break;
                        case 7:
                            //koding logout atau kembali ke menu awal
                            Main();
                            Console.Clear();
                            Console.WriteLine("\nLogout Berhasil!");
                            break;
                        case 8:
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak tersedia!");
                            Console.Clear();
                            break;
                    }
                    Console.WriteLine("\n");
                }
                while (input != 8);
            }
            else
            {
                Console.WriteLine("\nUsername atau Password salah!");
                Main();
            }
        }
    }
}
