using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEBS_DS_SAVE_AREA")]
    public sealed class _PEBS_DS_SAVE_AREA : DynamicStructure
    {
        public _PEBS_DS_SAVE_AREA32 As32Bit { get; }
        public _PEBS_DS_SAVE_AREA64 As64Bit { get; }

        public _PEBS_DS_SAVE_AREA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEBS_DS_SAVE_AREA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEBS_DS_SAVE_AREA.As32Bit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEBS_DS_SAVE_AREA.As64Bit),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PEBS_DS_SAVE_AREA>((mem, ptr) => new _PEBS_DS_SAVE_AREA(mem, ptr), offsets);
        }
    }
}