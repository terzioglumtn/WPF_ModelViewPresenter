using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_MVP.View
{
    public interface ILogin
    {
        string Username     { get; set; }
        string Password     { get; set; }
        
        string Onay_Durum   { get; set; }
    }
}
