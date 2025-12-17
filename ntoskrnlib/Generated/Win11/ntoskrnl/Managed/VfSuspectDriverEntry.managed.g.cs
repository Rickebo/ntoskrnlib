using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VF_SUSPECT_DRIVER_ENTRY")]
    public sealed class VfSuspectDriverEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Links { get => ReadStructure<ListEntry>(nameof(Links)); set => WriteStructure(nameof(Links), value); }

        [Offset(16UL)]
        public uint Loads { get => ReadHere<uint>(nameof(Loads)); set => WriteHere(nameof(Loads), value); }

        [Offset(20UL)]
        public uint Unloads { get => ReadHere<uint>(nameof(Unloads)); set => WriteHere(nameof(Unloads), value); }

        [Offset(24UL)]
        public UnicodeString FullName { get => ReadStructure<UnicodeString>(nameof(FullName)); set => WriteStructure(nameof(FullName), value); }

        [Offset(40UL)]
        public UnicodeString BaseName { get => ReadStructure<UnicodeString>(nameof(BaseName)); set => WriteStructure(nameof(BaseName), value); }

        public VfSuspectDriverEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VfSuspectDriverEntry>();
        }
    }
}