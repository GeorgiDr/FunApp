using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FunApp.Data.Models;
using FunApp.Services.Mapping;

namespace FunApp.Services.Models.Home
{
    public class IndexJokeViewModel : IMapFrom<Joke>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string CategoryName { get; set; }

        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
         // configuration.CreateMap<Joke,IndexJokeViewModel>
         //     ().ForMember(x => x.CategoryName, x => x.MapFrom(j => j.Category.Name));
        }
    }

}
