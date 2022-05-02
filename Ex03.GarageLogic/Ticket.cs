﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Ticket
    {
        public enum eCurrentStatus { InFixings, Fixed, Paid }

        Vehicle m_Vehicle;
        private string m_OwnersName;
        private string m_OwnersPhoneNumber;
        private eCurrentStatus m_CurrentStatus;

        public Ticket(Vehicle i_Vehicle)
        {
            m_Vehicle = i_Vehicle;
            m_OwnersName = i_Vehicle.VehicleOwner.Name;
            m_OwnersPhoneNumber = i_Vehicle.VehicleOwner.PhoneNumber;
            m_CurrentStatus = eCurrentStatus.InFixings;
        }

        public override int GetHashCode()
        {
            return m_OwnersPhoneNumber.GetHashCode();
        }

        public Vehicle Vehicle
        {
            get;
        }

        public string OwnerPhoneNumber
        {
            get;
            set;
        }   // not sure if needed --- check in the end

        public eCurrentStatus CurrentStatus
        {
            get;
            set;
        }
}
}
