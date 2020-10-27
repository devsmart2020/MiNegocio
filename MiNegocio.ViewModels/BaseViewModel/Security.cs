using System;
using System.Text;

namespace MiNegocio.ViewModels.BaseViewModel
{
    static class Security
    {
        public static string Encrypt(string text)
        {            
            byte[] encrypted = Encoding.Unicode.GetBytes(text);
            return Convert.ToBase64String(encrypted);            
        }
    }
}
