using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PI_RESOURCE_ARBITER_ENTRY")]
    public sealed class _PI_RESOURCE_ARBITER_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY DeviceArbiterList { get; }
        public byte ResourceType { get; }
        public IntPtr ArbiterInterface { get; }
        public IntPtr DeviceNode { get; }
        public _LIST_ENTRY ResourceList { get; }
        public _LIST_ENTRY BestResourceList { get; }
        public _LIST_ENTRY BestConfig { get; }
        public _LIST_ENTRY ActiveArbiterList { get; }
        public byte State { get; }
        public byte ResourcesChanged { get; }

        public _PI_RESOURCE_ARBITER_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PI_RESOURCE_ARBITER_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PI_RESOURCE_ARBITER_ENTRY.DeviceArbiterList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PI_RESOURCE_ARBITER_ENTRY.ResourceType),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PI_RESOURCE_ARBITER_ENTRY.ArbiterInterface),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PI_RESOURCE_ARBITER_ENTRY.DeviceNode),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PI_RESOURCE_ARBITER_ENTRY.ResourceList),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PI_RESOURCE_ARBITER_ENTRY.BestResourceList),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PI_RESOURCE_ARBITER_ENTRY.BestConfig),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PI_RESOURCE_ARBITER_ENTRY.ActiveArbiterList),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PI_RESOURCE_ARBITER_ENTRY.State),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PI_RESOURCE_ARBITER_ENTRY.ResourcesChanged),
                    new ulong[]
                    {
                        105UL
                    }
                }
            };
            Register<_PI_RESOURCE_ARBITER_ENTRY>((mem, ptr) => new _PI_RESOURCE_ARBITER_ENTRY(mem, ptr), offsets);
        }
    }
}