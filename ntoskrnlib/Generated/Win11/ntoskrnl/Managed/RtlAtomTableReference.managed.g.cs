using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_ATOM_TABLE_REFERENCE")]
    public sealed class RtlAtomTableReference : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry LowBoxList { get => ReadStructure<ListEntry>(nameof(LowBoxList)); set => WriteStructure(nameof(LowBoxList), value); }

        [Offset(16UL)]
        public uint LowBoxID { get => ReadHere<uint>(nameof(LowBoxID)); set => WriteHere(nameof(LowBoxID), value); }

        [Offset(20UL)]
        public ushort ReferenceCount { get => ReadHere<ushort>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(22UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public RtlAtomTableReference(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlAtomTableReference>();
        }
    }
}