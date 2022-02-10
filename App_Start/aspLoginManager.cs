using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp.net_login.App_Start
{
    public class aspLoginSettings
    {
        public String DefaultPageText1 { get; set; }
        public String DefaultPageText2 { get; set; }
        public String HeaderText { get; set; }
        public String FooterText { get; set; }



    }
    public class aspLoginManager
    {
       
        public static aspLoginSettings LoadSettings(string FilPath)
        {
            aspLoginSettings Settings = new aspLoginSettings();
            try
            {
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(aspLoginSettings));
                System.IO.StreamReader file = new System.IO.StreamReader(FilPath);
                Settings = (aspLoginSettings)reader.Deserialize(file);
                file.Close();
                return Settings;
            }
            catch(Exception)
            {
                return Settings;
            }


        }
        public static void SaveSettings(string FilPath,aspLoginSettings SettingsObj)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(aspLoginSettings));

            var FileName = "SerializationOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(FilPath);

            writer.Serialize(file, SettingsObj);
            file.Close();
        }
    }
}