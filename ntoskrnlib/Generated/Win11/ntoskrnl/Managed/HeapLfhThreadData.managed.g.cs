using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_THREAD_DATA")]
    public sealed class HeapLfhThreadData : DynamicStructure
    {
        [Offset(0UL)]
        public ushort SlotMapRef { get => ReadHere<ushort>(nameof(SlotMapRef)); set => WriteHere(nameof(SlotMapRef), value); }

        [Offset(2UL)]
        public ushort HeatMapRef { get => ReadHere<ushort>(nameof(HeatMapRef)); set => WriteHere(nameof(HeatMapRef), value); }

        [Offset(4UL)]
        public byte CachedProcIndex { get => ReadHere<byte>(nameof(CachedProcIndex)); set => WriteHere(nameof(CachedProcIndex), value); }

        [Offset(5UL)]
        public byte ContentionRemapCount { get => ReadHere<byte>(nameof(ContentionRemapCount)); set => WriteHere(nameof(ContentionRemapCount), value); }

        [Offset(6UL)]
        public ushort Spare { get => ReadHere<ushort>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(0UL)]
        public IntPtr AllBits { get => ReadHere<IntPtr>(nameof(AllBits)); set => WriteHere(nameof(AllBits), value); }

        public HeapLfhThreadData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhThreadData>();
        }
    }
}