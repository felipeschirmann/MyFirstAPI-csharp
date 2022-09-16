using System.Collections.Generic;

namespace MyFirstAPI.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
