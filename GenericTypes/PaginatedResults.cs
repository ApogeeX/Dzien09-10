using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    internal class PaginatedResults<T>
    {
        public List<T> Ts { get; set; }
        public int ResultsFrom { get; set; }
        public int ResultsTo { get; set; }
        public int TotalResults { get; set; }
    }
}
