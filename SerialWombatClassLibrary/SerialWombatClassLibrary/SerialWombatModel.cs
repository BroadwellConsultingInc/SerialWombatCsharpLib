using System;
using System.Collections.Generic;
using System.Text;

namespace SerialWombat
{
    public enum SerialWombatModel
    {
        SerialWombat4A = 0x303441,
        SerialWombat4B = 0x303442,
        SerialWombat18AB = 0x313841,
        SerialWombat8B = 0x3003842,
        Other = 0xFFFFFF,
    }
}
