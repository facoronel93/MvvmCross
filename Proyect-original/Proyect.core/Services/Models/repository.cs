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
        }
       


        Persona asd = new Persona();

    public Persona GetUser(Persona usuario)
        {
           
            var query = conn.Table<Persona>().Where(
                   p1 => p1.Usuario == usuario.Usuario).FirstAsync();

            asd.Usuario = query.Result.Usuario;
            var resultado = new Persona
            {
                Password = query.Result.Password,
                Email = query.Result.Email,
                Usuario = query.Result.Usuario,
                Nombre = query.Result.Nombre,
            };

            return resultado;          
       }

                

    }
}

