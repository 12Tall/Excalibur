using System;
using System.Text.RegularExpressions;

namespace Excalibur
{
    public static class ExString
    {
        /// <summary>
        /// 判断当前字符串是否是电子邮件地址
        /// </summary>
        /// <example>_12.tall@163.com</example>
        /// <param name="str">字符串</param>
        /// <returns></returns>
        public static bool IsEmail(this string str)
        {
            // 以字母/数字/下(中)划线开始
            // 中间可以是字母/数字/下(中)划线/小数点
            // @ 符号之后是域名信息/IP地址
            Regex regex = new Regex(@"^[A-Za-z\d_-]+([-_.][A-Za-z\d]+)*@([A-Za-z\d]+[-.])+[A-Za-z\d]{1,4}$");
            return regex.IsMatch(str);
        }
    }
}