using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Com
    {
        private static string strSettingXmlFile = ".\\Settings.xml";

        public static string SettingXmlFile
        {
            get { return strSettingXmlFile; }
        }
    }
}
