using System.Security.Cryptography;
using System.Text;

namespace Entra21.MiAuDota.Repositorio.Utils
{
    public class Criptografia
    {
        public static string Criptografar(string entrada)
        {

            if (String.IsNullOrEmpty(entrada))
                throw new ArgumentNullException(nameof(entrada));

            MD5 mD5 = MD5.Create();
            byte[] entradaBytes = Encoding.UTF8.GetBytes(entrada);
            byte[] hash = mD5.ComputeHash(entradaBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}