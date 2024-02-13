using System.IO;
using System;
using Redlands.Abstract;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

namespace Redlands.Common.System
{
    public static class Save
    {
        public static readonly string PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Redlands";
        private static readonly string key = "ijfawnue2i1m23";
        public static void FindOrCreateBaseDirectory()
        {
            if (!Directory.Exists(PATH))
            {
                Directory.CreateDirectory(PATH);
                Directory.CreateDirectory(PATH + "/Entities");
            }
        }
        public static void SaveEntity(Entity entity)
        {
            string json = JsonConvert.SerializeObject(entity);
            File.WriteAllText(PATH + $"/Entities/{entity.name}.json", json);
        }
        public static Entity LoadEntity(Entity entity)
        {

            string json = File.ReadAllText(PATH + $"/Entities/{entity.name}.json");
            try
            {
                return JsonConvert.DeserializeObject<Entity>(json);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao carregar entidade");
            }
        }
        private static string Encrypt(string text)
        {
            byte[] bytesCriptografados = Convert.FromBase64String(text);
            byte[] bytesChave = Encoding.UTF8.GetBytes(key);
            using Aes aesAlg = Aes.Create();

            aesAlg.Key = bytesChave;
            aesAlg.IV = new byte[16]; // Pode ser gerado aleatoriamente e armazenado junto com o texto criptografado

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using MemoryStream msDecrypt = new MemoryStream(bytesCriptografados);
            using CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
            using StreamReader srDecrypt = new StreamReader(csDecrypt);
            return srDecrypt.ReadToEnd();
        }
        private static void Decrypt()
        {

        }

    }
}