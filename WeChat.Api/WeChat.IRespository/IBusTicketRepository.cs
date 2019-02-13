﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.Model;

namespace WeChat.IRespository
{
    public interface IBusTicketRepository
    {
        List<BusIndent> BusIndents();

        List<BusIndent> GetBusIndents();

        List<BusIndent> GetBusIndentsByState();


    }
}