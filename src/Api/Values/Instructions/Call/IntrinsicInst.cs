﻿namespace LLVMSharp.Api.Values.Instructions.Call
{
    public class IntrinsicInst : CallInst
    {
        internal IntrinsicInst(LLVMValueRef instance)
            : base(instance)
        {
        }
    }
}