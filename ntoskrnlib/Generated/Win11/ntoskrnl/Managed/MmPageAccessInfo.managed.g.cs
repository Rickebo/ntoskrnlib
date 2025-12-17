using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MM_PAGE_ACCESS_INFO")]
    public sealed class MmPageAccessInfo : DynamicStructure
    {
        [Offset(0UL)]
        public MmPageAccessInfoFlags Flags { get => ReadStructure<MmPageAccessInfoFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(0UL)]
        public ulong FileOffset { get => ReadHere<ulong>(nameof(FileOffset)); set => WriteHere(nameof(FileOffset), value); }

        [Offset(0UL)]
        public IntPtr VirtualAddress { get => ReadHere<IntPtr>(nameof(VirtualAddress)); set => WriteHere(nameof(VirtualAddress), value); }

        [Offset(0UL)]
        public IntPtr PointerProtoPte { get => ReadHere<IntPtr>(nameof(PointerProtoPte)); set => WriteHere(nameof(PointerProtoPte), value); }

        public MmPageAccessInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmPageAccessInfo>();
        }
    }
}