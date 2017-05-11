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
            [MaxLength(250)]
            public string Usuario { get; set; }

            [MaxLength(250)]
            public string Password { get; set; }

            [MaxLength(250)]
            public string Nombre { get; set; }

            [MaxLength(250)]
            public string Email { get; set; }
        }

}
