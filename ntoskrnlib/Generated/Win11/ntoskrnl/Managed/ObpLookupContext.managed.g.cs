using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBP_LOOKUP_CONTEXT")]
    public sealed class ObpLookupContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Directory { get => ReadHere<IntPtr>(nameof(Directory)); set => WriteHere(nameof(Directory), value); }

        [Offset(8UL)]
        public IntPtr EntryLink { get => ReadHere<IntPtr>(nameof(EntryLink)); set => WriteHere(nameof(EntryLink), value); }

        [Offset(16UL)]
        public uint HashValue { get => ReadHere<uint>(nameof(HashValue)); set => WriteHere(nameof(HashValue), value); }

        [Offset(20UL)]
        public byte HashIndex { get => ReadHere<byte>(nameof(HashIndex)); set => WriteHere(nameof(HashIndex), value); }

        [Offset(21UL)]
        public byte LockedExclusive { get => ReadHere<byte>(nameof(LockedExclusive)); set => WriteHere(nameof(LockedExclusive), value); }

        [Offset(22UL)]
        public byte DirectoryReferenced { get => ReadHere<byte>(nameof(DirectoryReferenced)); set => WriteHere(nameof(DirectoryReferenced), value); }

        [Offset(23UL)]
        public byte Unused { get => ReadHere<byte>(nameof(Unused)); set => WriteHere(nameof(Unused), value); }

        public ObpLookupContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObpLookupContext>();
        }
    }
}