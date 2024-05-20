using System;
using AutoMapper;

namespace api.Profiles
{
	public class AutoMapperProfiles : Profile
	{
		public AutoMapperProfiles()
		{
			CreateMap<DataModels.Student, DomainModels.Student>().ReverseMap();
            
        }
	}
}

