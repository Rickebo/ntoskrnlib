using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_FLUSH")]
    public sealed class _NT_IORING_OP_FLUSH : DynamicStructure
    {
        public uint CommonOpFlags { get; }
        public uint Flags { get; }
        public _NT_IORING_HANDLEREF File { get; }

        public _NT_IORING_OP_FLUSH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_OP_FLUSH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_OP_FLUSH.CommonOpFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_FLUSH.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_FLUSH.File),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_NT_IORING_OP_FLUSH>((mem, ptr) => new _NT_IORING_OP_FLUSH(mem, ptr), offsets);
        }
    }
}