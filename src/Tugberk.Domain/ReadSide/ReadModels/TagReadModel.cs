using System.Collections.Generic;

namespace Tugberk.Domain.ReadSide.ReadModels
{
    public class TagReadModel
    {
        public string Name { get; set; }
        public IReadOnlyCollection<SlugReadModel> Slugs { get; set; }
        public int PostsCount { get; set; }
    }
}