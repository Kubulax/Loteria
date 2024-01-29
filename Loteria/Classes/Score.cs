using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loteria.Classes
{
    public class Score
    {
        [AutoIncrement, PrimaryKey] 
        public int Id { get; set; }
        public DateTime DataLosowania { get; set; }
        public string WygraneLiczby { get; set; }
        public int IloscWygranych { get; set; }

        public Score(int id, DateTime dataLosowania, string wygraneLiczby, int iloscWygranych)
        {
            Id = id;
            DataLosowania = dataLosowania;
            WygraneLiczby = wygraneLiczby;
            IloscWygranych = iloscWygranych;
        }

        public Score(DateTime dataLosowania, string wygraneLiczby, int iloscWygranych)
        {
            DataLosowania = dataLosowania;
            WygraneLiczby = wygraneLiczby;
            IloscWygranych = iloscWygranych;
        }

        public Score() 
        {

        }
    }
}
