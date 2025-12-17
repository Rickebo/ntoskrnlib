using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMEXTEND_INFO")]
    public sealed class MmextendInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ulong CommittedSize { get => ReadHere<ulong>(nameof(CommittedSize)); set => WriteHere(nameof(CommittedSize), value); }

        [Offset(8UL)]
        public uint ReferenceCount { get => ReadHere<uint>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        public MmextendInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmextendInfo>();
        }
    }
}