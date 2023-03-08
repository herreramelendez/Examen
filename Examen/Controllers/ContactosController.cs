using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Examen.Models;
using System.Threading.Tasks;

namespace Examen.Controllers
{
    public class ContactosController
    {
        readonly SQLiteAsyncConnection connection;


        // Constructor de clase
        public ContactosController(String dbpath)
        { 
            // Crear una nueva conexion hacia la base de datos
            connection = new SQLiteAsyncConnection(dbpath);

            // Crear los objetos de base de datos que vamos a ocupar
            connection.CreateTableAsync<Contacto>().Wait();
        }
        // Creacion de las operaciones CRUD - DB
        // Create 

        public Task<int> SaveCon(Contacto contacto)
        {
            if (contacto.id != 0)
                return connection.UpdateAsync(contacto);
            else
                return connection.InsertAsync(contacto);
        }
        // Read
        public Task<List<Contacto>> GetListcon()
        {
            return connection.Table<Contacto>().ToListAsync();
        }
        public Task<Contacto> GetCon(int pid)
        {
            return connection.Table<Contacto>()
                .Where(i => i.id == pid)
                .FirstOrDefaultAsync();
        }
        // Delete
        public Task<int> DeleteCon(Contacto contacto)
        {
            return connection.DeleteAsync(contacto);
        }
    }
}
