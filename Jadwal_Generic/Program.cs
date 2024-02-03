using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadwal_Generic
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Mata_Pelajaran Senin1 = new Mata_Pelajaran("Bhs Inggris", 2, "05,04,05", " Acchi", "07.30");
            Mata_Pelajaran Senin2 = new Mata_Pelajaran("Struktur Data", 4, "05,03,06", " Ibu Nafi", "08.40");
            Mata_Pelajaran Senin3 = new Mata_Pelajaran("Logika", 2, "02,01,02", " Ningsih", "10.50");

            Day<Mata_Pelajaran> Jam1 = new Day<Mata_Pelajaran>(Senin1);
            Day<Mata_Pelajaran> Jam2 = new Day<Mata_Pelajaran>(Senin2);
            Day<Mata_Pelajaran> Jam3 = new Day<Mata_Pelajaran>(Senin3);

            Console.WriteLine(" Pelajaran : {0} \n SKS       : {1} \n Ruangan   : {2}\n Dosen     :{3}\n Mulai {4}\n", Jam1.value.pelajaran, Jam1.value.SKS, Jam1.value.ruangan, Jam1.value.Dosen, Jam1.value.jam_pelajaran);
            Console.WriteLine(" Pelajaran : {0} \n SKS       : {1} \n Ruangan   : {2}\n Dosen     :{3}\n Mulai {4}\n", Jam2.value.pelajaran, Jam2.value.SKS, Jam2.value.ruangan, Jam2.value.Dosen, Jam2.value.jam_pelajaran);
            Console.WriteLine(" Pelajaran : {0} \n SKS       : {1} \n Ruangan   : {2}\n Dosen     :{3}\n Mulai {4}\n", Jam3.value.pelajaran, Jam3.value.SKS, Jam3.value.ruangan, Jam3.value.Dosen, Jam3.value.jam_pelajaran);
        }
    }
}
