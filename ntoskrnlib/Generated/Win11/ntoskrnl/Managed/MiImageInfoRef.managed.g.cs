using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_IMAGE_INFO_REF")]
    public sealed class MiImageInfoRef : DynamicStructure
    {
        [Offset(0UL)]
        public int LongValue { get => ReadHere<int>(nameof(LongValue)); set => WriteHere(nameof(LongValue), value); }

        [Offset(0UL)]
        public ulong FullValue { get => ReadHere<ulong>(nameof(FullValue)); set => WriteHere(nameof(FullValue), value); }

        [Offset(0UL)]
        public IntPtr PointerValue { get => ReadHere<IntPtr>(nameof(PointerValue)); set => WriteHere(nameof(PointerValue), value); }

        [Offset(0UL)]
        public ulong AllFlags { get => ReadHere<ulong>(nameof(AllFlags)); set => WriteHere(nameof(AllFlags), value); }

        [Offset(0UL)]
        public ulong DebugRecordsPresent { get => ReadHere<ulong>(nameof(DebugRecordsPresent)); set => WriteHere(nameof(DebugRecordsPresent), value); }

        public MiImageInfoRef(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiImageInfoRef>();
        }
    }
}