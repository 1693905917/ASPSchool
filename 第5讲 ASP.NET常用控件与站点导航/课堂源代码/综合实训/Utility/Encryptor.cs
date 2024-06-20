using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Security;

namespace BBS.Utility
{
    public sealed class Encryptor
    {
        /// <summary>
        /// �Ի�Ա���롢��ȫ����𰸽���MD5����
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string MD5Encrypt(string text)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(text, "MD5");

        }
        /// <summary>
        /// �Ի�ԱԱ���롢��ȫ����𰸽���SHA1����
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string SHA1Encrypt(string text)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(text, "SHA1");

        }
    }

}
