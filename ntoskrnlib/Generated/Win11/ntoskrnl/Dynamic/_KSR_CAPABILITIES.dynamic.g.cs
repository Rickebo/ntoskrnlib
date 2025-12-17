using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSR_CAPABILITIES")]
    public sealed class _KSR_CAPABILITIES : DynamicStructure
    {
        public uint PerennialDatabase { get; }
        public uint SkipSubAllocator { get; }
        public uint ExtendedNotifications { get; }
        public uint Kseg0Vtl1Mappings64KBAligned { get; }
        public uint Vtl1IsolatedDatabase { get; }
        public uint Reserved { get; }
        public uint AsULong { get; }

        public _KSR_CAPABILITIES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSR_CAPABILITIES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSR_CAPABILITIES.PerennialDatabase),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSR_CAPABILITIES.SkipSubAllocator),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSR_CAPABILITIES.ExtendedNotifications),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSR_CAPABILITIES.Kseg0Vtl1Mappings64KBAligned),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSR_CAPABILITIES.Vtl1IsolatedDatabase),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSR_CAPABILITIES.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSR_CAPABILITIES.AsULong),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KSR_CAPABILITIES>((mem, ptr) => new _KSR_CAPABILITIES(mem, ptr), offsets);
        }
    }
}