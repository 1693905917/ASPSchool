using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Security;

namespace BBS.Utility
{
    public sealed class Encryptor
    {
        /// <summary>
        /// 对会员密码、安全问题答案进行MD5加密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string MD5Encrypt(string text)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(text, "MD5");

        }
        /// <summary>
        /// 对会员员密码、安全问题答案进行SHA1加密
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string SHA1Encrypt(string text)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(text, "SHA1");

        }
    }

}
