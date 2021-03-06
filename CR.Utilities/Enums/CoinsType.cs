﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Utilities.Enums
{
    public enum CoinsType
    {
        NONE = 0,
        [Description("A709E247-2909-4EBB-9514-C5501CC8080E")]
        Efectivo = 1,
        [Description("22C82E75-111A-4FCA-B095-F3083326CA2F")]
        Deposito= 2,
        [Description("3B08644F-157B-42DF-B760-22486232F964")]
        Credito= 3,
        [Description("1A357A2B-735C-416D-B283-68988C85856E")]
        Tarjeta= 4,
        [Description("849ED6AE-381F-4FF7-91C5-325FD8CF936A")]
        Transferencia = 5
    }
}