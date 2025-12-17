using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_IO_INFO")]
    public sealed class PopIoInfo : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DumpMdl { get => ReadHere<IntPtr>(nameof(DumpMdl)); set => WriteHere(nameof(DumpMdl), value); }

        [Offset(8UL)]
        public uint IoStatus { get => ReadHere<uint>(nameof(IoStatus)); set => WriteHere(nameof(IoStatus), value); }

        [Offset(16UL)]
        public ulong IoStartCount { get => ReadHere<ulong>(nameof(IoStartCount)); set => WriteHere(nameof(IoStartCount), value); }

        [Offset(24UL)]
        public ulong IoBytesCompleted { get => ReadHere<ulong>(nameof(IoBytesCompleted)); set => WriteHere(nameof(IoBytesCompleted), value); }

        [Offset(32UL)]
        public ulong IoBytesInProgress { get => ReadHere<ulong>(nameof(IoBytesInProgress)); set => WriteHere(nameof(IoBytesInProgress), value); }

        [Offset(40UL)]
        public ulong RequestSize { get => ReadHere<ulong>(nameof(RequestSize)); set => WriteHere(nameof(RequestSize), value); }

        [Offset(48UL)]
        public LargeInteger IoLocation { get => ReadStructure<LargeInteger>(nameof(IoLocation)); set => WriteStructure(nameof(IoLocation), value); }

        [Offset(56UL)]
        public ulong FileOffset { get => ReadHere<ulong>(nameof(FileOffset)); set => WriteHere(nameof(FileOffset), value); }

        [Offset(64UL)]
        public IntPtr Buffer { get => ReadHere<IntPtr>(nameof(Buffer)); set => WriteHere(nameof(Buffer), value); }

        [Offset(72UL)]
        public byte AsyncCapable { get => ReadHere<byte>(nameof(AsyncCapable)); set => WriteHere(nameof(AsyncCapable), value); }

        [Offset(80UL)]
        public ulong BytesToRead { get => ReadHere<ulong>(nameof(BytesToRead)); set => WriteHere(nameof(BytesToRead), value); }

        [Offset(88UL)]
        public uint Pages { get => ReadHere<uint>(nameof(Pages)); set => WriteHere(nameof(Pages), value); }

        [Offset(96UL)]
        public ulong HighestChecksumIndex { get => ReadHere<ulong>(nameof(HighestChecksumIndex)); set => WriteHere(nameof(HighestChecksumIndex), value); }

        [Offset(104UL)]
        public ushort PreviousChecksum { get => ReadHere<ushort>(nameof(PreviousChecksum)); set => WriteHere(nameof(PreviousChecksum), value); }

        public PopIoInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopIoInfo>();
        }
    }
}