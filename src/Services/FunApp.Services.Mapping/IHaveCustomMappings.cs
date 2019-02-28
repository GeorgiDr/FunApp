using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunApp.Services.Mapping
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IMapperConfigurationExpression configuration);
    }
}
