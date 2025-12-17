using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_BUCKET")]
    public sealed class HeapBucket : DynamicStructure
    {
        [Offset(0UL)]
        public ushort BlockUnits { get => ReadHere<ushort>(nameof(BlockUnits)); set => WriteHere(nameof(BlockUnits), value); }

        [Offset(2UL)]
        public byte SizeIndex { get => ReadHere<byte>(nameof(SizeIndex)); set => WriteHere(nameof(SizeIndex), value); }

        [Offset(3UL)]
        public byte UseAffinity { get => ReadHere<byte>(nameof(UseAffinity)); set => WriteHere(nameof(UseAffinity), value); }

        [Offset(3UL)]
        public byte DebugFlags { get => ReadHere<byte>(nameof(DebugFlags)); set => WriteHere(nameof(DebugFlags), value); }

        [Offset(3UL)]
        public byte Flags { get => ReadHere<byte>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public HeapBucket(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapBucket>();
        }
    }
}