using Application.ViewModel;
using AutoMapper;
using Domain.Interfaces;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroCommand _livroCommand;
        private readonly IMapper _mapper;

        public LivroService(ILivroCommand livroCommand, IMapper mapper)
        {
            _livroCommand = livroCommand;
            _mapper = mapper;
        }

        public void Delete(Guid id)
        {
            _livroCommand.Excluir(id);
        }

        public List<LivrosViewModel> GetAll()
        {
            var livros = _livroCommand.GetAll().OrderBy(x => x.Titulo);
            var livrosViewModel = livros.Select(x => _mapper.Map<LivrosViewModel>(x)).ToList();
            return livrosViewModel;
        }

        public CadastrarLivroViewModel GetById(Guid id)
        {
            var livro = _livroCommand.GetById(id);
            return _mapper.Map<CadastrarLivroViewModel>(livro);
        }

        public void Save(CadastrarLivroViewModel model)
        {
            var livro = _mapper.Map<Livro>(model);
            _livroCommand.Salvar(livro);
        }
    }
}
