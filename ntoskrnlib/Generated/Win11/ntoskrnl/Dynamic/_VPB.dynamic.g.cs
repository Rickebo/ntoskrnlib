using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VPB")]
    public sealed class _VPB : DynamicStructure
    {
        public short Type { get; }
        public short Size { get; }
        public ushort Flags { get; }
        public ushort VolumeLabelLength { get; }
        public IntPtr DeviceObject { get; }
        public IntPtr RealDevice { get; }
        public uint SerialNumber { get; }
        public uint ReferenceCount { get; }
        public short[] VolumeLabel { get; }

        public _VPB(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VPB()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VPB.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VPB.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_VPB.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_VPB.VolumeLabelLength),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_VPB.DeviceObject),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VPB.RealDevice),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VPB.SerialNumber),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_VPB.ReferenceCount),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_VPB.VolumeLabel),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_VPB>((mem, ptr) => new _VPB(mem, ptr), offsets);
        }
    }
}