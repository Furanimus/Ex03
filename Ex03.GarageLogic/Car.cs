using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Car : Vehicle //Maybe Internal??
    {
        protected enum eColor
        {
            Yellow, White, Red, Black
        }

        protected eColor m_Color;
        protected int m_NumOfDoors; // Make enum as well? 2, 3, 4, 5

        protected eColor Color
        {
            get
            {
                return m_Color;
            }
            set
            {
                m_Color = value;
            }
        }
    }
}
