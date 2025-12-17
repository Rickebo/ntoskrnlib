using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IMAGE_DOS_HEADER")]
    public sealed class ImageDosHeader : DynamicStructure
    {
        [Offset(0UL)]
        public ushort e_magic { get => ReadHere<ushort>(nameof(e_magic)); set => WriteHere(nameof(e_magic), value); }

        [Offset(2UL)]
        public ushort e_cblp { get => ReadHere<ushort>(nameof(e_cblp)); set => WriteHere(nameof(e_cblp), value); }

        [Offset(4UL)]
        public ushort e_cp { get => ReadHere<ushort>(nameof(e_cp)); set => WriteHere(nameof(e_cp), value); }

        [Offset(6UL)]
        public ushort e_crlc { get => ReadHere<ushort>(nameof(e_crlc)); set => WriteHere(nameof(e_crlc), value); }

        [Offset(8UL)]
        public ushort e_cparhdr { get => ReadHere<ushort>(nameof(e_cparhdr)); set => WriteHere(nameof(e_cparhdr), value); }

        [Offset(10UL)]
        public ushort e_minalloc { get => ReadHere<ushort>(nameof(e_minalloc)); set => WriteHere(nameof(e_minalloc), value); }

        [Offset(12UL)]
        public ushort e_maxalloc { get => ReadHere<ushort>(nameof(e_maxalloc)); set => WriteHere(nameof(e_maxalloc), value); }

        [Offset(14UL)]
        public ushort e_ss { get => ReadHere<ushort>(nameof(e_ss)); set => WriteHere(nameof(e_ss), value); }

        [Offset(16UL)]
        public ushort e_sp { get => ReadHere<ushort>(nameof(e_sp)); set => WriteHere(nameof(e_sp), value); }

        [Offset(18UL)]
        public ushort e_csum { get => ReadHere<ushort>(nameof(e_csum)); set => WriteHere(nameof(e_csum), value); }

        [Offset(20UL)]
        public ushort e_ip { get => ReadHere<ushort>(nameof(e_ip)); set => WriteHere(nameof(e_ip), value); }

        [Offset(22UL)]
        public ushort e_cs { get => ReadHere<ushort>(nameof(e_cs)); set => WriteHere(nameof(e_cs), value); }

        [Offset(24UL)]
        public ushort e_lfarlc { get => ReadHere<ushort>(nameof(e_lfarlc)); set => WriteHere(nameof(e_lfarlc), value); }

        [Offset(26UL)]
        public ushort e_ovno { get => ReadHere<ushort>(nameof(e_ovno)); set => WriteHere(nameof(e_ovno), value); }

        [Offset(28UL)]
        [Length(4)]
        public DynamicArray e_res { get => ReadStructure<DynamicArray>(nameof(e_res)); set => WriteStructure(nameof(e_res), value); }

        [Offset(36UL)]
        public ushort e_oemid { get => ReadHere<ushort>(nameof(e_oemid)); set => WriteHere(nameof(e_oemid), value); }

        [Offset(38UL)]
        public ushort e_oeminfo { get => ReadHere<ushort>(nameof(e_oeminfo)); set => WriteHere(nameof(e_oeminfo), value); }

        [Offset(40UL)]
        [Length(10)]
        public DynamicArray e_res2 { get => ReadStructure<DynamicArray>(nameof(e_res2)); set => WriteStructure(nameof(e_res2), value); }

        [Offset(60UL)]
        public int e_lfanew { get => ReadHere<int>(nameof(e_lfanew)); set => WriteHere(nameof(e_lfanew), value); }

        public ImageDosHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ImageDosHeader>();
        }
    }
}