using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models;

public class Contador
{
    public static int TotalContadores { get; set; }

    static Contador()
    {
        TotalContadores=0;
    }

    public static void Incrementar(){
        TotalContadores++;
        Console.WriteLine(TotalContadores);
    }

}
