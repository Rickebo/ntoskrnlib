using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_LIST_ENTRY")]
    public sealed class _ARBITER_LIST_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public uint AlternativeCount { get; }
        public IntPtr Alternatives { get; }
        public IntPtr PhysicalDeviceObject { get; }
        public uint RequestSource { get; }
        public uint Flags { get; }
        public long WorkSpace { get; }
        public uint InterfaceType { get; }
        public uint SlotNumber { get; }
        public uint BusNumber { get; }
        public IntPtr Assignment { get; }
        public IntPtr SelectedAlternative { get; }
        public uint Result { get; }

        public _ARBITER_LIST_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_LIST_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_LIST_ENTRY.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARBITER_LIST_ENTRY.AlternativeCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ARBITER_LIST_ENTRY.Alternatives),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ARBITER_LIST_ENTRY.PhysicalDeviceObject),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ARBITER_LIST_ENTRY.RequestSource),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ARBITER_LIST_ENTRY.Flags),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_ARBITER_LIST_ENTRY.WorkSpace),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ARBITER_LIST_ENTRY.InterfaceType),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_ARBITER_LIST_ENTRY.SlotNumber),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_ARBITER_LIST_ENTRY.BusNumber),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_ARBITER_LIST_ENTRY.Assignment),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_ARBITER_LIST_ENTRY.SelectedAlternative),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_ARBITER_LIST_ENTRY.Result),
                    new ulong[]
                    {
                        88UL
                    }
                }
            };
            Register<_ARBITER_LIST_ENTRY>((mem, ptr) => new _ARBITER_LIST_ENTRY(mem, ptr), offsets);
        }
    }
}