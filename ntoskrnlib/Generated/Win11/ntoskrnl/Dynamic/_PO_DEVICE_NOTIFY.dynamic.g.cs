using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PO_DEVICE_NOTIFY")]
    public sealed class _PO_DEVICE_NOTIFY : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public _LIST_ENTRY PowerChildren { get; }
        public _LIST_ENTRY PowerParents { get; }
        public IntPtr TargetDevice { get; }
        public byte OrderLevel { get; }
        public IntPtr DeviceObject { get; }
        public IntPtr DeviceName { get; }
        public IntPtr DriverName { get; }
        public uint ChildCount { get; }
        public uint ActiveChild { get; }
        public uint ParentCount { get; }
        public uint ActiveParent { get; }

        public _PO_DEVICE_NOTIFY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PO_DEVICE_NOTIFY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PO_DEVICE_NOTIFY.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PO_DEVICE_NOTIFY.PowerChildren),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PO_DEVICE_NOTIFY.PowerParents),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PO_DEVICE_NOTIFY.TargetDevice),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PO_DEVICE_NOTIFY.OrderLevel),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PO_DEVICE_NOTIFY.DeviceObject),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PO_DEVICE_NOTIFY.DeviceName),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PO_DEVICE_NOTIFY.DriverName),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PO_DEVICE_NOTIFY.ChildCount),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PO_DEVICE_NOTIFY.ActiveChild),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_PO_DEVICE_NOTIFY.ParentCount),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PO_DEVICE_NOTIFY.ActiveParent),
                    new ulong[]
                    {
                        100UL
                    }
                }
            };
            Register<_PO_DEVICE_NOTIFY>((mem, ptr) => new _PO_DEVICE_NOTIFY(mem, ptr), offsets);
        }
    }
}