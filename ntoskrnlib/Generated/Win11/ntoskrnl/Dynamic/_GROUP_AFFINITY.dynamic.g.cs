using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_GROUP_AFFINITY")]
    public sealed class _GROUP_AFFINITY : DynamicStructure
    {
        public ulong Mask { get; }
        public ushort Group { get; }
        public ushort[] Reserved { get; }

        public _GROUP_AFFINITY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GROUP_AFFINITY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GROUP_AFFINITY.Mask),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GROUP_AFFINITY.Group),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_GROUP_AFFINITY.Reserved),
                    new ulong[]
                    {
                        10UL
                    }
                }
            };
            Register<_GROUP_AFFINITY>((mem, ptr) => new _GROUP_AFFINITY(mem, ptr), offsets);
        }
    }
}