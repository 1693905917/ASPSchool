using System;
using System.Web;
using System.Web.Caching;


namespace BBS.Utility
{
    public sealed class CacheAccess
    {
        /// <summary>
        /// 存到缓存中
        /// </summary>
        /// <param name="cacheKey"></param>
        /// <param name="cacheObject"></param>
        /// <param name="dependency"></param>
        public static void SaveToCache(string cacheKey, object cacheObject, CacheDependency dependency)
        {
            Cache cache = HttpRuntime.Cache;
            cache.Insert(cacheKey, cacheObject, dependency);
            
        }
        /// <summary>
        /// 从缓存中取
        /// </summary>
        /// <param name="cacheKey"></param>
        /// <returns></returns>
        public static object GetFromCache(string cacheKey)
        {
            Cache cache = HttpRuntime.Cache;
            return cache[cacheKey];
        }
    }
}
