using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KMUTANT")]
    public sealed class Kmutant : DynamicStructure
    {
        [Offset(0UL)]
        public DispatcherHeader Header { get => ReadStructure<DispatcherHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(24UL)]
        public ListEntry MutantListEntry { get => ReadStructure<ListEntry>(nameof(MutantListEntry)); set => WriteStructure(nameof(MutantListEntry), value); }

        [Offset(40UL)]
        public IntPtr OwnerThread { get => ReadHere<IntPtr>(nameof(OwnerThread)); set => WriteHere(nameof(OwnerThread), value); }

        [Offset(48UL)]
        public byte MutantFlags { get => ReadHere<byte>(nameof(MutantFlags)); set => WriteHere(nameof(MutantFlags), value); }

        [Offset(48UL)]
        public byte Abandoned { get => ReadHere<byte>(nameof(Abandoned)); set => WriteHere(nameof(Abandoned), value); }

        [Offset(48UL)]
        public byte Spare1 { get => ReadHere<byte>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(48UL)]
        public byte Abandoned2 { get => ReadHere<byte>(nameof(Abandoned2)); set => WriteHere(nameof(Abandoned2), value); }

        [Offset(48UL)]
        public byte AbEnabled { get => ReadHere<byte>(nameof(AbEnabled)); set => WriteHere(nameof(AbEnabled), value); }

        [Offset(48UL)]
        public byte Spare2 { get => ReadHere<byte>(nameof(Spare2)); set => WriteHere(nameof(Spare2), value); }

        [Offset(49UL)]
        public byte ApcDisable { get => ReadHere<byte>(nameof(ApcDisable)); set => WriteHere(nameof(ApcDisable), value); }

        public Kmutant(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kmutant>();
        }
    }
}