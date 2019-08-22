using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class ElectricalVehicle : Vehicle
    {
        protected class Battery
        {
            private float m_TimeLeft;
            private Nullable<float> k_MaxTime;

            protected float TimeLeft
            {
                get
                {
                    return m_TimeLeft;
                }
                set
                {
                    m_TimeLeft = value;
                }
            }

            protected Nullable<float> MaxTime
            {
                get
                {
                    return k_MaxTime;
                }
                set
                {
                    k_MaxTime = value;
                }
            }

            public void Charge (float i_toCharge) //TODO handle exception with exceeding value
            {
                m_TimeLeft += i_toCharge;
            }
        }

        protected Battery m_Battery;
    }
}
