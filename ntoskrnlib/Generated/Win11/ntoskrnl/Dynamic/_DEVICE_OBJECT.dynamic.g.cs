using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_OBJECT")]
    public sealed class _DEVICE_OBJECT : DynamicStructure
    {
        public short Type { get; }
        public ushort Size { get; }
        public int ReferenceCount { get; }
        public IntPtr DriverObject { get; }
        public IntPtr NextDevice { get; }
        public IntPtr AttachedDevice { get; }
        public IntPtr CurrentIrp { get; }
        public IntPtr Timer { get; }
        public uint Flags { get; }
        public uint Characteristics { get; }
        public IntPtr Vpb { get; }
        public IntPtr DeviceExtension { get; }
        public uint DeviceType { get; }
        public sbyte StackSize { get; }
        public _unnamed_tag_ Queue { get; }
        public uint AlignmentRequirement { get; }
        public _KDEVICE_QUEUE DeviceQueue { get; }
        public _KDPC Dpc { get; }
        public uint ActiveThreadCount { get; }
        public IntPtr SecurityDescriptor { get; }
        public _KEVENT DeviceLock { get; }
        public ushort SectorSize { get; }
        public ushort Spare1 { get; }
        public IntPtr DeviceObjectExtension { get; }
        public IntPtr Reserved { get; }

        public _DEVICE_OBJECT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_OBJECT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_OBJECT.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.ReferenceCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.DriverObject),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.NextDevice),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.AttachedDevice),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.CurrentIrp),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.Timer),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.Flags),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.Characteristics),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.Vpb),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.DeviceExtension),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.DeviceType),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.StackSize),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.Queue),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.AlignmentRequirement),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.DeviceQueue),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.Dpc),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.ActiveThreadCount),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.SecurityDescriptor),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.DeviceLock),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.SectorSize),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.Spare1),
                    new ulong[]
                    {
                        306UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.DeviceObjectExtension),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_DEVICE_OBJECT.Reserved),
                    new ulong[]
                    {
                        320UL
                    }
                }
            };
            Register<_DEVICE_OBJECT>((mem, ptr) => new _DEVICE_OBJECT(mem, ptr), offsets);
        }
    }
}