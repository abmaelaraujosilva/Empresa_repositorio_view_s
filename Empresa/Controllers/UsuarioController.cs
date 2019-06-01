using Empresa.DataSource;
using Empresa.Models;
using Empresa.Repository.Mapper;
using Empresa.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Empresa.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CadastrarUsuario()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CadastrarUsuario(Usuario a)
        {
            UsuarioRepository _UREP = new UsuarioRepository(new SqlDB(), new UsuarioMapper());
            _UREP.ADD(a);
            return RedirectToAction("ListarUsuario");
        }
        public ActionResult ListarUsuario()
        {
            UsuarioRepository _UREP = new UsuarioRepository(new SqlDB(), new UsuarioMapper());
            return View(_UREP.LIST());
        }
        public ActionResult DeletarUsuario(Usuario a)
        {
            UsuarioRepository _UREP = new UsuarioRepository(new SqlDB(), new UsuarioMapper());
            _UREP.DELETE(a);
            return RedirectToAction("ListarUsuario");
        }
        public ActionResult EditarUsuario(int ID)
        {
            UsuarioRepository _UREP = new UsuarioRepository(new SqlDB(), new UsuarioMapper());
            
            return View(_UREP.GETBYID(ID));
        }
        [HttpPost]
        public ActionResult EditarUsuario(Usuario a)
        {
            UsuarioRepository _UREP = new UsuarioRepository(new SqlDB(), new UsuarioMapper());
            _UREP.UPDATE(a, a.ID);
            return RedirectToAction("ListarUsuario");
        }
    }
}