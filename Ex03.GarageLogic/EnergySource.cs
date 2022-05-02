﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class EnergySource
    {
        protected float m_MaxEnrgy;
        protected float m_CurrentEnrgy;

        virtual public void FillEnergy(float i_AmountToFill)
        {
            float newEnergyAmount = m_CurrentEnrgy + i_AmountToFill;

            if (newEnergyAmount < m_MaxEnrgy)
            {
                m_CurrentEnrgy = newEnergyAmount;
            }
            else
            {
                throw new ValueOutOfRangeException();
            }
        }

        public float EnergyPercentage
        {
            get
            {
                return ((m_CurrentEnrgy / m_MaxEnrgy) * 100);
            }
        }
    }
}