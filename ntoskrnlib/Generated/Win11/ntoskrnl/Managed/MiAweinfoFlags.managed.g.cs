using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_AWEINFO_FLAGS")]
    public sealed class MiAweinfoFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint ProcessDefault { get => ReadHere<uint>(nameof(ProcessDefault)); set => WriteHere(nameof(ProcessDefault), value); }

        [Offset(0UL)]
        public uint PagesLockInitialized { get => ReadHere<uint>(nameof(PagesLockInitialized)); set => WriteHere(nameof(PagesLockInitialized), value); }

        [Offset(0UL)]
        public uint ZeroPagesOptional { get => ReadHere<uint>(nameof(ZeroPagesOptional)); set => WriteHere(nameof(ZeroPagesOptional), value); }

        [Offset(0UL)]
        public uint IoSpace { get => ReadHere<uint>(nameof(IoSpace)); set => WriteHere(nameof(IoSpace), value); }

        [Offset(0UL)]
        public uint LazyTbFlush { get => ReadHere<uint>(nameof(LazyTbFlush)); set => WriteHere(nameof(LazyTbFlush), value); }

        [Offset(0UL)]
        public uint Unused { get => ReadHere<uint>(nameof(Unused)); set => WriteHere(nameof(Unused), value); }

        [Offset(0UL)]
        public uint AllBits { get => ReadHere<uint>(nameof(AllBits)); set => WriteHere(nameof(AllBits), value); }

        public MiAweinfoFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiAweinfoFlags>();
        }
    }
}