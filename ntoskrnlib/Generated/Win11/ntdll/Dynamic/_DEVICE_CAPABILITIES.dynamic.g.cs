using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_DEVICE_CAPABILITIES")]
    public sealed class _DEVICE_CAPABILITIES : DynamicStructure
    {
        public ushort Size { get; }
        public ushort Version { get; }
        public uint DeviceD1 { get; }
        public uint DeviceD2 { get; }
        public uint LockSupported { get; }
        public uint EjectSupported { get; }
        public uint Removable { get; }
        public uint DockDevice { get; }
        public uint UniqueID { get; }
        public uint SilentInstall { get; }
        public uint RawDeviceOK { get; }
        public uint SurpriseRemovalOK { get; }
        public uint WakeFromD0 { get; }
        public uint WakeFromD1 { get; }
        public uint WakeFromD2 { get; }
        public uint WakeFromD3 { get; }
        public uint HardwareDisabled { get; }
        public uint NonDynamic { get; }
        public uint WarmEjectSupported { get; }
        public uint NoDisplayInUI { get; }
        public uint Reserved1 { get; }
        public uint WakeFromInterrupt { get; }
        public uint SecureDevice { get; }
        public uint ChildOfVgaEnabledBridge { get; }
        public uint DecodeIoOnBoot { get; }
        public uint Reserved { get; }
        public uint Address { get; }
        public uint UINumber { get; }
        public uint[] DeviceState { get; }
        public uint SystemWake { get; }
        public uint DeviceWake { get; }
        public uint D1Latency { get; }
        public uint D2Latency { get; }
        public uint D3Latency { get; }

        public _DEVICE_CAPABILITIES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_CAPABILITIES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_CAPABILITIES.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.Version),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.DeviceD1),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.DeviceD2),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.LockSupported),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.EjectSupported),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.Removable),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.DockDevice),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.UniqueID),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.SilentInstall),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.RawDeviceOK),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.SurpriseRemovalOK),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.WakeFromD0),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.WakeFromD1),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.WakeFromD2),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.WakeFromD3),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.HardwareDisabled),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.NonDynamic),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.WarmEjectSupported),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.NoDisplayInUI),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.Reserved1),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.WakeFromInterrupt),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.SecureDevice),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.ChildOfVgaEnabledBridge),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.DecodeIoOnBoot),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.Reserved),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.Address),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.UINumber),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.DeviceState),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.SystemWake),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.DeviceWake),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.D1Latency),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.D2Latency),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DEVICE_CAPABILITIES.D3Latency),
                    new ulong[]
                    {
                        60UL
                    }
                }
            };
            Register<_DEVICE_CAPABILITIES>((mem, ptr) => new _DEVICE_CAPABILITIES(mem, ptr), offsets);
        }
    }
}