using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SEP_LOWBOX_NUMBER_ENTRY")]
    public sealed class SepLowboxNumberEntry : DynamicStructure
    {
        [Offset(0UL)]
        public RtlDynamicHashTableEntry HashEntry { get => ReadStructure<RtlDynamicHashTableEntry>(nameof(HashEntry)); set => WriteStructure(nameof(HashEntry), value); }

        [Offset(24UL)]
        public long ReferenceCount { get => ReadHere<long>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(32UL)]
        public IntPtr PackageSid { get => ReadHere<IntPtr>(nameof(PackageSid)); set => WriteHere(nameof(PackageSid), value); }

        [Offset(40UL)]
        public uint LowboxNumber { get => ReadHere<uint>(nameof(LowboxNumber)); set => WriteHere(nameof(LowboxNumber), value); }

        [Offset(48UL)]
        public IntPtr AtomTable { get => ReadHere<IntPtr>(nameof(AtomTable)); set => WriteHere(nameof(AtomTable), value); }

        public SepLowboxNumberEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SepLowboxNumberEntry>();
        }
    }
}