using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Controlador
{
    public class Validacion
    {        
          public static string GetMD5(string str)
          {
              MD5 md5 = MD5CryptoServiceProvider.Create();
              ASCIIEncoding encoding = new ASCIIEncoding();
              byte[] stream = null;
              StringBuilder sb = new StringBuilder();
              stream = md5.ComputeHash(encoding.GetBytes(str));
              for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
              return sb.ToString();
          }    
          public static string Descrypter(string descryp)
          {
            string resultado = string.Empty;
            byte[] descryted = Convert.FromBase64String(descryp);
            resultado = System.Text.Encoding.Unicode.GetString(descryted, 0, descryted.ToArray().Length);
            resultado = System.Text.Encoding.Unicode.GetString(descryted);
            return resultado;
          }
    }
}
