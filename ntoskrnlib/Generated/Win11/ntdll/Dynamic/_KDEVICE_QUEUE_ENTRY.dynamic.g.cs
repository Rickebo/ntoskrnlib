using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KDEVICE_QUEUE_ENTRY")]
    public sealed class _KDEVICE_QUEUE_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY DeviceListEntry { get; }
        public uint SortKey { get; }
        public byte Inserted { get; }

        public _KDEVICE_QUEUE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KDEVICE_QUEUE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KDEVICE_QUEUE_ENTRY.DeviceListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KDEVICE_QUEUE_ENTRY.SortKey),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KDEVICE_QUEUE_ENTRY.Inserted),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_KDEVICE_QUEUE_ENTRY>((mem, ptr) => new _KDEVICE_QUEUE_ENTRY(mem, ptr), offsets);
        }
    }
}