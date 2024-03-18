using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS2A.ClassObject
{
    public class Airplane : Vehicle
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public double VelocidadeAtual { get; set; }
        public bool MotorLigado { get; set; }

        public void LigarMotor()
        {

        }

        public void DesligarMotor()
        {

        }
    }
}