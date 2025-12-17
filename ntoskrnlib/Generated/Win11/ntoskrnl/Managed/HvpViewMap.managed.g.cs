using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HVP_VIEW_MAP")]
    public sealed class HvpViewMap : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr SectionReference { get => ReadHere<IntPtr>(nameof(SectionReference)); set => WriteHere(nameof(SectionReference), value); }

        [Offset(8UL)]
        public long StorageEndFileOffset { get => ReadHere<long>(nameof(StorageEndFileOffset)); set => WriteHere(nameof(StorageEndFileOffset), value); }

        [Offset(16UL)]
        public long SectionEndFileOffset { get => ReadHere<long>(nameof(SectionEndFileOffset)); set => WriteHere(nameof(SectionEndFileOffset), value); }

        [Offset(24UL)]
        public IntPtr ProcessTuple { get => ReadHere<IntPtr>(nameof(ProcessTuple)); set => WriteHere(nameof(ProcessTuple), value); }

        [Offset(32UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(40UL)]
        public RtlRbTree ViewTree { get => ReadStructure<RtlRbTree>(nameof(ViewTree)); set => WriteStructure(nameof(ViewTree), value); }

        public HvpViewMap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HvpViewMap>();
        }
    }
}