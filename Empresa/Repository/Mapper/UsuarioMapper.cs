using Empresa.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Empresa.Repository.Mapper
{
    public class UsuarioMapper : MapperBase<Usuario>
    {
        public override Usuario MapperFromDataSource(DataRow DR)
        {
            return new Usuario
            {
                ID = Convert.ToInt32(DR["ID"]),
                Nome = DR["Nome"].ToString(),
                Matricula = DR["Matricula"].ToString(),
                Telefone = DR["Telefone"].ToString(),
                Email = DR["Email"].ToString()
            };
        }
    }
}