﻿using System;

namespace Alura.LeilaoOnline.Core
{
    public class Lance
    {
        public Interessada Cliente { get; }
        public double Valor { get; }

        public Lance(Interessada cliente, double valor)
        {
            if(valor <0)
            {
                throw new System.ArgumentException("Valor negativo não aceitável");
            }


            Cliente = cliente;
            Valor = valor;
        }
    }
}
