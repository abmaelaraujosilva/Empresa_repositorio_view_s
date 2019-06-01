using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empresa.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Telefone { get; set; }
        public string Matricula { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
    }
}