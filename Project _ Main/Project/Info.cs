using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Project
{
    class Info
    {
        static public string PC_name = System.Environment.UserName.ToString();
        static public string DB_path = @"C:\Users\" + PC_name + @"\Documents\football_DB.mdf";
        static public string DB_connect = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\football_DB.mdf;Integrated Security=SSPI";

       

    }

}
