using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_CSPARSE_BITMAP")]
    public sealed class RtlCsparseBitmap : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr CommitBitmap { get => ReadHere<IntPtr>(nameof(CommitBitmap)); set => WriteHere(nameof(CommitBitmap), value); }

        [Offset(8UL)]
        public IntPtr UserBitmap { get => ReadHere<IntPtr>(nameof(UserBitmap)); set => WriteHere(nameof(UserBitmap), value); }

        [Offset(16UL)]
        public ulong BitCount { get => ReadHere<ulong>(nameof(BitCount)); set => WriteHere(nameof(BitCount), value); }

        [Offset(24UL)]
        public ulong BitmapLock { get => ReadHere<ulong>(nameof(BitmapLock)); set => WriteHere(nameof(BitmapLock), value); }

        [Offset(32UL)]
        public ulong DecommitPageIndex { get => ReadHere<ulong>(nameof(DecommitPageIndex)); set => WriteHere(nameof(DecommitPageIndex), value); }

        [Offset(40UL)]
        public ulong RtlpCSparseBitmapWakeLock { get => ReadHere<ulong>(nameof(RtlpCSparseBitmapWakeLock)); set => WriteHere(nameof(RtlpCSparseBitmapWakeLock), value); }

        [Offset(48UL)]
        public byte LockType { get => ReadHere<byte>(nameof(LockType)); set => WriteHere(nameof(LockType), value); }

        [Offset(49UL)]
        public byte AddressSpace { get => ReadHere<byte>(nameof(AddressSpace)); set => WriteHere(nameof(AddressSpace), value); }

        [Offset(50UL)]
        public byte MemType { get => ReadHere<byte>(nameof(MemType)); set => WriteHere(nameof(MemType), value); }

        [Offset(51UL)]
        public byte AllocAlignment { get => ReadHere<byte>(nameof(AllocAlignment)); set => WriteHere(nameof(AllocAlignment), value); }

        [Offset(52UL)]
        public uint CommitDirectoryMaxSize { get => ReadHere<uint>(nameof(CommitDirectoryMaxSize)); set => WriteHere(nameof(CommitDirectoryMaxSize), value); }

        [Offset(56UL)]
        [Length(1)]
        public DynamicArray CommitDirectory { get => ReadStructure<DynamicArray>(nameof(CommitDirectory)); set => WriteStructure(nameof(CommitDirectory), value); }

        public RtlCsparseBitmap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlCsparseBitmap>();
        }
    }
}