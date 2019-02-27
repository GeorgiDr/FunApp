using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunApp.Services.Models.Home
{
    public class IndexViewModel
    {
        public IEnumerable<IndexJokeViewModel> Jokes { get; set; }
    }
}
