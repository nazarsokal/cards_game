using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Cards_Game
{
    public static class XmlConvert
    {
        public static List<string> Serialize<T>(List<T> item)
        {
            var props = item.GetType().GetProperties();
            List<string> prps_strs = new List<string>();
            prps_strs.Add("<root>");
            var i = 0;
            for(var j = 0; j < item.Count; j++)
            {
                prps_strs.Add($"<{item[i].GetType().GetProperties()}>{props.GetValue(i).ToString()}</{item[i].GetType().GetProperties()}>");
                i++;
                if (i == 3)
                {
                    prps_strs.Add("\n");
                    i = 0;
                }
            }
          
            prps_strs.Add("</root>\n");

            return prps_strs;
        }
    }
}
