using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_REG_BUFFERS_FLAGS")]
    public sealed class _NT_IORING_REG_BUFFERS_FLAGS : DynamicStructure
    {
        public uint Required { get; }
        public uint Advisory { get; }

        public _NT_IORING_REG_BUFFERS_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_REG_BUFFERS_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_REG_BUFFERS_FLAGS.Required),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_REG_BUFFERS_FLAGS.Advisory),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_NT_IORING_REG_BUFFERS_FLAGS>((mem, ptr) => new _NT_IORING_REG_BUFFERS_FLAGS(mem, ptr), offsets);
        }
    }
}