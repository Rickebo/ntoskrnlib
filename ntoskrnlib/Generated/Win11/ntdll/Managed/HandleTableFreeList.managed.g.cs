using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HANDLE_TABLE_FREE_LIST")]
    public sealed class HandleTableFreeList : DynamicStructure
    {
        [Offset(0UL)]
        public ExPushLock FreeListLock { get => ReadStructure<ExPushLock>(nameof(FreeListLock)); set => WriteStructure(nameof(FreeListLock), value); }

        [Offset(8UL)]
        public IntPtr FirstFreeHandleEntry { get => ReadHere<IntPtr>(nameof(FirstFreeHandleEntry)); set => WriteHere(nameof(FirstFreeHandleEntry), value); }

        [Offset(16UL)]
        public IntPtr LastFreeHandleEntry { get => ReadHere<IntPtr>(nameof(LastFreeHandleEntry)); set => WriteHere(nameof(LastFreeHandleEntry), value); }

        [Offset(24UL)]
        public int HandleCount { get => ReadHere<int>(nameof(HandleCount)); set => WriteHere(nameof(HandleCount), value); }

        [Offset(28UL)]
        public uint HighWaterMark { get => ReadHere<uint>(nameof(HighWaterMark)); set => WriteHere(nameof(HighWaterMark), value); }

        public HandleTableFreeList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HandleTableFreeList>();
        }
    }
}