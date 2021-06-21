using AutoMapper;
using Entities.Models;
using RolePasswordManager.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolePasswordManager.Profiles
{
    public class DefaultProfile : Profile
    {
        public DefaultProfile()
        {
            CreateMap<RegisterRequest, User>()
                .ForMember(dest=>dest.UserName,opt=>opt.MapFrom(src=>src.Email));
        }
    }
}
