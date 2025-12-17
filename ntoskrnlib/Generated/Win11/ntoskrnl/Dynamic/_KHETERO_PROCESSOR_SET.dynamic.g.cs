using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KHETERO_PROCESSOR_SET")]
    public sealed class _KHETERO_PROCESSOR_SET : DynamicStructure
    {
        public ulong IdealMask { get; }
        public ulong PreferredMask { get; }
        public ulong AvailableMask { get; }

        public _KHETERO_PROCESSOR_SET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KHETERO_PROCESSOR_SET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KHETERO_PROCESSOR_SET.IdealMask),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KHETERO_PROCESSOR_SET.PreferredMask),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KHETERO_PROCESSOR_SET.AvailableMask),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_KHETERO_PROCESSOR_SET>((mem, ptr) => new _KHETERO_PROCESSOR_SET(mem, ptr), offsets);
        }
    }
}