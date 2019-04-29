using System;
using Excalibur;
using Xunit;

namespace ExTest
{
    public class StringTest
    {
        [Fact]
        public void IsEmail()
        {
            bool domain = "_12.tall@163.com".IsEmail();
            bool ip = "_12.tall@192.168.1.1".IsEmail();
        }
    }
}
