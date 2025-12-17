using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_STANDBY_LOOKASIDE")]
    public sealed class _MI_STANDBY_LOOKASIDE : DynamicStructure
    {
        public ulong[] Array { get; }

        public _MI_STANDBY_LOOKASIDE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_STANDBY_LOOKASIDE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_STANDBY_LOOKASIDE.Array),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_STANDBY_LOOKASIDE>((mem, ptr) => new _MI_STANDBY_LOOKASIDE(mem, ptr), offsets);
        }
    }
}