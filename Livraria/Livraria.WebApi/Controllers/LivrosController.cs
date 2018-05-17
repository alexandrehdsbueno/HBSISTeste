using Application.Services;
using Application.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApi.Controllers.V1
{
    [Produces("application/json")]
    [Route("api/Livros")]
    public class LivrosController : ApiController
    {
        private readonly ILivroService _livroService;

        public LivrosController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Obter/{id}")]
        public IActionResult GetLivro(Guid id)
        {
            return Response(_livroService.GetById(id));
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Listar")]
        public IActionResult GetLivros()
        {
            return Response(_livroService.GetAll());
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Salvar")]
        public IActionResult SaveLivro([FromBody] CadastrarLivroViewModel model)
        {
            _livroService.Save(model);
            return Response();
        }

        [HttpDelete]
        [AllowAnonymous]
        [Route("Excluir/{id}")]
        public IActionResult DeleteLivros(Guid id)
        {
            _livroService.Delete(id);
            return Response();
        }
    }
}