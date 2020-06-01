﻿using System.Collections.Generic;

namespace Otc.Messaging.RabbitMQ.Configurations
{
    /// <summary>
    /// Represents a topogy configuration with a set of Exchanges
    /// </summary>
    public class Topology
    {
        /// <summary>
        /// List of exchanges in this topology
        /// </summary>
        public IEnumerable<Exchange> Exchanges { get; set; }
    }
}