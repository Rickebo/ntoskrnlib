using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NON_PAGED_DEBUG_INFO")]
    public sealed class NonPagedDebugInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Signature { get => ReadHere<ushort>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(2UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(4UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public ushort Machine { get => ReadHere<ushort>(nameof(Machine)); set => WriteHere(nameof(Machine), value); }

        [Offset(10UL)]
        public ushort Characteristics { get => ReadHere<ushort>(nameof(Characteristics)); set => WriteHere(nameof(Characteristics), value); }

        [Offset(12UL)]
        public uint TimeDateStamp { get => ReadHere<uint>(nameof(TimeDateStamp)); set => WriteHere(nameof(TimeDateStamp), value); }

        [Offset(16UL)]
        public uint CheckSum { get => ReadHere<uint>(nameof(CheckSum)); set => WriteHere(nameof(CheckSum), value); }

        [Offset(20UL)]
        public uint SizeOfImage { get => ReadHere<uint>(nameof(SizeOfImage)); set => WriteHere(nameof(SizeOfImage), value); }

        [Offset(24UL)]
        public ulong ImageBase { get => ReadHere<ulong>(nameof(ImageBase)); set => WriteHere(nameof(ImageBase), value); }

        public NonPagedDebugInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NonPagedDebugInfo>();
        }
    }
}