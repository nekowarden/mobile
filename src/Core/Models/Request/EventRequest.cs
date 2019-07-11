﻿using Bit.Core.Enums;
using System;

namespace Bit.Core.Models.Request
{
    public class EventRequest
    {
        public EventType Type { get; set; }
        public string CipherId { get; set; }
        public DateTime Date { get; set; }
    }
}
