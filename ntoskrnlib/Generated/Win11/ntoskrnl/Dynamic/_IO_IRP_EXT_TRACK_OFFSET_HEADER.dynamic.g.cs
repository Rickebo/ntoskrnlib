using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_IRP_EXT_TRACK_OFFSET_HEADER")]
    public sealed class _IO_IRP_EXT_TRACK_OFFSET_HEADER : DynamicStructure
    {
        public ushort Validation { get; }
        public ushort Flags { get; }
        public IntPtr TrackedOffsetCallback { get; }

        public _IO_IRP_EXT_TRACK_OFFSET_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_IRP_EXT_TRACK_OFFSET_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_IRP_EXT_TRACK_OFFSET_HEADER.Validation),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_IRP_EXT_TRACK_OFFSET_HEADER.Flags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IO_IRP_EXT_TRACK_OFFSET_HEADER.TrackedOffsetCallback),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_IO_IRP_EXT_TRACK_OFFSET_HEADER>((mem, ptr) => new _IO_IRP_EXT_TRACK_OFFSET_HEADER(mem, ptr), offsets);
        }
    }
}