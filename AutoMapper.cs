using AutoMapper;
using AutoMapper2._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapper2._1.AutoMapper
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<vmCreate, Student>();
            CreateMap<Student, vmList>();

            CreateMap<vmEdit, Student>();
            CreateMap<Student, vmDetails>();
        }
    }
}
