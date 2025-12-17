using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_ATOM_TABLE_ENTRY")]
    public sealed class RtlAtomTableEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr HashLink { get => ReadHere<IntPtr>(nameof(HashLink)); set => WriteHere(nameof(HashLink), value); }

        [Offset(8UL)]
        public ushort HandleIndex { get => ReadHere<ushort>(nameof(HandleIndex)); set => WriteHere(nameof(HandleIndex), value); }

        [Offset(10UL)]
        public ushort Atom { get => ReadHere<ushort>(nameof(Atom)); set => WriteHere(nameof(Atom), value); }

        [Offset(16UL)]
        public RtlAtomTableReference Reference { get => ReadStructure<RtlAtomTableReference>(nameof(Reference)); set => WriteStructure(nameof(Reference), value); }

        [Offset(40UL)]
        public byte NameLength { get => ReadHere<byte>(nameof(NameLength)); set => WriteHere(nameof(NameLength), value); }

        [Offset(42UL)]
        [Length(1)]
        public DynamicArray Name { get => ReadStructure<DynamicArray>(nameof(Name)); set => WriteStructure(nameof(Name), value); }

        public RtlAtomTableEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlAtomTableEntry>();
        }
    }
}