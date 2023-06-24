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
                    XmlElement Config = xml.CreateElement("Root");
                    xml.AppendChild(Config);
                    XmlElement workerNode = xml.CreateElement("Worker");
                    XmlElement User = xml.CreateElement("UserName");
                    User.InnerText = UserName;
                    workerNode.AppendChild(User);
                    XmlElement Password = xml.CreateElement("PassName");
                    Password.InnerText = PassWord;
                    workerNode.AppendChild(Password);
                    XmlElement Nm = xml.CreateElement("Num");
                    Nm.InnerText = Num;
                    workerNode.AppendChild(Nm);
                    Config.AppendChild(workerNode);

                    xml.Save(Path + "infoList.xml");
                }
                else
                {
                    XmlDocument xmldocument = new XmlDocument();
                    xmldocument.Load(Path + "infoList.xml");
                    XmlNode root = xmldocument.SelectSingleNode("Root");

                    XmlElement WorkerNode = xmldocument.CreateElement("Worker");

                    XmlElement user = xmldocument.CreateElement("UserName");
                    user.InnerText = UserName;
                    WorkerNode.AppendChild(user);

                    XmlElement password = xmldocument.CreateElement("PassName");
                    password.InnerText = PassWord;
                    WorkerNode.AppendChild(password);

                    XmlElement num = xmldocument.CreateElement("Num");
                    num.InnerText = Num;
                    WorkerNode.AppendChild(num);
                    root.AppendChild(WorkerNode);

                    xmldocument.Save(Path + "infoList.xml");
                }                
            }  
            catch (Exception exception)
            {
                throw exception;
            }           
        }


        public static bool isPassWordCorrect(string Number, string PassWord)
        {
            string Path = "D:\\ProgramData\\infoList.xml";
            XmlDocument readDoc = new XmlDocument();
            readDoc.Load(Path);
            XmlNode Rootnode = readDoc.DocumentElement;
            foreach (XmlNode node in Rootnode.ChildNodes)
            {
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    if (PassWord.Equals(node2.InnerText) && Number.Equals(node.FirstChild.InnerText))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool hasExistPerson(string Number,string nodName = "UserName")
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
                        foreach (XmlNode node2 in node.ChildNodes)
                        {
                            if (nodName.Equals(node2.Name) && Number.Equals(node2.InnerText))
                            {
                                return true;
                            }
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
