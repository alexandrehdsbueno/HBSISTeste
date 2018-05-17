using Application.ViewModel;
using AutoMapper;
using Domain.Model;

namespace Application.AutoMapper
{
    public class ViewModelProfile : Profile
    {
        public ViewModelProfile()
        {
            CreateMap<CadastrarLivroViewModel, Livro>();
            CreateMap<LivrosViewModel, Livro>();
        }
    }
}
