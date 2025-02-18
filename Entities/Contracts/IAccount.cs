﻿using System;

namespace Entities.Contracts
{
    public interface IAccount
    {
        Guid AccountID { get; set; }
        long AccountNumber { get; set; }
        decimal Balance { get; set; }
        Guid CustomerID { get; set; }
    }
}
