using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_PROVIDER_TRAITS")]
    public sealed class _ETW_PROVIDER_TRAITS : DynamicStructure
    {
        public _RTL_BALANCED_NODE Node { get; }
        public uint ReferenceCount { get; }
        public byte[] Traits { get; }

        public _ETW_PROVIDER_TRAITS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_PROVIDER_TRAITS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_PROVIDER_TRAITS.Node),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_PROVIDER_TRAITS.ReferenceCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ETW_PROVIDER_TRAITS.Traits),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_ETW_PROVIDER_TRAITS>((mem, ptr) => new _ETW_PROVIDER_TRAITS(mem, ptr), offsets);
        }
    }
}