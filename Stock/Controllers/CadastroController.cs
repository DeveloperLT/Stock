using Stock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stock.Controllers
{
    //GET GrupoProduto/GETGrupoProduto  
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public JsonResult GetGrupoProduto()
        {
            using (var db = new Entities())
            {
                List<grupo_produto> listarGrupoProduto = db.grupo_produto.ToList();
                return Json(listarGrupoProduto, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GetCidade()
        {
            using (var db = new Entities())
            {
                List<cidade> listarCidades = db.cidades.ToList();
                return Json(listarCidades, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GetEstado()
        {
            using (var db = new Entities())
            {
                List<estado> listarEstados = db.estadoes.ToList();
                return Json(listarEstados, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GetFornecedor()
        {
            using (var db = new Entities())
            {
                List<fornecedor> listarFornecedores = db.fornecedors.ToList();
                return Json(listarFornecedores, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GetInventarioEstoque()
        {
            using (var db = new Entities())
            {
                List<inventario_estoque> listarInventarioEstoque = db.inventario_estoque.ToList();
                return Json(listarInventarioEstoque, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GetLocalArmazenamento()
        {
            using (var db = new Entities())
            {
                List<local_armazenamento> listarLocalArmazenamento = db.local_armazenamento.ToList();
                return Json(listarLocalArmazenamento, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GetMarcaProduto()
        {
            using (var db = new Entities())
            {
                List<marca_produto> listarMarcaProduto = db.marca_produto.ToList();
                return Json(listarMarcaProduto, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GetPais()
        {
            using (var db = new Entities())
            {
                List<pai> listarPais = db.pais.ToList();
                return Json(listarPais, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GetPerfil()
        {
            using (var db = new Entities())
            {
                List<perfil> listarPerfil = db.perfils.ToList();
                return Json(listarPerfil, JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult GetProduto()
        {
            using (var db = new Entities())
            {
                List<produto> listarProdutos = db.produtoes.ToList();
                return Json(listarProdutos, JsonRequestBehavior.AllowGet);
            }
        }

        
    }

}