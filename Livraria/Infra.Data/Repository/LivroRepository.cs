using Domain.Interfaces;
using Domain.Model;
using Infra.Data.Context;
using System;

namespace Infra.Data.Repository
{
    public class LivroRepository : Repository<Livro, Guid>, ILivroRepository
    {
        public LivroRepository(LivrariaContext context) : base(context)
        {

        }
    }
}
