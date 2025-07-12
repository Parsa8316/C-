using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBot
{
    public static class Token
    {
        private const string token = "your-token";

        public static string GetToken()
        {
            return token;
        }
    }
}
