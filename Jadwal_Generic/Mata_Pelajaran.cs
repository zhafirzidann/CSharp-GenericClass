using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadwal_Generic
{
    internal class Mata_Pelajaran
    {
        public string pelajaran;
        public int SKS;
        public string ruangan;
        public string Dosen;
        public string jam_pelajaran;

        public Mata_Pelajaran(string pelajaran, int SKS, string ruangan, string Dosen, string jam_pelajaran)
        {
            this.pelajaran = pelajaran;
            this.SKS = SKS;
            this.ruangan = ruangan;
            this.Dosen = Dosen;
            this.jam_pelajaran = jam_pelajaran;

        }
    }
}
