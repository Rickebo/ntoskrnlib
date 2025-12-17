using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMMOD_WRITER_MDL_ENTRY")]
    public sealed class MmmodWriterMdlEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Links { get => ReadStructure<ListEntry>(nameof(Links)); set => WriteStructure(nameof(Links), value); }

        [Offset(16UL)]
        public IntPtr Irp { get => ReadHere<IntPtr>(nameof(Irp)); set => WriteHere(nameof(Irp), value); }

        [Offset(24UL)]
        public IoStatusBlock IoStatus { get => ReadStructure<IoStatusBlock>(nameof(IoStatus)); set => WriteStructure(nameof(IoStatus), value); }

        [Offset(40UL)]
        public ModwriterFlags u1 { get => ReadStructure<ModwriterFlags>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(44UL)]
        public uint ByteCount { get => ReadHere<uint>(nameof(ByteCount)); set => WriteHere(nameof(ByteCount), value); }

        [Offset(48UL)]
        public uint ChargedPages { get => ReadHere<uint>(nameof(ChargedPages)); set => WriteHere(nameof(ChargedPages), value); }

        [Offset(56UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(64UL)]
        public UnnamedTag Pf { get => ReadStructure<UnnamedTag>(nameof(Pf)); set => WriteStructure(nameof(Pf), value); }

        [Offset(64UL)]
        public UnnamedTag Fs { get => ReadStructure<UnnamedTag>(nameof(Fs)); set => WriteStructure(nameof(Fs), value); }

        [Offset(88UL)]
        public LargeInteger WriteOffset { get => ReadStructure<LargeInteger>(nameof(WriteOffset)); set => WriteStructure(nameof(WriteOffset), value); }

        [Offset(96UL)]
        public IntPtr PointerMdl { get => ReadHere<IntPtr>(nameof(PointerMdl)); set => WriteHere(nameof(PointerMdl), value); }

        [Offset(104UL)]
        public Mdl Mdl { get => ReadStructure<Mdl>(nameof(Mdl)); set => WriteStructure(nameof(Mdl), value); }

        [Offset(152UL)]
        [Length(1)]
        public DynamicArray Page { get => ReadStructure<DynamicArray>(nameof(Page)); set => WriteStructure(nameof(Page), value); }

        public MmmodWriterMdlEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmmodWriterMdlEntry>();
        }
    }
}