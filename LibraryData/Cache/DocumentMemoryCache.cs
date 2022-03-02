using Microsoft.Extensions.Caching.Memory;
using System;

namespace LibraryData.Cache
{
    public class DocumentMemoryCache<TItem>
    {
        private readonly MemoryCache _cache = new MemoryCache(new MemoryCacheOptions()
        {
            SizeLimit = 1024
        });

        public TItem GetOrCreate(object key, Func<TItem> createItem, MemoryCacheEntryOptions cacheEntryOptions)
        {
            if (!_cache.TryGetValue(key, out TItem cacheEntry))
            {
                cacheEntry = createItem();

                _cache.Set(key, cacheEntry, cacheEntryOptions);
            }

            return cacheEntry;
        }
    }
}
