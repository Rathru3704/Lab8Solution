﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Solution.Entities
{
    public enum CustomerStatus
    {
        REGULAR,
        PREMIER
    }

    public enum TransactionResult
    {
        SUCCESS,
        INSUFFICIENT_FUND,
        EXCEED_MAX_WITHDRAW_AMOUNT
    }

    public enum TransactionType
    {
        DEPOSIT,
        WITHDRAW,
        PENALTY,
        TRANSFER_OUT,
        TRANSFER_IN,
    }
}
