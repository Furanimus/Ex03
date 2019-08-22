using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        protected class Wheel
        {
            private string m_ManufacturerName;
            private float m_CurrentPressure;
            private float m_MaxPressure;
                
        }

        protected string m_ModelName;
        protected string m_LicencePlate;
        protected float m_EnergyLeft;

    }
}
