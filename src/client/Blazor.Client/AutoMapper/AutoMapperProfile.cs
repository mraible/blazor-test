using AutoMapper;
using System.Linq;
using blazor.Client.Models;
using blazor.Dto;


namespace blazor.Client.AutoMapper {

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDto, UserModel>()
                .ForMember(userModel => userModel.Authorities,
                    opt => opt.MapFrom(userDto => userDto.Roles))
                .ReverseMap()
                .ForPath(userDto => userDto.Roles,
                    opt => opt.MapFrom(userModel => userModel.Authorities));
            
            CreateMap<ManagedUserDto, UserSaveModel>().ReverseMap();
            CreateMap<LoginDto, LoginModel>().ReverseMap();

            // jhipster-needle-add-dto-model-mapping - JHipster will add dto to model and model to dto mapping 
        }
    }
}
