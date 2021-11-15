using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
        public static Color backGroundSideBarBill = Color.FromArgb(105, 37, 0);
        public static Color sideBarHeaderFooterBill = Color.FromArgb(77, 27, 0);
        public static Color darkerBackGroundSideBarBill = Color.FromArgb(38, 15, 0);

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

        public static string UpdateImageLocation(string currentPath, string newRelativePath, string newAbsolutePath)
        {
            try
            {
                if (File.Exists(newAbsolutePath))
                {
                    if (newRelativePath == null || currentPath != newAbsolutePath)
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        File.Delete(newAbsolutePath);
                    }
                }
                if (newRelativePath != null && currentPath != newAbsolutePath)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Copy(currentPath, newAbsolutePath);
                }
            }
            catch (IOException e) { return e.Message; }
            return null;
        }

        public static string MoneyFormat(string s)
        {
            if (string.IsNullOrEmpty(s.Trim()))
                s = "0";
            for (int i = s.Length - 3; i > 0; i -= 3)
                s = s.Insert(i, ".");
            return s + " đ";
        }

        public static string TurnOffMoneyFormat(string s)
        {
            if (s.ToLower().Contains(" "))
            {
                int len = s.Length;
                return s.Remove(len - 2).Replace(".", "");
            }
            return s;
        }

        public static DialogResult MyMessageBox(string text, string caption, string btn1, string btn2, string btn3)
        {
            MessageBoxManager.Yes = btn1;
            MessageBoxManager.No = btn2;
            MessageBoxManager.Cancel = btn3;
            MessageBoxManager.Register();
            DialogResult option = MessageBox.Show(text, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            MessageBoxManager.Unregister();
            return option;
        }
    }
}
