using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
namespace InfoManager.DataAccess
{
    public class UserDataManager
    {
        public static void xmlAccess(string UserName, string PassWord, string Num)
        {
            string Path = "D:\\ProgramData\\";
            try 
            {
                if (!File.Exists(Path + "infoList.xml"))
                {
                    XmlDocument xml = new XmlDocument();
                    XmlElement config = xml.CreateElement("root");
                    xml.AppendChild(config);
                    XmlElement User = xml.CreateElement("UserName");
                    User.InnerText = UserName;
                    XmlElement Password = xml.CreateElement("PassName");
                    Password.InnerText = PassWord;
                    XmlElement Nm = xml.CreateElement("Num");
                    Nm.InnerText = Num;

                    config.AppendChild(User);
                    config.AppendChild(Password);
                    config.AppendChild(Nm);

                    xml.Save(Path + "infoList.xml");
                }
                XmlDocument xmldocument = new XmlDocument();
                xmldocument.Load(Path + "infoList.xml");
                XmlNode root = xmldocument.SelectSingleNode("root");
                
               
                XmlElement user = xmldocument.CreateElement("UserName");
                user.InnerText = UserName;
                root.AppendChild(user);

                XmlElement password = xmldocument.CreateElement("PassName");
                password.InnerText = PassWord;
                root.AppendChild(password);

                XmlElement num = xmldocument.CreateElement("Num");
                num.InnerText = Num;
                root.AppendChild(num);


                xmldocument.Save(Path + "infoList.xml");

                string fullPath = Path + Guid.NewGuid().ToString() + ".xml";
                if (!File.Exists(fullPath))
                {
                    XmlDocument xml2 = new XmlDocument();
                    XmlElement config2 = xml2.CreateElement("root");
                    xml2.AppendChild(config2);
                    XmlElement user2 = xml2.CreateElement("UserName");
                    user2.InnerText = UserName;
                    XmlElement password2 = xml2.CreateElement("PassName");
                    password2.InnerText = PassWord;
                    XmlElement num2 = xml2.CreateElement("Num");
                    num2.InnerText = Num;

                    config2.AppendChild(user2);
                    config2.AppendChild(password2);
                    config2.AppendChild(num2);

                    xml2.Save(fullPath);
                }
                else
                {
                    File.Delete(fullPath);
                    XmlDocument xml2 = new XmlDocument();
                    XmlElement config2 = xml2.CreateElement("root");
                    xml2.AppendChild(config2);
                    XmlElement user2 = xml2.CreateElement("UserName");
                    user2.InnerText = UserName;
                    XmlElement password2 = xml2.CreateElement("PassName");
                    password2.InnerText = PassWord;
                    XmlElement num2 = xml2.CreateElement("Num");
                    num2.InnerText = Num;

                    config2.AppendChild(user2);
                    config2.AppendChild(password2);
                    config2.AppendChild(num2);

                    xml2.Save(fullPath);
                }
            }  
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public bool hasExistPerson(string Number,string nodName = "UserName")
        {
            try
            {
                string Path = "D:\\ProgramData\\infoList.xml";
                if (!File.Exists(Path))
                {
                    return false;
                }
                else
                {
                    XmlDocument readDoc = new XmlDocument();
                    readDoc.Load(Path);
                    XmlNode Rootnode = readDoc.DocumentElement;
                    foreach (XmlNode node in Rootnode.ChildNodes)
                    {
                        if (node.Name.Equals(nodName) && node.Attributes[nodName].Value.Equals(Number))
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }
            
        }

        public static bool isMobile(string Mobile)
        {
            if (string.IsNullOrEmpty(Mobile))
                return false;
            return Regex.IsMatch(Mobile, @"^(1)\d{10}$");
        }

        public static bool isPassWord(string PassWord)
        {
            if (!string.IsNullOrEmpty(PassWord) && Regex.IsMatch(PassWord, @"^[a-zA-Z_0-9]{6,12}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isInvitationCode(string InvitationCode, string[] Codes)
        {
            if (!string .IsNullOrEmpty(InvitationCode))
            {
                foreach(string code in Codes)
                {
                    if (code.Equals(InvitationCode))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }        
    }
}
