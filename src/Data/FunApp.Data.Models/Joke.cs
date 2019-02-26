using FunApp.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunApp.Data.Models
{
    public class Joke : BaseModel<int>
    {
        public string Content { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
