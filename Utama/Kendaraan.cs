using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinalProject.Subclass;
namespace FinalProject.Utama
{
    public abstract class Kendaraan
    {
        public abstract string jenis { get; set; }
        public abstract string namabarang { get; set; }
        public abstract string merek { get; set; }
        public abstract int jumlah { get; set; }
        public abstract string kodebarang { get; set; }
        public abstract string lokasi { get; set; }
        public abstract int status { get; set; }
    }
}
