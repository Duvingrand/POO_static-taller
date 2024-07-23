using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models;

public class Configuracion
{
    //False=oscuro, True=light
    public static bool ModoOscuro { get; set; }=true;

    public static void CambiarModo(){
        if (ModoOscuro==true)
        {
            ModoOscuro=false;
            Console.WriteLine(ModoOscuro);
        } else{
            ModoOscuro=true;
            Console.WriteLine(ModoOscuro);
        }
        
    }
    

}
