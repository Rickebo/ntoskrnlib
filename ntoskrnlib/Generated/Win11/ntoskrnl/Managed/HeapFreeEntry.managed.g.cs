using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_FREE_ENTRY")]
    public sealed class HeapFreeEntry : DynamicStructure
    {
        [Offset(0UL)]
        public HeapEntry HeapEntry { get => ReadStructure<HeapEntry>(nameof(HeapEntry)); set => WriteStructure(nameof(HeapEntry), value); }

        [Offset(0UL)]
        public HeapUnpackedEntry UnpackedEntry { get => ReadStructure<HeapUnpackedEntry>(nameof(UnpackedEntry)); set => WriteStructure(nameof(UnpackedEntry), value); }

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

        [Offset(0UL)]
        public HeapExtendedEntry ExtendedEntry { get => ReadStructure<HeapExtendedEntry>(nameof(ExtendedEntry)); set => WriteStructure(nameof(ExtendedEntry), value); }

        [Offset(0UL)]
        public IntPtr Reserved { get => ReadHere<IntPtr>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(8UL)]
        public ushort FunctionIndex { get => ReadHere<ushort>(nameof(FunctionIndex)); set => WriteHere(nameof(FunctionIndex), value); }

        [Offset(10UL)]
        public ushort ContextValue { get => ReadHere<ushort>(nameof(ContextValue)); set => WriteHere(nameof(ContextValue), value); }

        [Offset(8UL)]
        public uint InterceptorValue { get => ReadHere<uint>(nameof(InterceptorValue)); set => WriteHere(nameof(InterceptorValue), value); }

        [Offset(12UL)]
        public ushort UnusedBytesLength { get => ReadHere<ushort>(nameof(UnusedBytesLength)); set => WriteHere(nameof(UnusedBytesLength), value); }

        [Offset(14UL)]
        public byte EntryOffset { get => ReadHere<byte>(nameof(EntryOffset)); set => WriteHere(nameof(EntryOffset), value); }

        [Offset(15UL)]
        public byte ExtendedBlockSignature { get => ReadHere<byte>(nameof(ExtendedBlockSignature)); set => WriteHere(nameof(ExtendedBlockSignature), value); }

        [Offset(0UL)]
        public IntPtr ReservedForAlignment { get => ReadHere<IntPtr>(nameof(ReservedForAlignment)); set => WriteHere(nameof(ReservedForAlignment), value); }

        [Offset(8UL)]
        public uint Code1 { get => ReadHere<uint>(nameof(Code1)); set => WriteHere(nameof(Code1), value); }

        [Offset(12UL)]
        public ushort Code2 { get => ReadHere<ushort>(nameof(Code2)); set => WriteHere(nameof(Code2), value); }

        [Offset(14UL)]
        public byte Code3 { get => ReadHere<byte>(nameof(Code3)); set => WriteHere(nameof(Code3), value); }

        [Offset(15UL)]
        public byte Code4 { get => ReadHere<byte>(nameof(Code4)); set => WriteHere(nameof(Code4), value); }

        [Offset(12UL)]
        public uint Code234 { get => ReadHere<uint>(nameof(Code234)); set => WriteHere(nameof(Code234), value); }

        [Offset(8UL)]
        public ulong AgregateCode { get => ReadHere<ulong>(nameof(AgregateCode)); set => WriteHere(nameof(AgregateCode), value); }

        [Offset(16UL)]
        public ListEntry FreeList { get => ReadStructure<ListEntry>(nameof(FreeList)); set => WriteStructure(nameof(FreeList), value); }

        public HeapFreeEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapFreeEntry>();
        }
    }
}