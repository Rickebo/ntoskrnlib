using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_ULTRA_MDL_NODE")]
    public sealed class _MI_ULTRA_MDL_NODE : DynamicStructure
    {
        public byte[] UltraMdlMaps { get; }

        public _MI_ULTRA_MDL_NODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_ULTRA_MDL_NODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_ULTRA_MDL_NODE.UltraMdlMaps),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_ULTRA_MDL_NODE>((mem, ptr) => new _MI_ULTRA_MDL_NODE(mem, ptr), offsets);
        }
    }
}