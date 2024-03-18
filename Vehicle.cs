using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS2A.ClassObject
{
    /// <summary>
    /// <author>Guilherme</author>
    /// </summary>
    public abstract class Vehicle
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public double VelocidadeAtual { get; set; }
        public bool MotorLigado { get; set; }
    }
}