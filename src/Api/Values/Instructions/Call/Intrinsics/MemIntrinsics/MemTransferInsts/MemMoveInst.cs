﻿namespace LLVMSharp.Api.Values.Instructions.Call.Intrinsics.MemIntrinsics.MemTransferInsts
{
    public sealed class MemMoveInst : MemTransferInst
    {
        internal MemMoveInst(LLVMValueRef instance)
            : base(instance)
        {
        }
    }
}