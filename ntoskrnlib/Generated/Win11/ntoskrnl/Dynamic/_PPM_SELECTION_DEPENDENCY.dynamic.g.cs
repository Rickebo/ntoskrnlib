using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PPM_SELECTION_DEPENDENCY")]
    public sealed class _PPM_SELECTION_DEPENDENCY : DynamicStructure
    {
        public uint Processor { get; }
        public _PPM_SELECTION_MENU Menu { get; }

        public _PPM_SELECTION_DEPENDENCY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_SELECTION_DEPENDENCY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_SELECTION_DEPENDENCY.Processor),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_DEPENDENCY.Menu),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PPM_SELECTION_DEPENDENCY>((mem, ptr) => new _PPM_SELECTION_DEPENDENCY(mem, ptr), offsets);
        }
    }
}