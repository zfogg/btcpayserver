﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBitcoin;
using NBXplorer.DerivationStrategy;

namespace BTCPayServer.Events
{
    public class TxOutReceivedEvent
    {
        public BTCPayNetwork Network { get; set; }
        public Script ScriptPubKey { get; set; }
        public DerivationStrategyBase DerivationStrategy { get; set; }

        public override string ToString()
        {
            String address = ScriptPubKey.GetDestinationAddress(Network.NBitcoinNetwork)?.ToString() ?? ScriptPubKey.ToString();
            return $"{address} received a transaction ({Network.CryptoCode})";
        }
    }
}
