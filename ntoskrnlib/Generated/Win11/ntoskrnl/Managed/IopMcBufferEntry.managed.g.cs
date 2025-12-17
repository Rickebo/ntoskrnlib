using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOP_MC_BUFFER_ENTRY")]
    public sealed class IopMcBufferEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Type { get => ReadHere<ushort>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(4UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public int ReferenceCount { get => ReadHere<int>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(12UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(16UL)]
        public ListEntry GlobalDataLink { get => ReadStructure<ListEntry>(nameof(GlobalDataLink)); set => WriteStructure(nameof(GlobalDataLink), value); }

        [Offset(32UL)]
        public IntPtr Address { get => ReadHere<IntPtr>(nameof(Address)); set => WriteHere(nameof(Address), value); }

        [Offset(40UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(44UL)]
        public sbyte AccessMode { get => ReadHere<sbyte>(nameof(AccessMode)); set => WriteHere(nameof(AccessMode), value); }

        [Offset(48UL)]
        public int MdlRef { get => ReadHere<int>(nameof(MdlRef)); set => WriteHere(nameof(MdlRef), value); }

        [Offset(56UL)]
        public IntPtr Mdl { get => ReadHere<IntPtr>(nameof(Mdl)); set => WriteHere(nameof(Mdl), value); }

        [Offset(64UL)]
        public Kevent MdlRundownEvent { get => ReadStructure<Kevent>(nameof(MdlRundownEvent)); set => WriteStructure(nameof(MdlRundownEvent), value); }

        [Offset(88UL)]
        public IntPtr PfnArray { get => ReadHere<IntPtr>(nameof(PfnArray)); set => WriteHere(nameof(PfnArray), value); }

        [Offset(96UL)]
        [Length(1)]
        public DynamicArray PageNodes { get => ReadStructure<DynamicArray>(nameof(PageNodes)); set => WriteStructure(nameof(PageNodes), value); }

        public IopMcBufferEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IopMcBufferEntry>();
        }
    }
}