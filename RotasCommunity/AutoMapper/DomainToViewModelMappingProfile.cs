using AutoMapper;
using Entidades;
using UpClass.ViewModels;
using Entidades.Postagens;
using Microsoft.Owin.BuilderProperties;

namespace UpClass.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "ViewModelToDomainMapping"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<DriverViewModel, Professor>();
            Mapper.CreateMap<AddressViewModel, Address>();
            Mapper.CreateMap<RotaViewModel, Postagem>();

        }

    }
}