﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetFoo.Client
{
    public interface ICreateReportServiceProxy
    {
        Task<CreateReportResult> CreateReportAsync(string title, string description, 
            decimal longitude, decimal latitude);
    }
}
