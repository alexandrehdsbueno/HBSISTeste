using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Interfaces;
using Domain.Model;

namespace Domain.Command
{
    public class LivroCommand : ILivroCommand
    {
        private readonly ILivroRepository _livroRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LivroCommand(ILivroRepository livroRepository, IUnitOfWork unitOfWork)
        {
            _livroRepository = livroRepository;
            _unitOfWork = unitOfWork;
        }

        public void Excluir(Guid id)
        {
            _livroRepository.Remove(id);
            _unitOfWork.Commit();
        }

        public List<Livro> GetAll()
        {
            return _livroRepository.GetAll().ToList();
        }

        public Livro GetById(Guid id)
        {
            return _livroRepository.GetById(id);
        }

        public void Salvar(Livro model)
        {
            var livro = _livroRepository.GetById(model.Id);
            if (livro != null)
            {
                livro.Atualizar(model.Titulo, model.Autor, model.DataPublicacao);
                _livroRepository.Update(livro);
            }
            else
            {
                _livroRepository.Add(model);
            }

            _unitOfWork.Commit();
        }

        public void Inativar(Guid id)
        {
            var livro = _livroRepository.GetById(id);

            if (livro != null)
            {
                livro.Inativar();
                _livroRepository.Update(livro);

                _unitOfWork.Commit();
            }
        }
    }
}
