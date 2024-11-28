using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YunsLoft
{
    internal class GlobalVar
    {



        public static string image_dir = @"C:\Users\yunyu\OneDrive\桌面\Yun\Project\YuNS_image";
        public static string strDBconnectionString = "";

        public static List<ArrayList> list訂購品項集合 = new List<ArrayList>();
        public static List<ArrayList> list會員資料 = new List<ArrayList>();
        public static List<ArrayList> list員工資料 = new List<ArrayList>();


        public static bool is登入成功 = false;
        public static string 使用者名稱 = "";
        public static int 使用者id = 0;
        public static int 使用者權限 = 0;
        public static int 使用者角色 = 0;//Cus 2 emp 1

        










    }
}
