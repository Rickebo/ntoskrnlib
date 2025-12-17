using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_REGISTER_FILES")]
    public sealed class _NT_IORING_OP_REGISTER_FILES : DynamicStructure
    {
        public uint CommonOpFlags { get; }
        public _NT_IORING_REG_FILES_FLAGS Flags { get; }
        public uint Count { get; }
        public IntPtr Handles { get; }

        public _NT_IORING_OP_REGISTER_FILES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_OP_REGISTER_FILES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_OP_REGISTER_FILES.CommonOpFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_REGISTER_FILES.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_REGISTER_FILES.Count),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_NT_IORING_OP_REGISTER_FILES.Handles),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_NT_IORING_OP_REGISTER_FILES>((mem, ptr) => new _NT_IORING_OP_REGISTER_FILES(mem, ptr), offsets);
        }
    }
}