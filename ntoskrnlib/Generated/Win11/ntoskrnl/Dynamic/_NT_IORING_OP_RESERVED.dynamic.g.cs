using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_RESERVED")]
    public sealed class _NT_IORING_OP_RESERVED : DynamicStructure
    {
        public ulong Argument1 { get; }
        public ulong Argument2 { get; }
        public ulong Argument3 { get; }
        public ulong Argument4 { get; }
        public ulong Argument5 { get; }
        public ulong Argument6 { get; }

        public _NT_IORING_OP_RESERVED(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_OP_RESERVED()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_OP_RESERVED.Argument1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_RESERVED.Argument2),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_RESERVED.Argument3),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_RESERVED.Argument4),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_RESERVED.Argument5),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_RESERVED.Argument6),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_NT_IORING_OP_RESERVED>((mem, ptr) => new _NT_IORING_OP_RESERVED(mem, ptr), offsets);
        }
    }
}