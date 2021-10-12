using InfProtWpfApp1.Core;
using InfProtWpfApp1.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace InfProtWpfApp1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ObservableCollection<UserModel> Users = new ObservableCollection<UserModel>() {
            new UserModel() {
                IsAdmin = true,
                IsBlocked = false,
                IsConfined = true,
                IsHidden = Visibility.Visible,
                Login = "ADMIN",
                Password = GetMD5HashString("ADMIN" + "")
            }
        };
        public static UserModel CurrentUser = Users[0]; //tmp
        public static string DataKeyHash = GetMD5HashString("DefaultKey");
        public static bool ReadUsersData(string keyWord)
        {
            CurrentUser = null;
            Users.Clear();
            bool res = false;

            List<byte> inputBytes = new List<byte>();
            using (BinaryReader reader = new BinaryReader(File.Open(@"Data\UsersData.ipwa", FileMode.Open)))
            {
                while (true)
                {
                    try
                    {
                        inputBytes.Add(reader.ReadByte());
                    }
                    catch { break; }
                }

                DataKeyHash = AESEncDecryptData(inputBytes.GetRange(0, 32).ToArray(), "DefaultKey");
                if (GetMD5HashString(keyWord) == DataKeyHash)
                {
                    //string key = DataKeyHash.Remove(20, 4) + DataKeyHash.Remove(22, 2) + DataKeyHash.Remove(0, 2);

                    string rd = AESEncDecryptData(inputBytes.GetRange(32, inputBytes.Count - 32).ToArray(), DataKeyHash);

                    using (StringReader sw = new StringReader(rd))
                    {
                        XmlSerializer formatter = new XmlSerializer(typeof(UserModel[]));

                        UserModel[] newusers = (UserModel[])formatter.Deserialize(sw);

                        foreach (UserModel user in newusers)
                        {
                            user.IsHidden = Visibility.Visible;
                            Users.Add(user);
                        }
                    }
                    res = true;
                }
            }
            return res;
        }
        public static bool WriteUsersData(string keyWord = "")
        {
            if (keyWord != "" && GetMD5HashString(keyWord) != DataKeyHash)
                return false;

            XmlSerializer formatter = new XmlSerializer(typeof(UserModel[]));

            if (File.Exists(@"Data\UsersData.ipwa"))
                File.Delete(@"Data\UsersData.ipwa");

            string afterencrypt;
            
            using (StringWriter sw = new StringWriter())
            {
                formatter.Serialize(sw, Users.ToArray());

                afterencrypt = sw.ToString();
            }

            //string key = DataKeyHash.Remove(20, 4) + DataKeyHash.Remove(22, 2) + DataKeyHash.Remove(0, 2);

            using (BinaryWriter writer = new BinaryWriter(File.Open(@"Data\UsersData.ipwa", FileMode.OpenOrCreate)))
            {
                byte[] encryptKey = AESEncDecryptData(DataKeyHash, "DefaultKey");
                writer.Write(encryptKey);

                byte[] encryptBytes = AESEncDecryptData(afterencrypt, DataKeyHash);
                writer.Write(encryptBytes);
            }

            return true;
        }

        public static void OldWriteUsersData()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(UserModel[]));

            if (File.Exists(@"Data\UsersData.xml"))
                File.Delete(@"Data\UsersData.xml");

            using (FileStream fs = new FileStream(@"Data\UsersData.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Users.ToArray());
            }
        }

        public static string GenPassword(int length = 16)
        {
            string[] abc = { "qwertyuiopasdfghjklzxcvbnm","QWERTYUIOPASDFGHJKLZXCVBNM",",.!;:","0123456789", "-+=/*%^" };
            string pass = "";
            var r = new Random();
            while (pass.Length < length)
            {
                //Char c = (char)r.Next(33, 125);
                //if (Char.IsLetterOrDigit(c))
                pass += abc[pass.Length % 5][r.Next(abc[pass.Length % 5].Length)];
            }
            return pass;
        }

        public static bool VerificationPassword(string password, string login, bool IsConfined = false)
        {
            string pass = password.ToLower();
            string log = login.ToLower();

            if (!pass.Contains(log) && !log.Contains(pass))
                return !IsConfined
                    || (password.Any(c => ",.!;:".Contains(c)) 
                    && password.Any(c => "0123456789".Contains(c)) 
                    && password.Any(c => "-+=/*%^".Contains(c)));
            else
                return false;
        }

        public static string GetMD5HashString(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

        public static byte[] AESEncDecryptData(string input, string key)
        {
            byte[] hash;
            using (SHA256CryptoServiceProvider sha = new SHA256CryptoServiceProvider())
                hash = sha.ComputeHash(Encoding.UTF8.GetBytes(key));

            byte[] result = AesCryptor.EncryptStringToBytes_Aes(input, hash, Encoding.UTF8.GetBytes("01A2930508C0B0FE"));

            return result;
        }
        public static string AESEncDecryptData(byte[] input, string key)
        {
            byte[] hash;
            using (SHA256CryptoServiceProvider sha = new SHA256CryptoServiceProvider())
                hash = sha.ComputeHash(Encoding.UTF8.GetBytes(key));

            string result = AesCryptor.DecryptStringFromBytes_Aes(input, hash, Encoding.UTF8.GetBytes("01A2930508C0B0FE"));

            return result;
        }
    }
}
