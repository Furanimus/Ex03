using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Motorcycle : Vehicle
    {
        protected enum eLicenceType
        {
            A, A1, AB, B1
        }

        protected eLicenceType m_LicenceType;
        protected int m_EngineVolume;
    }
}
