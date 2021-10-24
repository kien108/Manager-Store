using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DefinedFramework
{
    public class root
    {
        public static Color primaryColor = Color.FromArgb(39, 166, 137);
        public static Color primaryColor2 = Color.FromArgb(22, 97, 80);
        public static Color defaultColor = Color.FromArgb(17, 17, 17);
        public static Color textColor = Color.FromArgb(255, 235, 205);
        public static Color backColor = Color.FromArgb(255, 249, 238);
        public static int borderCorner = 11;
        public static Color popupColor = Color.LightYellow;
        public static bool IsNummerics(string s)
        {
            int x;
            if (int.TryParse(s, out x))
                return true;
            return false;
        }
        public static string RemoveSignOfVietnameseString(string s)
        {
            string[] vietnameseSigns = new string[]
            {
                "aáàạảãâấầậẩẫăắằặẳẵ",
                "AÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
                "eéèẹẻẽêếềệểễ",
                "EÉÈẸẺẼÊẾỀỆỂỄ",
                "oóòọỏõôốồộổỗơớờợởỡ",
                "OÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
                "uúùụủũưứừựửữ",
                "UÚÙỤỦŨƯỨỪỰỬỮ", 
                "iíìịỉĩ",
                "IÍÌỊỈĨ",
                "dđ",
                "DĐ",
                "yýỳỵỷỹ",
                "YÝỲỴỶỸ"
            };
            for (int i = 0; i < vietnameseSigns.Length; i++)
                for (int j = 1; j < vietnameseSigns[i].Length; j++)
                    s = s.Replace(vietnameseSigns[i][j], vietnameseSigns[i][0]);
            return s;
        }

        public static string MoneyShow(string price)
        {
            for (int i = price.Length - 3; i > 0; i -= 3)
                price = price.Insert(i, ".");
            return price;
        }
    }
}
