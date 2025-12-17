using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_IRP_EXT_TRACK_OFFSET_HEADER")]
    public sealed class IoIrpExtTrackOffsetHeader : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Validation { get => ReadHere<ushort>(nameof(Validation)); set => WriteHere(nameof(Validation), value); }

        [Offset(2UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(8UL)]
        public IntPtr TrackedOffsetCallback { get => ReadHere<IntPtr>(nameof(TrackedOffsetCallback)); set => WriteHere(nameof(TrackedOffsetCallback), value); }

        public IoIrpExtTrackOffsetHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoIrpExtTrackOffsetHeader>();
        }
    }
}