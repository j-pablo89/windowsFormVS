﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Ut3.Tp5.Modelo;

public class Carnivoro: Mamifero
{
    public Carnivoro() : base(TipoAlimentacion.CARNIVORO)
    {
        
    }
    public static double PorcentajeExtra { get; } = 0.1;
    public static double PesoMaximo { get; } = 500;
}
