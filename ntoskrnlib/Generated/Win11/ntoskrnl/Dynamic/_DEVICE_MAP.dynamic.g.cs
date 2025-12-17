using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_MAP")]
    public sealed class _DEVICE_MAP : DynamicStructure
    {
        public IntPtr DosDevicesDirectory { get; }
        public IntPtr GlobalDosDevicesDirectory { get; }
        public IntPtr ServerSilo { get; }
        public IntPtr GlobalDeviceMap { get; }
        public byte[] DriveObject { get; }
        public long ReferenceCount { get; }
        public IntPtr DosDevicesDirectoryHandle { get; }
        public uint DriveMap { get; }
        public byte[] DriveType { get; }

        public _DEVICE_MAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_MAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_MAP.DosDevicesDirectory),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_MAP.GlobalDosDevicesDirectory),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEVICE_MAP.ServerSilo),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DEVICE_MAP.GlobalDeviceMap),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DEVICE_MAP.DriveObject),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DEVICE_MAP.ReferenceCount),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_DEVICE_MAP.DosDevicesDirectoryHandle),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_DEVICE_MAP.DriveMap),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_DEVICE_MAP.DriveType),
                    new ulong[]
                    {
                        260UL
                    }
                }
            };
            Register<_DEVICE_MAP>((mem, ptr) => new _DEVICE_MAP(mem, ptr), offsets);
        }
    }
}