using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models;

public class MatematicaUtil
{
    public int Prim { get; set; }
    public int Second { get; set; }

    public  MatematicaUtil (int prim, int second)
    {
        Prim=prim;
        Second=second;
    }

    public void Suma(){Console.WriteLine(Prim+Second);}
    public void Resta(){Console.WriteLine(Prim-Second);}
    public void Multi(){Console.WriteLine(Prim*Second);}

}
