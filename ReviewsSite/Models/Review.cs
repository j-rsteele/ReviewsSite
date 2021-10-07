using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string Name { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
