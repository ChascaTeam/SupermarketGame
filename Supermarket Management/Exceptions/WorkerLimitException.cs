﻿using System;

namespace Supermarket.Management.Exceptions
{
    public class WorkerLimitException : Exception
    {
        public const string WorkerLimit = "You cant have more than 5 active workers!";

        public WorkerLimitException()
            : base(WorkerLimit)
        {
        }

        public WorkerLimitException(string message)
            : base(message)
        {
        }
    }
}
