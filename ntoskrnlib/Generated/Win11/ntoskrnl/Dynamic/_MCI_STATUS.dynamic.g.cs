using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MCI_STATUS")]
    public sealed class _MCI_STATUS : DynamicStructure
    {
        public _MCI_STATUS_BITS_COMMON CommonBits { get; }
        public _MCI_STATUS_AMD_BITS AmdBits { get; }
        public _MCI_STATUS_INTEL_BITS IntelBits { get; }
        public ulong QuadPart { get; }

        public _MCI_STATUS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MCI_STATUS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MCI_STATUS.CommonBits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS.AmdBits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS.IntelBits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS.QuadPart),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MCI_STATUS>((mem, ptr) => new _MCI_STATUS(mem, ptr), offsets);
        }
    }
}