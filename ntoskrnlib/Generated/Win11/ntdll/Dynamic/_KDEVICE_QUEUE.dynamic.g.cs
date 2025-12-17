using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KDEVICE_QUEUE")]
    public sealed class _KDEVICE_QUEUE : DynamicStructure
    {
        public short Type { get; }
        public short Size { get; }
        public _LIST_ENTRY DeviceListHead { get; }
        public ulong Lock { get; }
        public byte Busy { get; }
        public long Reserved { get; }
        public long Hint { get; }

        public _KDEVICE_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KDEVICE_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KDEVICE_QUEUE.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KDEVICE_QUEUE.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_KDEVICE_QUEUE.DeviceListHead),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KDEVICE_QUEUE.Lock),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KDEVICE_QUEUE.Busy),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KDEVICE_QUEUE.Reserved),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KDEVICE_QUEUE.Hint),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_KDEVICE_QUEUE>((mem, ptr) => new _KDEVICE_QUEUE(mem, ptr), offsets);
        }
    }
}