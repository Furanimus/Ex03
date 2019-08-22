using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class GasolineVehicle : Vehicle
    {
        protected enum eGas
        {
            Soler, Octan95, Octan96, Octan98
        }

        protected eGas m_GasType;
        protected float m_CurrentGasInTank;
        protected float m_MaxCapacityOfTank;

        protected eGas GasType
        {
            get
            {
                return m_GasType;
            }
            set
            {
                m_GasType = value;
            }
        }

        protected void addFuel (float i_amountToFuel)
        {
            if (doesExceedMaxCapacityOfTank(i_amountToFuel)) // Needs to be handled with an exception
            {
                //Console.WriteLine("Can't fuel the amount provided as it exceeds the maximum capcity of gas tank.");
            }
            else
            {
                m_ener += i_amountToFuel;
            }
        }

        private bool doesExceedMaxCapacityOfTank(float i_amountToFuel)
        {
            return (m_CurrentGasInTank + i_amountToFuel > m_MaxCapacityOfTank);
        }
    }
}
