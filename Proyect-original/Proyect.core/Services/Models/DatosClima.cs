using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.core.Services.Models
{
    [Table(nameof(DatosClima))]
    public class DatosClima
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Ciudad { get; set; }
        [MaxLength(250)]
        public string Pais { get; set; }
        [MaxLength(250)]
        public string Temperatura { get; set; }
        [MaxLength(250)]
        public string Humedad { get; set; }
        [MaxLength(250)]
        public string HoraConsulta { get; set; }

       
    }
}