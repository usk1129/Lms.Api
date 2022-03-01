using AutoMapper;
using Lms.core.Entities;
using Lms.core.Lms.Core.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Data.Data
{
    public class LmsMappings: Profile
    {
        public LmsMappings()
        {

            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Module, ModuleDto>().ReverseMap();
            CreateMap<JsonPatchDocument<CourseDto>, JsonPatchDocument<Course>>().ReverseMap();
            CreateMap<JsonPatchDocument<ModuleDto>, JsonPatchDocument<Module>>().ReverseMap();

            CreateMap<Operation<CourseDto>, Operation<Course>>();
            CreateMap<Operation<ModuleDto>, Operation<Module>>();

        }
    }
}
