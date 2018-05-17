using Application.ViewModel;
using AutoMapper;
using Domain.Model;

namespace Application.AutoMapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Livro, CadastrarLivroViewModel>();
            CreateMap<Livro, LivrosViewModel>();
        }
    }
}
