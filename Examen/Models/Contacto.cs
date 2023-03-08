using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Examen.Models
{
    public class Contacto
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(100)]
        public string nombre { get; set; }

        [MaxLength(100)]
        public string telefono { get; set; }
        public string edad { get; set; }

        [MaxLength(300)]
        public string pais { get; set; }
        public string nota { get; set; } 
        public String foto { get; set; }
    }
}

