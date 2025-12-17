using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FILE_SEGMENT_ELEMENT")]
    public sealed class FileSegmentElement : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Buffer { get => ReadHere<IntPtr>(nameof(Buffer)); set => WriteHere(nameof(Buffer), value); }

        [Offset(0UL)]
        public ulong Alignment { get => ReadHere<ulong>(nameof(Alignment)); set => WriteHere(nameof(Alignment), value); }

        public FileSegmentElement(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FileSegmentElement>();
        }
    }
}