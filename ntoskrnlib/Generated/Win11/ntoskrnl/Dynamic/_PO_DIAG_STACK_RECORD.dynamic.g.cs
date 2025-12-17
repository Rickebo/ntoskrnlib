using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PO_DIAG_STACK_RECORD")]
    public sealed class _PO_DIAG_STACK_RECORD : DynamicStructure
    {
        public uint StackDepth { get; }
        public byte[] Stack { get; }

        public _PO_DIAG_STACK_RECORD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PO_DIAG_STACK_RECORD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PO_DIAG_STACK_RECORD.StackDepth),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PO_DIAG_STACK_RECORD.Stack),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PO_DIAG_STACK_RECORD>((mem, ptr) => new _PO_DIAG_STACK_RECORD(mem, ptr), offsets);
        }
    }
}