using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_USERDATA_HEADER")]
    public sealed class HeapUserdataHeader : DynamicStructure
    {
        [Offset(0UL)]
        public SingleListEntry SFreeListEntry { get => ReadStructure<SingleListEntry>(nameof(SFreeListEntry)); set => WriteStructure(nameof(SFreeListEntry), value); }

        [Offset(0UL)]
        public IntPtr SubSegment { get => ReadHere<IntPtr>(nameof(SubSegment)); set => WriteHere(nameof(SubSegment), value); }

        [Offset(8UL)]
        public IntPtr Reserved { get => ReadHere<IntPtr>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(16UL)]
        public uint SizeIndexAndPadding { get => ReadHere<uint>(nameof(SizeIndexAndPadding)); set => WriteHere(nameof(SizeIndexAndPadding), value); }

        [Offset(16UL)]
        public byte SizeIndex { get => ReadHere<byte>(nameof(SizeIndex)); set => WriteHere(nameof(SizeIndex), value); }

        [Offset(17UL)]
        public byte GuardPagePresent { get => ReadHere<byte>(nameof(GuardPagePresent)); set => WriteHere(nameof(GuardPagePresent), value); }

        [Offset(18UL)]
        public ushort PaddingBytes { get => ReadHere<ushort>(nameof(PaddingBytes)); set => WriteHere(nameof(PaddingBytes), value); }

        [Offset(20UL)]
        public uint Signature { get => ReadHere<uint>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(24UL)]
        public HeapUserdataOffsets EncodedOffsets { get => ReadStructure<HeapUserdataOffsets>(nameof(EncodedOffsets)); set => WriteStructure(nameof(EncodedOffsets), value); }

        [Offset(32UL)]
        public RtlBitmapEx BusyBitmap { get => ReadStructure<RtlBitmapEx>(nameof(BusyBitmap)); set => WriteStructure(nameof(BusyBitmap), value); }

        [Offset(48UL)]
        [Length(1)]
        public DynamicArray BitmapData { get => ReadStructure<DynamicArray>(nameof(BitmapData)); set => WriteStructure(nameof(BitmapData), value); }

        public HeapUserdataHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapUserdataHeader>();
        }
    }
}