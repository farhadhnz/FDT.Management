using FDT.Management.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDT.WindTurbineLib.Entities
{
    public class WindTurbine : DigitalTwin
    {
        public double RotorDiameter { get; set; }
        public double TowerHeight { get; set; }
    }
}
