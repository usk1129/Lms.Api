﻿using AutoMapper;
using Lms.core.Entities;
using Lms.core.Lms.Core.Dto;
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



        }
    }
}
