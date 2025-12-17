using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_BLOB_TYPE")]
    public sealed class BlobType : DynamicStructure
    {
        [Offset(0UL)]
        public uint ResourceId { get => ReadHere<uint>(nameof(ResourceId)); set => WriteHere(nameof(ResourceId), value); }

        [Offset(4UL)]
        public uint PoolTag { get => ReadHere<uint>(nameof(PoolTag)); set => WriteHere(nameof(PoolTag), value); }

        [Offset(8UL)]
        public uint LookasideIndex { get => ReadHere<uint>(nameof(LookasideIndex)); set => WriteHere(nameof(LookasideIndex), value); }

        [Offset(12UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(16UL)]
        public IntPtr Counters { get => ReadHere<IntPtr>(nameof(Counters)); set => WriteHere(nameof(Counters), value); }

        [Offset(24UL)]
        public IntPtr CleanupProcedure { get => ReadHere<IntPtr>(nameof(CleanupProcedure)); set => WriteHere(nameof(CleanupProcedure), value); }

        [Offset(32UL)]
        public IntPtr DeleteProcedure { get => ReadHere<IntPtr>(nameof(DeleteProcedure)); set => WriteHere(nameof(DeleteProcedure), value); }

        [Offset(40UL)]
        public IntPtr DestroyProcedure { get => ReadHere<IntPtr>(nameof(DestroyProcedure)); set => WriteHere(nameof(DestroyProcedure), value); }

        [Offset(48UL)]
        public ulong UsualSize { get => ReadHere<ulong>(nameof(UsualSize)); set => WriteHere(nameof(UsualSize), value); }

        public BlobType(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<BlobType>();
        }
    }
}