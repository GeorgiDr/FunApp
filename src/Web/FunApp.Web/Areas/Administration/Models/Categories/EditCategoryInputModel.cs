using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FunApp.Data.Models;
using FunApp.Services.Mapping;

namespace FunApp.Web.Areas.Administration.Models.Categories
{
    public class EditCategoryInputModel : IMapTo<Category>, IHaveCustomMappings
    {
        public string Name { get; set; }


        // Mapping Id Categories
        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<EditCategoryInputModel, Category>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
