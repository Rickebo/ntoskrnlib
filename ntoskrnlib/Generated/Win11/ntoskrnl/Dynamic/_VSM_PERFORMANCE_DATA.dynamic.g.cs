using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VSM_PERFORMANCE_DATA")]
    public sealed class _VSM_PERFORMANCE_DATA : DynamicStructure
    {
        public ulong[] LaunchVsmMark { get; }

        public _VSM_PERFORMANCE_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VSM_PERFORMANCE_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VSM_PERFORMANCE_DATA.LaunchVsmMark),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_VSM_PERFORMANCE_DATA>((mem, ptr) => new _VSM_PERFORMANCE_DATA(mem, ptr), offsets);
        }
    }
}