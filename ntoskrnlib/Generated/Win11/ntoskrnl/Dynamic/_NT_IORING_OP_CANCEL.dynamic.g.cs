using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_CANCEL")]
    public sealed class _NT_IORING_OP_CANCEL : DynamicStructure
    {
        public uint CommonOpFlags { get; }
        public _NT_IORING_HANDLEREF File { get; }
        public ulong CancelId { get; }

        public _NT_IORING_OP_CANCEL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_OP_CANCEL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_OP_CANCEL.CommonOpFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_CANCEL.File),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_CANCEL.CancelId),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_NT_IORING_OP_CANCEL>((mem, ptr) => new _NT_IORING_OP_CANCEL(mem, ptr), offsets);
        }
    }
}