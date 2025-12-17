using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMWSL_INSTANCE")]
    public sealed class _MMWSL_INSTANCE : DynamicStructure
    {
        public byte[] PteResumePoint { get; }
        public uint LastAccessClearingRemainder { get; }
        public uint LastAgingRemainder { get; }
        public ulong LockedEntries { get; }
        public byte[] ActivePageTableLinks { get; }

        public _MMWSL_INSTANCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMWSL_INSTANCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMWSL_INSTANCE.PteResumePoint),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMWSL_INSTANCE.LastAccessClearingRemainder),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MMWSL_INSTANCE.LastAgingRemainder),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_MMWSL_INSTANCE.LockedEntries),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MMWSL_INSTANCE.ActivePageTableLinks),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_MMWSL_INSTANCE>((mem, ptr) => new _MMWSL_INSTANCE(mem, ptr), offsets);
        }
    }
}