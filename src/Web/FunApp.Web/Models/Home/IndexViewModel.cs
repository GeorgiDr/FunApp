using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunApp.Web.Models.Home
{
    public class IndexViewModel
    {
        public IEnumerable<IndexJokeViewModel> Jokes { get; set; }
    }
}
