﻿using Blockcore.Consensus.BlockInfo;
using Blockcore.NBitcoin;

namespace Blockcore.Features.Consensus
{
    public class StakeItem
    {
        public uint256 BlockId;

        public BlockStake BlockStake;

        public bool InStore;

        public long Height;
    }
}
