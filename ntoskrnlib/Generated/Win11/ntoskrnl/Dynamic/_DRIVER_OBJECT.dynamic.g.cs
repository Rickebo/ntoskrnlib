using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DRIVER_OBJECT")]
    public sealed class _DRIVER_OBJECT : DynamicStructure
    {
        public short Type { get; }
        public short Size { get; }
        public IntPtr DeviceObject { get; }
        public uint Flags { get; }
        public IntPtr DriverStart { get; }
        public uint DriverSize { get; }
        public IntPtr DriverSection { get; }
        public IntPtr DriverExtension { get; }
        public _UNICODE_STRING DriverName { get; }
        public IntPtr HardwareDatabase { get; }
        public IntPtr FastIoDispatch { get; }
        public IntPtr DriverInit { get; }
        public IntPtr DriverStartIo { get; }
        public IntPtr DriverUnload { get; }
        public byte[] MajorFunction { get; }

        public _DRIVER_OBJECT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DRIVER_OBJECT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DRIVER_OBJECT.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DRIVER_OBJECT.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DRIVER_OBJECT.DeviceObject),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DRIVER_OBJECT.Flags),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DRIVER_OBJECT.DriverStart),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DRIVER_OBJECT.DriverSize),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DRIVER_OBJECT.DriverSection),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DRIVER_OBJECT.DriverExtension),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DRIVER_OBJECT.DriverName),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DRIVER_OBJECT.HardwareDatabase),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_DRIVER_OBJECT.FastIoDispatch),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_DRIVER_OBJECT.DriverInit),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_DRIVER_OBJECT.DriverStartIo),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_DRIVER_OBJECT.DriverUnload),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_DRIVER_OBJECT.MajorFunction),
                    new ulong[]
                    {
                        112UL
                    }
                }
            };
            Register<_DRIVER_OBJECT>((mem, ptr) => new _DRIVER_OBJECT(mem, ptr), offsets);
        }
    }
}