using AutoMapper;
using ex_projections.DTOs;
using ex_projections.Entities;

namespace ex_projections.Configurations
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<CreateUserInput, User>();

            CreateMap<User, CreateUserOutput>();

            CreateMap<User, UserDto>();
        }
    }
}
