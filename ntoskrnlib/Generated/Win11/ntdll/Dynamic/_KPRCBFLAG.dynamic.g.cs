using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KPRCBFLAG")]
    public sealed class _KPRCBFLAG : DynamicStructure
    {
        public int PrcbFlags { get; }
        public uint BamQosLevel { get; }
        public uint PendingQosUpdate { get; }
        public uint CacheIsolationEnabled { get; }
        public uint TracepointActive { get; }
        public uint LongDpcRunning { get; }
        public uint PrcbFlagsReserved { get; }

        public _KPRCBFLAG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPRCBFLAG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPRCBFLAG.PrcbFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCBFLAG.BamQosLevel),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCBFLAG.PendingQosUpdate),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCBFLAG.CacheIsolationEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCBFLAG.TracepointActive),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCBFLAG.LongDpcRunning),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCBFLAG.PrcbFlagsReserved),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KPRCBFLAG>((mem, ptr) => new _KPRCBFLAG(mem, ptr), offsets);
        }
    }
}