using AutoMapper;
using DTO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İşTakipProjesi.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, LoginDTO>();
            CreateMap<LoginDTO, User>();

            CreateMap<Gorev, GorevEkleDTO>();
            CreateMap<GorevEkleDTO, Gorev>();

            CreateMap<Gorev, GorevListDTO>();
            CreateMap<GorevListDTO, Gorev>();

            CreateMap<Gorev, GorevGuncelleDTO>();
            CreateMap<GorevGuncelleDTO, Gorev>();

            CreateMap<RolEkleDTO, Role>();
            CreateMap<Role, RolEkleDTO>();

            CreateMap<RolGuncelleDTO, Role>();
            CreateMap<Role, RolGuncelleDTO>();

            CreateMap<Rapor, RaporListDTO>();
            CreateMap<RaporListDTO, Rapor>();

            CreateMap<UserAddDTO, User>();
            CreateMap<User, UserAddDTO>();

            CreateMap<User, UserListDTO>();
            CreateMap<UserListDTO, User>();

            CreateMap<User, UserAddDTO>();
            CreateMap<UserAddDTO, User>();

            CreateMap<User, UserUpdateDTO>();
            CreateMap<UserUpdateDTO, User>();

            CreateMap<Rapor, RaporUpdateDTO>();
            CreateMap<RaporUpdateDTO, Rapor>();

            CreateMap<Rapor, RaporAddDTO>();
            CreateMap<RaporAddDTO, Rapor>();

            CreateMap<MessageAddDTO, Message>();
            CreateMap<Message, MessageAddDTO>();

            
        }
    }
}
