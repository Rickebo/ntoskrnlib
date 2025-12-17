using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CONTROLLER_OBJECT")]
    public sealed class _CONTROLLER_OBJECT : DynamicStructure
    {
        public short Type { get; }
        public short Size { get; }
        public IntPtr ControllerExtension { get; }
        public _KDEVICE_QUEUE DeviceWaitQueue { get; }
        public uint Spare1 { get; }
        public _LARGE_INTEGER Spare2 { get; }

        public _CONTROLLER_OBJECT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CONTROLLER_OBJECT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CONTROLLER_OBJECT.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CONTROLLER_OBJECT.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_CONTROLLER_OBJECT.ControllerExtension),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CONTROLLER_OBJECT.DeviceWaitQueue),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CONTROLLER_OBJECT.Spare1),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CONTROLLER_OBJECT.Spare2),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_CONTROLLER_OBJECT>((mem, ptr) => new _CONTROLLER_OBJECT(mem, ptr), offsets);
        }
    }
}