using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_COPY_INFORMATION")]
    public sealed class CopyInformation : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr SourceFileObject { get => ReadHere<IntPtr>(nameof(SourceFileObject)); set => WriteHere(nameof(SourceFileObject), value); }

        [Offset(8UL)]
        public long SourceFileOffset { get => ReadHere<long>(nameof(SourceFileOffset)); set => WriteHere(nameof(SourceFileOffset), value); }

        public CopyInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CopyInformation>();
        }
    }
}