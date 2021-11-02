using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DefinedFramework
{
    public class root
    {
        // fMain
        public static Color titleBarColor = Color.FromArgb(30, 31, 43);
        public static Color navBarColor = Color.FromArgb(22, 24, 33);
        public static Color screenColor = Color.FromArgb(40, 42, 58);

        // fHome
        public static Color navHomeOptionColor = Color.FromArgb(100, 0, 0);
        public static Color homePrimaryColor = Color.FromArgb(255, 72, 72);

        // fBill
        public static Color navBillOptionColor = Color.FromArgb(121, 61, 0);
        public static Color billPrimaryColor = Color.FromArgb(255, 128, 0);
        public static Color backColorComponentBill = Color.FromArgb(61, 64, 88);
        public static Color backGroundSideBarBill = Color.FromArgb(100, 50, 0);
        public static Color sideBarHeaderFooterBill = Color.FromArgb(90, 45, 0);
        public static Color darkerBackGroundSideBarBill = Color.FromArgb(55, 28, 0);

        // fGoods
        public static Color navGoodsOptionColor = Color.FromArgb(109, 29, 69);
        public static Color goodsPrimaryColor = Color.FromArgb(217, 108, 163);
        public static Color backColorComponentGoods = Color.FromArgb(61, 64, 88);
        public static Color backGroundSideBarGoods = Color.FromArgb(95, 24, 60);
        public static Color darkerBackGroundSideBarGoods = Color.FromArgb(61, 16, 38);
        public static Color buttonChoosingGoods = Color.FromArgb(126, 33, 80);

        // fContract
        public static Color navContractOptionColor = Color.FromArgb(20, 88, 73);
        public static Color contractPrimaryColor = Color.FromArgb(39, 166, 137);
        public static Color backColorComponentContract = Color.FromArgb(61, 64, 88);
        public static Color backGroundSideBarContract = Color.FromArgb(60, 100, 100);
        public static Color darkerBackGroundSideBarContract = Color.FromArgb(15, 43, 43);
        public static Color sideBarHeaderFooterContract = Color.FromArgb(47, 79, 79);
        public static Color buttonChoosingContract = Color.FromArgb(23, 100, 83);

        // fEmployee
        public static Color navEmployeeOptionColor = Color.FromArgb(0, 43, 85);
        public static Color employeePrimaryColor = Color.FromArgb(0, 128, 255);
        public static Color backColorComponentEmployee = Color.FromArgb(61, 64, 88);
        public static Color backGroundSideBarEmployee = Color.FromArgb(63, 81, 181);
        public static Color darkerBackGroundSideBarEmployee = Color.FromArgb(27, 34, 75);
        public static Color sideBarHeaderFooterEmployee = Color.FromArgb(50, 64, 143);

        // fChart
        public static Color navChartOptionColor = Color.FromArgb(100, 0, 100);
        public static Color chartPrimaryColor = Color.FromArgb(151, 0, 151);

        public static int borderCorner = 11;
        public static Color textColor = Color.FromArgb(255, 235, 205);
        public static string imageGoods = "Manager-Store\\GUI\\Images\\Goods\\";
        public static string imageEmployees = "Manager-Store\\GUI\\Images\\Employees\\";

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

        public static string ProjectPath()
        {
            string p = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            int temp = p.LastIndexOf("Manager-Store\\GUI\\bin");
            p = p.Remove(temp);
            return p;
        }

        public static string UpdateImageLocation(string currentPath, string newRelativePath, string absoluteNewPath)
        {
            try
            {
                if (File.Exists(absoluteNewPath))
                {
                    if (newRelativePath == null)
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        File.Delete(absoluteNewPath);
                    }
                    if (currentPath != absoluteNewPath)
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        File.Delete(absoluteNewPath);
                    }
                }
                if (newRelativePath != null && currentPath != absoluteNewPath)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Copy(currentPath, absoluteNewPath);
                }
            }
            catch (Exception e) { return e.Message; }
            return null;
        }
    }
}
