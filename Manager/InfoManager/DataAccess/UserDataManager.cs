using System;
using System.IO;
using System.Xml;
namespace InfoManager.DataAccess
{
    public class UserDataManager
    {
        public void xmlAccess(string UserName, string PassWord, string Num)
        {
            string Path = "D:\\ProgramData\\";
            string fullPath = Path + Guid.NewGuid().ToString() + ".xml";
            if (!File.Exists(fullPath))
            {
                XmlDocument xml = new XmlDocument();
                XmlElement config = xml.CreateElement("root");
                xml.AppendChild(config);
                XmlElement user = xml.CreateElement("UserName");
                user.InnerText = UserName;
                XmlElement password = xml.CreateElement("PassName");
                password.InnerText = PassWord;
                XmlElement num = xml.CreateElement("Num");
                num.InnerText = Num;

                config.AppendChild(user);
                config.AppendChild(password);
                config.AppendChild(num);

                xml.Save(fullPath);
            }
            else
            {
                File.Delete(fullPath);
                XmlDocument xml = new XmlDocument();
                XmlElement config = xml.CreateElement("root");
                xml.AppendChild(config);
                XmlElement user = xml.CreateElement("UserName");
                user.InnerText = UserName;
                XmlElement password = xml.CreateElement("PassName");
                password.InnerText = PassWord;
                XmlElement num = xml.CreateElement("Num");
                num.InnerText = Num;

                config.AppendChild(user);
                config.AppendChild(password);
                config.AppendChild(num);

                xml.Save(fullPath);
            }
        }
    }
}
