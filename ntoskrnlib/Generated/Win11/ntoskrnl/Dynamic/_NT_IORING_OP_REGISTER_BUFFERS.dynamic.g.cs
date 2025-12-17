using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_REGISTER_BUFFERS")]
    public sealed class _NT_IORING_OP_REGISTER_BUFFERS : DynamicStructure
    {
        public uint CommonOpFlags { get; }
        public _NT_IORING_REG_BUFFERS_FLAGS Flags { get; }
        public uint Count { get; }
        public IntPtr Buffers { get; }

        public _NT_IORING_OP_REGISTER_BUFFERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_OP_REGISTER_BUFFERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_OP_REGISTER_BUFFERS.CommonOpFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_REGISTER_BUFFERS.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_REGISTER_BUFFERS.Count),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_REGISTER_BUFFERS.Buffers),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_NT_IORING_OP_REGISTER_BUFFERS>((mem, ptr) => new _NT_IORING_OP_REGISTER_BUFFERS(mem, ptr), offsets);
        }
    }
}