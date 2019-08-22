using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Truck : GasolineVehicle
    {
        private bool v_DoesDeliverHazardousCargo;
        private float m_CargoCapacity;

        public bool DoesDeliverHazardousCargo
        {
            get
            {
                return v_DoesDeliverHazardousCargo;
            }
            set
            {
                v_DoesDeliverHazardousCargo = value;
            }
        }

        public float CargoCapacity
        {
            get
            {
                return m_CargoCapacity;
            }
            set
            {
                m_CargoCapacity = value;
            }
        }
    }
}
