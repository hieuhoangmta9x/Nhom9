using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Helper
{
    class Component
    {
        public static string GetMovePathImage(string img)
        {
            string path = "";
            string[] tmp;
            if (img != "")
            {
                tmp = img.Split('\\');
                string[] s = tmp[tmp.Length - 1].Split('.');
                s[0] = s[0] + DateTime.Now.GetHashCode();
                path = "\\NhanSu\\" + s[0] + "." + s[1];
            }
            return path;
        }
    }
}
