using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_FILL_MEMORY")]
    public sealed class DbgkdFillMemory : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Address { get => ReadHere<ulong>(nameof(Address)); set => WriteHere(nameof(Address), value); }

        [Offset(8UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(12UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(14UL)]
        public ushort PatternLength { get => ReadHere<ushort>(nameof(PatternLength)); set => WriteHere(nameof(PatternLength), value); }

        public DbgkdFillMemory(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdFillMemory>();
        }
    }
}