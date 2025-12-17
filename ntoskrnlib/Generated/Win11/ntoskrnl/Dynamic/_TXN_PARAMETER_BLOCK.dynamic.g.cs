using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TXN_PARAMETER_BLOCK")]
    public sealed class _TXN_PARAMETER_BLOCK : DynamicStructure
    {
        public ushort Length { get; }
        public ushort TxFsContext { get; }
        public IntPtr TransactionObject { get; }

        public _TXN_PARAMETER_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TXN_PARAMETER_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TXN_PARAMETER_BLOCK.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TXN_PARAMETER_BLOCK.TxFsContext),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_TXN_PARAMETER_BLOCK.TransactionObject),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_TXN_PARAMETER_BLOCK>((mem, ptr) => new _TXN_PARAMETER_BLOCK(mem, ptr), offsets);
        }
    }
}