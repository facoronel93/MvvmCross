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
            Persona hola = new Persona();
            hola.Usuario = "fede";
            hola.Password = "fede";
            conn = new SQLiteAsyncConnection(dbPath);
            conn.CreateTableAsync<Persona>().Wait();
            conn.InsertAsync(hola).ConfigureAwait(continueOnCapturedContext: false);

        }

        public async Task Insert(Persona persona)
        {

            await conn.InsertAsync(persona).ConfigureAwait(continueOnCapturedContext: false);
            /* var resultado = await conn.Table<Persona>().Where(x => x.Usuario == "fede").FirstOrDefaultAsync();

            if (resultado.Usuario == persona.Usuario)
            {
                //mostrar al usuario que esta existe
            }
            else
            {
                await conn.InsertAsync(persona).ConfigureAwait(continueOnCapturedContext: false);
            }
            */
        }


        Persona asd = new Persona();

    public void GetUser(Persona usuario)
        {
            Persona hola = new Persona();
            hola.Usuario = "fede";
            hola.Password = "fede";
            conn.InsertAsync(hola).ConfigureAwait(continueOnCapturedContext: false);
            var resultado = conn.Table<Persona>().Where(x => x.Usuario == "fede");
            var fedde = resultado.ToListAsync();

            var query = conn.Table<Persona>().Where(
                   p1 => p1.Usuario == "fede").FirstAsync();

            asd.Usuario = query.Result.Usuario;
          
            if (resultado == null)
            {
                //usuario inexistente
            }
            else
            {
                if (asd.Usuario == usuario.Password)
                {
                    // ingresar a al menu de clima
                }
                else
                {
                    //contraseña incorrecta
                }
            }

            
        }
        

    }
}
