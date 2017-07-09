using Livraria.Dominio.Base;
using Livraria.Dominio.Livros;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Livrarias.API.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroRepository _repositorio;
        private readonly ILivroServico _servico;
        private readonly IUow _uow;

        public LivroController(IUow uow, ILivroRepository repositorio, ILivroServico servico)
        {
            _uow = uow;
            _repositorio = repositorio;
            _servico = servico;
        }

        [HttpGet]
        [Route("livro")]
        public IActionResult Get()
        {
            return Ok(_repositorio.Buscar());
        }

        [HttpGet]
        [Route("livro/{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_repositorio.Buscar(id));
        }

        [HttpPut]
        [Route("livro")]
        public async Task<IActionResult> Put([FromBody] DTOLivro dto)
        {
            _servico.Alterar(dto);
            _uow.Commit();
            return Ok();
        }

        [HttpPost]
        [Route("livro")]
        public IActionResult Post([FromBody] DTOLivro dto)
        {
            _servico.Salvar(dto);
            _uow.Commit();
            return Ok();
        }
        
        [HttpPost]
        [Route("livroRemover/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            _servico.Remover(id);
            _uow.Commit();
            return Ok();
        }
    }
}
