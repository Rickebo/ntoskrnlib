using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TRIAGE_DEVICE_NODE")]
    public sealed class _TRIAGE_DEVICE_NODE : DynamicStructure
    {
        public IntPtr Sibling { get; }
        public IntPtr Child { get; }
        public IntPtr Parent { get; }
        public IntPtr LastChild { get; }
        public IntPtr PhysicalDeviceObject { get; }
        public _UNICODE_STRING InstancePath { get; }
        public _UNICODE_STRING ServiceName { get; }
        public IntPtr PendingIrp { get; }
        public IntPtr FxDevice { get; }

        public _TRIAGE_DEVICE_NODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TRIAGE_DEVICE_NODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TRIAGE_DEVICE_NODE.Sibling),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TRIAGE_DEVICE_NODE.Child),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TRIAGE_DEVICE_NODE.Parent),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TRIAGE_DEVICE_NODE.LastChild),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_TRIAGE_DEVICE_NODE.PhysicalDeviceObject),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_TRIAGE_DEVICE_NODE.InstancePath),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_TRIAGE_DEVICE_NODE.ServiceName),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_TRIAGE_DEVICE_NODE.PendingIrp),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_TRIAGE_DEVICE_NODE.FxDevice),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_TRIAGE_DEVICE_NODE>((mem, ptr) => new _TRIAGE_DEVICE_NODE(mem, ptr), offsets);
        }
    }
}