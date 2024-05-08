namespace FactoryWithComposition.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class CacheService : ICacheService
    {
        public string GetCacheKey(string key)
        {
            return "Test";
        }
    }
}
