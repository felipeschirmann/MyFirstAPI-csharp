using MyFirstAPI.Hypermedia.Abstract;
using System.Collections.Generic;

namespace MyFirstAPI.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
