using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_POLICY_DEVICE")]
    public sealed class _POP_POLICY_DEVICE : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public uint DeviceType { get; }
        public IntPtr Notification { get; }
        public _UNICODE_STRING Name { get; }
        public IntPtr Device { get; }
        public IntPtr Irp { get; }

        public _POP_POLICY_DEVICE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_POLICY_DEVICE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_POLICY_DEVICE.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_POLICY_DEVICE.DeviceType),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_POLICY_DEVICE.Notification),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_POLICY_DEVICE.Name),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_POLICY_DEVICE.Device),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_POLICY_DEVICE.Irp),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_POP_POLICY_DEVICE>((mem, ptr) => new _POP_POLICY_DEVICE(mem, ptr), offsets);
        }
    }
}