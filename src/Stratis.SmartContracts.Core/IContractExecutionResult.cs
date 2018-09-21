﻿using System.Collections.Generic;
using NBitcoin;
using Stratis.SmartContracts.Core.Receipts;

namespace Stratis.SmartContracts.Core
{
    public interface IContractExecutionResult
    {
        /// <summary>
        /// If there is an error during execution it will be stored here.
        /// </summary>
        ContractErrorMessage ErrorMessage { get; set; }

        /// <summary>
        /// The amount of gas units used through execution of the smart contract.
        /// </summary>
        Gas GasConsumed { get; set; }

        /// <summary>
        /// If the execution created a new contract, its address will be stored here.
        /// </summary>
        uint160 NewContractAddress { get; set; }

        /// <summary>
        /// The contract that received the message and performed execution.
        /// </summary>
        uint160 To { get; set; }

        /// <summary>
        /// If an object is returned from the method called, it will be stored here.
        /// </summary>
        object Return { get; set; }

        /// <summary>
        /// Whether the state changes made during execution should be reverted. If an exception occurred, then should be true.
        /// </summary>
        bool Revert { get; }

        /// <summary>
        /// The condensing transaction produced by the contract execution.
        /// </summary>
        Transaction InternalTransaction { get; set; }
        
        /// <summary>
        /// The calculated fee for executing the smart contract transaction and including it in the block.
        /// <para>
        /// Normally this will be the mempool fee but if there are refunds, the fee will be
        /// the mempool fee less the refund.
        /// </para>
        /// </summary>
        ulong Fee { get; set; }

        /// <summary>
        /// If a refund is due to the sender, set this here.
        /// <para>
        /// An example of this will be if for instance an exception occurred and not all the gas was spent.
        /// </para>
        /// </summary>
        TxOut Refund { get; set; }

        /// <summary>
        /// The logs generated by contracts during execution.
        /// </summary>
        IList<Log> Logs { get; set; }
    }
}