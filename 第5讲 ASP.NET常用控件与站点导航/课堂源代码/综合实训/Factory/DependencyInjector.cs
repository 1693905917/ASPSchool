using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Web;
using System.Web.Caching;
using BBS.Utility;

//缓存注入
namespace BBS.Factory
{
    public sealed class DependencyInjector
    {
        //通过类名返回数据访问层的对应的对象
        public static object GetDALObject(string className)
        {
            //从缓存中取
            object dal = CacheAccess.GetFromCache("DAL");
            //如果不在缓存中就从配置文件中取出数据访问层的命名空间，并存入缓存中
            if (dal == null)
            {
                CacheDependency fileDependency = new CacheDependency(HttpContext.Current.Server.MapPath("Web.Config"));
                dal = ConfigurationManager.AppSettings["DAL"];
                CacheAccess.SaveToCache("DAL", dal, fileDependency);
            }
            string dalName = (string)dal;
            string fullClassName = "BBS."+dalName + "." + className;
            object dalObject = CacheAccess.GetFromCache(className);
            //从程序集加载所要求的对象
            if (dalObject == null)
            {
                CacheDependency fileDependency = new CacheDependency(HttpContext.Current.Server.MapPath("Web.Config"));
                dalObject = Assembly.Load(dalName).CreateInstance(fullClassName);
                CacheAccess.SaveToCache(className, dalObject, fileDependency);
            }
            return dalObject;
        }

        //通过类名返回业务逻辑层的对应的对象
        public static object GetBLLObject(string className)
        {
            //从缓存中取
            object bll = CacheAccess.GetFromCache("BLL");
            //如果不在缓存就从配置文件中取出业务逻辑层的命名空间，并存入缓存
            if (bll ==null)
            {
                CacheDependency fileDependency = new CacheDependency(HttpContext.Current.Server.MapPath("Web.Config"));
                bll =ConfigurationManager.AppSettings["BLL"];
                CacheAccess.SaveToCache("BLL", bll, fileDependency);
            }
            string bllName = (string)bll;
            string fullClassName = "BBS."+bllName + "." + className;
            object bllObject = CacheAccess.GetFromCache(className);
            //从程序集中加载所要求的对象
            if (bllObject == null)
            {
                CacheDependency fileDependency = new CacheDependency(HttpContext.Current.Server.MapPath("Web.Config"));
                bllObject = System.Reflection.Assembly.Load(bllName).CreateInstance(fullClassName);
                CacheAccess.SaveToCache(className, bllObject, fileDependency);
            }

            return bllObject;
        }
    }

}
