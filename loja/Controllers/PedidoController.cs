using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using loja.Models;
using System.Diagnostics;
using loja.Repositories;

namespace loja.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public PedidoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult Carrossel()
        {
            return View(_produtoRepository.GetProdutos());
        }

        public IActionResult Carrinho()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}