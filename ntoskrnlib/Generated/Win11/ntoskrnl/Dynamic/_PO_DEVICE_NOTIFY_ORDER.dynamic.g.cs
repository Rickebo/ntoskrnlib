using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PO_DEVICE_NOTIFY_ORDER")]
    public sealed class _PO_DEVICE_NOTIFY_ORDER : DynamicStructure
    {
        public byte Locked { get; }
        public IntPtr WarmEjectPdoPointer { get; }
        public byte[] OrderLevel { get; }
        public uint Flags { get; }

        public _PO_DEVICE_NOTIFY_ORDER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PO_DEVICE_NOTIFY_ORDER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PO_DEVICE_NOTIFY_ORDER.Locked),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PO_DEVICE_NOTIFY_ORDER.WarmEjectPdoPointer),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PO_DEVICE_NOTIFY_ORDER.OrderLevel),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PO_DEVICE_NOTIFY_ORDER.Flags),
                    new ulong[]
                    {
                        376UL
                    }
                }
            };
            Register<_PO_DEVICE_NOTIFY_ORDER>((mem, ptr) => new _PO_DEVICE_NOTIFY_ORDER(mem, ptr), offsets);
        }
    }
}