﻿using API.DTOs;
using API.Entities;
using API.Extensions;
using AutoMapper;

namespace API.Helpers;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<AppUser, MemberDto>().ForMember(d => d.Age,
                m => m.MapFrom(u => u.DateOfBirth.CalculateAge()))
            .ForMember(d => d.PhotoUrl,
            m => m
                .MapFrom(u => u.Photos.FirstOrDefault(p => p.IsMain)!.Url));
        CreateMap<Photo, PhotoDto>();
        CreateMap<MemberUpdateDto, AppUser>();
    }
}