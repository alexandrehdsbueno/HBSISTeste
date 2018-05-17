using Domain.Model;
using System;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface ILivroCommand
    {
        void Salvar(Livro model);

        Livro GetById(Guid id);

        List<Livro> GetAll();

        void Excluir(Guid id);

        void Inativar(Guid id);
    }
}
