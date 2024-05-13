using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
}
public partial class Bai3
{
    public int Add()
    {
        return A + B;
    }
    public int Sub() { return A - B; }  
    public int Mul() { return A * B;}
    public int Div() 
    {
        if (B == 0)
        {
            Console.WriteLine("Dk Khong Thoa Dan");
        }
        return A / B;
    }
    
}
