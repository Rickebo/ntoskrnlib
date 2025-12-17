using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_GROUP_AFFINITY32")]
    public sealed class _GROUP_AFFINITY32 : DynamicStructure
    {
        public uint Mask { get; }
        public ushort Group { get; }
        public ushort[] Reserved { get; }

        public _GROUP_AFFINITY32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GROUP_AFFINITY32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GROUP_AFFINITY32.Mask),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GROUP_AFFINITY32.Group),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_GROUP_AFFINITY32.Reserved),
                    new ulong[]
                    {
                        6UL
                    }
                }
            };
            Register<_GROUP_AFFINITY32>((mem, ptr) => new _GROUP_AFFINITY32(mem, ptr), offsets);
        }
    }
}