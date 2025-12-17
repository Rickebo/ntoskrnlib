using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_ONDEMAND_POINTER")]
    public sealed class HeapLfhOndemandPointer : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Invalid { get => ReadHere<ushort>(nameof(Invalid)); set => WriteHere(nameof(Invalid), value); }

        [Offset(0UL)]
        public ushort AllocationInProgress { get => ReadHere<ushort>(nameof(AllocationInProgress)); set => WriteHere(nameof(AllocationInProgress), value); }

        [Offset(0UL)]
        public ushort Spare0 { get => ReadHere<ushort>(nameof(Spare0)); set => WriteHere(nameof(Spare0), value); }

        [Offset(2UL)]
        public ushort UsageData { get => ReadHere<ushort>(nameof(UsageData)); set => WriteHere(nameof(UsageData), value); }

        [Offset(0UL)]
        public IntPtr AllBits { get => ReadHere<IntPtr>(nameof(AllBits)); set => WriteHere(nameof(AllBits), value); }

        public HeapLfhOndemandPointer(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhOndemandPointer>();
        }
    }
}