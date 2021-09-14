using AutoMapper;
using AutoMapperDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperDemo.ModelView
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserModelView>()
                .ForMember(dest => dest.FName,
                opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LName,
                opt => opt.MapFrom(src => src.LastName));
        }
    }
}
