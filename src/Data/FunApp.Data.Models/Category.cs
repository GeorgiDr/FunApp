using FunApp.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunApp.Data.Models
{
    public class Category : BaseModel<int>
    {
        public string Name { get; set; }
    }
}
