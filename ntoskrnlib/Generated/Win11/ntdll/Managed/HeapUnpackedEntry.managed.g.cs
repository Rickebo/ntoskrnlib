using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_UNPACKED_ENTRY")]
    public sealed class HeapUnpackedEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr PreviousBlockPrivateData { get => ReadHere<IntPtr>(nameof(PreviousBlockPrivateData)); set => WriteHere(nameof(PreviousBlockPrivateData), value); }

        [Offset(8UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(10UL)]
        public byte Flags { get => ReadHere<byte>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(11UL)]
        public byte SmallTagIndex { get => ReadHere<byte>(nameof(SmallTagIndex)); set => WriteHere(nameof(SmallTagIndex), value); }

        [Offset(8UL)]
        public uint SubSegmentCode { get => ReadHere<uint>(nameof(SubSegmentCode)); set => WriteHere(nameof(SubSegmentCode), value); }

        [Offset(12UL)]
        public ushort PreviousSize { get => ReadHere<ushort>(nameof(PreviousSize)); set => WriteHere(nameof(PreviousSize), value); }

        [Offset(14UL)]
        public byte SegmentOffset { get => ReadHere<byte>(nameof(SegmentOffset)); set => WriteHere(nameof(SegmentOffset), value); }

        [Offset(14UL)]
        public byte LFHFlags { get => ReadHere<byte>(nameof(LFHFlags)); set => WriteHere(nameof(LFHFlags), value); }

        [Offset(15UL)]
        public byte UnusedBytes { get => ReadHere<byte>(nameof(UnusedBytes)); set => WriteHere(nameof(UnusedBytes), value); }

        [Offset(8UL)]
        public ulong CompactHeader { get => ReadHere<ulong>(nameof(CompactHeader)); set => WriteHere(nameof(CompactHeader), value); }

        public HeapUnpackedEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapUnpackedEntry>();
        }
    }
}