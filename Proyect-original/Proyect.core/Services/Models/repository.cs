using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyect.core.Services.Models;

namespace Proyect.core.Services.Models
{
    public class Repository
    {
        private SQLiteAsyncConnection conn;
        
        public Repository(string dbPath)
        {
          /*  var asd = new DatosClima();
            asd.Ciudad = "fede";
            asd.HoraConsulta = "fede";
            asd.Humedad = "fede";
            asd.Id = 0;
            asd.Pais = "fede";
            asd.Temperatura = "fede";
            */
            conn = new SQLiteAsyncConnection(dbPath);
            conn.CreateTableAsync<Persona>().Wait();
          
          // var hola = new DatosClima();
          //  conn.InsertAsync(asd);
        }

        public async Task Insert(Persona persona)
        {

            var resultado = await conn.Table<Persona>().Where(x => x.Usuario == "fede").FirstOrDefaultAsync();

            if (resultado.Usuario == persona.Usuario)
            {
                //mostrar al usuario que esta existe
            }
            else
            {
                await conn.InsertAsync(persona).ConfigureAwait(continueOnCapturedContext: false);
            }

        }


        public Task<List<DatosClima>> GetHistorial()
        {
            var fede = conn.Table<DatosClima>();
            var gola = fede.ToListAsync();
            return gola;
        }
    }
}
