using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinalProject.Utama;
namespace FinalProject.Subclass
{
    class Mobil : Kendaraan
    {
        public override string jenis { get; set; }
        public override string namabarang { get; set; }
        public override string merek { get; set; }
        public override int jumlah { get; set; }
        public override string kodebarang { get; set; }
        public override string lokasi { get; set; }
        public override int status { get; set; }
    }
}
