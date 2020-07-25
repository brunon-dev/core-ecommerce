using loja.Interfaces;
using loja.Models;
using loja.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace loja
{
    public class DataService : IDataService
    {
        private readonly ApplicationContext contexto;
        private readonly IProdutoRepository _produtoRepository;

        public DataService(ApplicationContext contexto,
                            IProdutoRepository produtoRepository)
        {
            this.contexto = contexto;
            this._produtoRepository = produtoRepository;
        }

        public void InicializaDB()
        {
            contexto.Database.Migrate();
            List<Livro> livros = GetLivros();
            _produtoRepository.SaveProdutos(livros);
        }

        

        private static List<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
            return livros;
        }
    }
}
