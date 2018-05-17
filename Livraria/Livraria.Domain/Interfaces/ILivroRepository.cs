using Domain.Model;
using System;

namespace Domain.Interfaces
{
    public interface ILivroRepository : IRepository<Livro, Guid>
    {
    }
}
