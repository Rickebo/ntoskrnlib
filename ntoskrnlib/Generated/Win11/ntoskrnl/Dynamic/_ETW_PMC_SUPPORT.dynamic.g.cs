using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_PMC_SUPPORT")]
    public sealed class _ETW_PMC_SUPPORT : DynamicStructure
    {
        public IntPtr Source { get; }
        public uint HookIdCount { get; }
        public ushort[] HookId { get; }
        public uint CountersCount { get; }
        public byte[] ProcessorCtrs { get; }

        public _ETW_PMC_SUPPORT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_PMC_SUPPORT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_PMC_SUPPORT.Source),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_PMC_SUPPORT.HookIdCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_PMC_SUPPORT.HookId),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_ETW_PMC_SUPPORT.CountersCount),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_ETW_PMC_SUPPORT.ProcessorCtrs),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_ETW_PMC_SUPPORT>((mem, ptr) => new _ETW_PMC_SUPPORT(mem, ptr), offsets);
        }
    }
}