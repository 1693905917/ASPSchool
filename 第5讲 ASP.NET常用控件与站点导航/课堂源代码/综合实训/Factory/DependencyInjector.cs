using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Web;
using System.Web.Caching;
using BBS.Utility;

//����ע��
namespace BBS.Factory
{
    public sealed class DependencyInjector
    {
        //ͨ�������������ݷ��ʲ�Ķ�Ӧ�Ķ���
        public static object GetDALObject(string className)
        {
            //�ӻ�����ȡ
            object dal = CacheAccess.GetFromCache("DAL");
            //������ڻ����оʹ������ļ���ȡ�����ݷ��ʲ�������ռ䣬�����뻺����
            if (dal == null)
            {
                CacheDependency fileDependency = new CacheDependency(HttpContext.Current.Server.MapPath("Web.Config"));
                dal = ConfigurationManager.AppSettings["DAL"];
                CacheAccess.SaveToCache("DAL", dal, fileDependency);
            }
            string dalName = (string)dal;
            string fullClassName = "BBS."+dalName + "." + className;
            object dalObject = CacheAccess.GetFromCache(className);
            //�ӳ��򼯼�����Ҫ��Ķ���
            if (dalObject == null)
            {
                CacheDependency fileDependency = new CacheDependency(HttpContext.Current.Server.MapPath("Web.Config"));
                dalObject = Assembly.Load(dalName).CreateInstance(fullClassName);
                CacheAccess.SaveToCache(className, dalObject, fileDependency);
            }
            return dalObject;
        }

        //ͨ����������ҵ���߼���Ķ�Ӧ�Ķ���
        public static object GetBLLObject(string className)
        {
            //�ӻ�����ȡ
            object bll = CacheAccess.GetFromCache("BLL");
            //������ڻ���ʹ������ļ���ȡ��ҵ���߼���������ռ䣬�����뻺��
            if (bll ==null)
            {
                CacheDependency fileDependency = new CacheDependency(HttpContext.Current.Server.MapPath("Web.Config"));
                bll =ConfigurationManager.AppSettings["BLL"];
                CacheAccess.SaveToCache("BLL", bll, fileDependency);
            }
            string bllName = (string)bll;
            string fullClassName = "BBS."+bllName + "." + className;
            object bllObject = CacheAccess.GetFromCache(className);
            //�ӳ����м�����Ҫ��Ķ���
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
