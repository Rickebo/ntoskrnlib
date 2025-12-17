using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_GROUP_AFFINITY64")]
    public sealed class _GROUP_AFFINITY64 : DynamicStructure
    {
        public ulong Mask { get; }
        public ushort Group { get; }
        public ushort[] Reserved { get; }

        public _GROUP_AFFINITY64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _GROUP_AFFINITY64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_GROUP_AFFINITY64.Mask),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_GROUP_AFFINITY64.Group),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_GROUP_AFFINITY64.Reserved),
                    new ulong[]
                    {
                        10UL
                    }
                }
            };
            Register<_GROUP_AFFINITY64>((mem, ptr) => new _GROUP_AFFINITY64(mem, ptr), offsets);
        }
    }
}