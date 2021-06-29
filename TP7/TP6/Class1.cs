﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    class Calculadora
    {
        private float numero1;
        private float numero2;
        private DateTime fecha;
        private string operador;
        private float igual;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Operador { get => operador; set => operador = value; }
        public float Igual { get => igual; set => igual = value; }

        public float suma()
        {
            return Numero1 + Numero2;
        }
        public float resta()
        {
            return Numero1 - Numero2;
        }
        public float multiplicacion()
        {
            return Numero1 * Numero2;
        }
        public float division()
        {
            if(Numero2 != 0)
            {
                return Numero1 / numero2;
            }
            else
            {
                return 0;
            }
        }
    }
}
