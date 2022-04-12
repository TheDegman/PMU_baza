using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PMU_baza
{
    public class Rezije
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Struja { get; set; }
        public int Plin { get; set; }
        public int TV { get; set; }
        public int Voda { get; set; }

    }
}
