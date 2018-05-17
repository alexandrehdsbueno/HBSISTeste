using Domain.Core;
using System;

namespace Domain.Model
{
    public class Livro : Entity<Guid>
    {
        public Livro()
        {
            this.Id = Guid.NewGuid();
            this.DataCadastro = DateTime.Now;
        }

        public string Titulo { get; private set; }

        public string Autor { get; private set; }

        public DateTime DataPublicacao { get; private set; }

        public DateTime DataCadastro { get; private set; }

        public bool Ativo { get; private set; }

        public void Atualizar(string titulo, string autor, DateTime dataPublicacao)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.DataPublicacao = dataPublicacao;
        }

        public void Inativar()
        {
            this.Ativo = false;
        }
    }
}
