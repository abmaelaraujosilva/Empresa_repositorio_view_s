using Empresa.DataSource;
using Empresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empresa.Repository.Model
{
    public class UsuarioRepository : IRepository<Usuario>
    {
        IConnection db;
        IMapper<Usuario> mapper;
        public UsuarioRepository(IConnection _con, IMapper<Usuario> _mapper)
        {
            db = _con;
            mapper = _mapper;
        }
        public bool ADD(Usuario TIten)
        {
            var sql = "INSERT INTO Usuario (Nome, Matricula, Telefone, Email) VALUES ('" + TIten.Nome + "', '" + TIten.Matricula + "', '" + TIten.Telefone + "', '" + TIten.Email + "')";
            return db.ExecultyNonQuery(sql);
        }

        public bool DELETE(Usuario TIten)
        {
            var sql = "DELETE FROM Usuario WHERE ID =" + TIten.ID;
            return db.ExecultyNonQuery(sql);
        }

        public Usuario GETBYID(int ID)
        {
            return LIST().Where(x =>x.ID == ID).First();
        }

        public List<Usuario> LIST()
        {
            var sql = "SELECT * FROM Usuario";
            return mapper.MapperAllFromDataSource(db.List(sql));
        }

        public bool UPDATE(Usuario TIten, int ID)
        {
            var sql = "UPDATE Usuario SET Nome='"+TIten.Nome+ "', Matricula='" + TIten.Matricula + "', Telefone='" + TIten.Telefone + "', Email='" + TIten.Email+"' WHERE ID=" + ID;
            return db.ExecultyNonQuery(sql);
        }
    }
}