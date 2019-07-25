using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                Console.WriteLine("1.Tambah Customer \n");
                Console.WriteLine("2.Hapus Customer \n");
                Console.WriteLine("3.Tampilkan Customer \n");
                Console.WriteLine("4.Keluar \n");

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.Write("Kode Customer : ");
            string kode = Console.ReadLine();

            Console.Write("Nama Customer : ");
            string nama = Console.ReadLine();

            Console.Write("Piutang Customer : ");
            int piutang = Convert.ToInt32(Console.ReadLine());

            Customer dataCust = new Customer(kode, nama, piutang);
            daftarCustomer.Add(dataCust);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("HAPUS DATA CUSTOMER");

            Console.WriteLine("Kode Customer :");
            string kode = Console.ReadLine();

            bool found = false;
            int i = 0, indexHapus = -1;
            foreach (Customer dataCust in daftarCustomer)
            {
                if (dataCust.kode == kode)
                {
                    found = true;
                    indexHapus = i;
                }
                i++;
            }
            if (found)
            {
                daftarCustomer.RemoveAt(indexHapus);
                Console.WriteLine("Data Cusstomer sudah di hapus");
            }
            else
            {
                Console.WriteLine("Data Cusstomer Tidak dapat di temukan");
            }

        
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Data Costumer");

            int i = 1;
            foreach (Customer dataCust in daftarCustomer)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", i, dataCust.kode, dataCust.nama, dataCust.piutang);
                i++;
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
