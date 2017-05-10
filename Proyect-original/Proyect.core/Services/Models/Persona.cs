using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.core.Services.Models
{

        [Table(nameof(Persona))]
        public class Persona
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            [NotNull, MaxLength(250)]
            public string Usuario { get; set; }

            [NotNull, MaxLength(250)]
            public string Nombre { get; set; }

            [NotNull, MaxLength(250)]
            public string Email { get; set; }
        }

}
