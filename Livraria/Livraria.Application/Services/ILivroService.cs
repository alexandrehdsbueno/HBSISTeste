using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Services
{
    public interface ILivroService
    {
        void Save(CadastrarLivroViewModel model);

        CadastrarLivroViewModel GetById(Guid id);

        List<LivrosViewModel> GetAll();

        void Delete(Guid id);
    }
}
