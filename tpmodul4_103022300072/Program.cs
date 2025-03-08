using System;

namespace tpmodul4_103022300072
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kelurahan    " + " Kode Pos");
            Console.WriteLine("Batununggal   " + KodePos.GetKodePos(KodePos.Kelurahan.Batununggal));
            Console.WriteLine("Kujangsari    " + KodePos.GetKodePos(KodePos.Kelurahan.Kujangsari));
            Console.WriteLine("Mengger       " + KodePos.GetKodePos(KodePos.Kelurahan.Mengger));
            Console.WriteLine("Wates         " + KodePos.GetKodePos(KodePos.Kelurahan.Wates));
            Console.WriteLine("Cijaura       " + KodePos.GetKodePos(KodePos.Kelurahan.Cijaura));
            Console.WriteLine("Jatisari      " + KodePos.GetKodePos(KodePos.Kelurahan.Jatisari));
            Console.WriteLine("Margasari     " + KodePos.GetKodePos(KodePos.Kelurahan.Margasari));
            Console.WriteLine("Sekejati      " + KodePos.GetKodePos(KodePos.Kelurahan.Sekejati));
            Console.WriteLine("Kebonwaru     " + KodePos.GetKodePos(KodePos.Kelurahan.Kebonwaru));
            Console.WriteLine("Maleer        " + KodePos.GetKodePos(KodePos.Kelurahan.Maleer));
            Console.WriteLine("Samoja        " + KodePos.GetKodePos(KodePos.Kelurahan.Samoja));
            Console.WriteLine("");

            DoorMachine pintu = new DoorMachine(); // State awal: Terkunci
            while (true)
            {
                Console.Write("Masukkan perintah (buka/kunci/keluar): ");
                string input = Console.ReadLine().ToLower();

                if (input == "buka")
                {
                    pintu.ActivateTrigger(Trigger.BukaPintu);
                }
                else if (input == "kunci")
                {
                    pintu.ActivateTrigger(Trigger.KunciPintu);
                }
                else if (input == "keluar")
                {
                    Console.WriteLine("Program selesai.");
                    break;
                }
                else
                {
                    Console.WriteLine("Perintah tidak valid! Gunakan 'buka', 'kunci', atau 'keluar'.");
                }
            }
        }
    }
}
