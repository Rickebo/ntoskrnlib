using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!IORING_BUFFER_INFO")]
    public sealed class IORING_BUFFER_INFO : DynamicStructure
    {
        public IntPtr Address { get; }
        public uint Length { get; }

        public IORING_BUFFER_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static IORING_BUFFER_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(IORING_BUFFER_INFO.Address),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(IORING_BUFFER_INFO.Length),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<IORING_BUFFER_INFO>((mem, ptr) => new IORING_BUFFER_INFO(mem, ptr), offsets);
        }
    }
}