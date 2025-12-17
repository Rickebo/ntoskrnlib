using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KLOCK_ENTRIES")]
    public sealed class KlockEntries : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(8UL)]
        public ushort AvailableEntryBitmap { get => ReadHere<ushort>(nameof(AvailableEntryBitmap)); set => WriteHere(nameof(AvailableEntryBitmap), value); }

        [Offset(10UL)]
        public ushort OrphanedEntryBitmap { get => ReadHere<ushort>(nameof(OrphanedEntryBitmap)); set => WriteHere(nameof(OrphanedEntryBitmap), value); }

        [Offset(12UL)]
        public byte EntryCount { get => ReadHere<byte>(nameof(EntryCount)); set => WriteHere(nameof(EntryCount), value); }

        [Offset(13UL)]
        [Length(3)]
        public DynamicArray Padding0 { get => ReadStructure<DynamicArray>(nameof(Padding0)); set => WriteStructure(nameof(Padding0), value); }

        [Offset(16UL)]
        [Length(1)]
        public DynamicArray Entries { get => ReadStructure<DynamicArray>(nameof(Entries)); set => WriteStructure(nameof(Entries), value); }

        public KlockEntries(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KlockEntries>();
        }
    }
}