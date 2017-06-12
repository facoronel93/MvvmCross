using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyect.core.Services.Models;
using Proyect.core.ViewModels;

namespace Proyect.core.Services.Models
{
    public class Repository
    {
        private SQLiteAsyncConnection conn;
        
        public Repository(string dbPath)
        {
            conn = new SQLiteAsyncConnection(dbPath);
            conn.CreateTableAsync<Persona>().Wait();

        }

        public async Task Insert(Persona persona)
        {
            await conn.InsertAsync(persona).ConfigureAwait(continueOnCapturedContext: false);
        }
       

    public Persona GetUser(Persona usuario)
        {
            var resultado = new Persona();
                var query = conn.Table<Persona>().Where(p1 => p1.Usuario == usuario.Usuario).FirstOrDefaultAsync();
                if(query.Result != null)
                {
                resultado.Password = query.Result.Password;
                resultado.Email = query.Result.Email;
                resultado.Usuario = query.Result.Usuario;
                resultado.Nombre = query.Result.Nombre;
                }
            return resultado;

        }

                

    }
}

