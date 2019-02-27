using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FunApp.Web.Model.Jokes
{
    public partial class CreateJokeInputModel
    {
        [Required]
        [MinLength(20)]
        public string Content { get; set; }

        [ValidCategoryId]
        public int CategoryId { get; set; }
    }
}
