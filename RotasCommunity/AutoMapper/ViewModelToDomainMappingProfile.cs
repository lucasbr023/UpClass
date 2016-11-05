using AutoMapper;
using Entidades;
using Entidades.Postagens;
using Microsoft.Owin.BuilderProperties;
using UpClass.ViewModels;

namespace UpClass.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "DomainToViewModelMapping"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Professor, DriverViewModel>();    
            Mapper.CreateMap<Address, AddressViewModel>();
            Mapper.CreateMap<Postagem, RotaViewModel>();

        }

    }
}