using System;

namespace Application.ViewModel
{
    public class CadastrarLivroViewModel
    {
        public Guid Id { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public DateTime DataPublicacao { get; set; }
    }
}
