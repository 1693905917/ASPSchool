using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

/// <summary>
/// Product 的摘要说明
/// </summary>
public class Product
{
    public struct Data
    {
        public string No;
        public string Name;       
        public decimal Cost;
        public decimal Total;
    }
    public Data GetData(int n, int num)
    {
        Data[] pro = new Data[100];
        string FilePath = System.Web.HttpContext.Current.Server.MapPath("App_Data/Data.txt");
        StreamReader sr = new StreamReader(FilePath, Encoding.GetEncoding("gb2312"));
        int i = 1;
        while (!sr.EndOfStream)		//循环读取文件的每一行，直到文件结束
        {
            pro[i].No = sr.ReadLine();
            pro[i].Name = sr.ReadLine();
            pro[i].Cost = decimal.Parse(sr.ReadLine());
            pro[i].Total = pro[i].Cost * num;
            i = i + 1;
        }
        sr.Close();
        return pro[n];
    }

    public bool CheckNo(int n)
    {
        string FilePath = System.Web.HttpContext.Current.Server.MapPath("App_Data/Data.txt");
        StreamReader sr = new StreamReader(FilePath, Encoding.GetEncoding("gb2312"));
        int i = 1;
        bool ispass = false; 
        while (!sr.EndOfStream)		//循环读取文件的每一行，直到文件结束
        {
            int no = int.Parse(sr.ReadLine());
            if (no == n)
            {
                ispass = true;
                break;
            }
            sr.ReadLine();
            sr.ReadLine();
            i = i + 1;
        }
        return ispass;
    }

}