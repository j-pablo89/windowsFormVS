using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Ut3.Tp5.Modelo;

public class Sector
{
    public Sector()
    {
        Animales = new List<Mamifero>();
    }

    public int Numero { get; init; }
    public double Latitud { get; init; }
    public double Longitud { get; init;}
    public int Limite { get; init; }
    public TipoAlimentacion TipoAlimentacion { get; init; }

    public Empleado? Empleado { get; init; }
    List<Mamifero> Animales { get; }

    public override string ToString() => $"[{Numero}] {TipoAlimentacion}";
    
}
