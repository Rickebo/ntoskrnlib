using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_NODE_NONPAGED_POOL")]
    public sealed class MiSystemNodeNonpagedPool : DynamicStructure
    {
        [Offset(0UL)]
        public MiDynamicBitmap DynamicBitMapNonPagedPool { get => ReadStructure<MiDynamicBitmap>(nameof(DynamicBitMapNonPagedPool)); set => WriteStructure(nameof(DynamicBitMapNonPagedPool), value); }

        [Offset(72UL)]
        public int NonPagedPoolSpinLock { get => ReadHere<int>(nameof(NonPagedPoolSpinLock)); set => WriteHere(nameof(NonPagedPoolSpinLock), value); }

        [Offset(80UL)]
        public MiPageChainHead CachedNonPagedPool { get => ReadStructure<MiPageChainHead>(nameof(CachedNonPagedPool)); set => WriteStructure(nameof(CachedNonPagedPool), value); }

        [Offset(104UL)]
        public IntPtr NonPagedPoolFirstVa { get => ReadHere<IntPtr>(nameof(NonPagedPoolFirstVa)); set => WriteHere(nameof(NonPagedPoolFirstVa), value); }

        [Offset(112UL)]
        public IntPtr NonPagedPoolLastVa { get => ReadHere<IntPtr>(nameof(NonPagedPoolLastVa)); set => WriteHere(nameof(NonPagedPoolLastVa), value); }

        [Offset(120UL)]
        [Length(4)]
        public DynamicArray OptimalZeroingAttribute { get => ReadStructure<DynamicArray>(nameof(OptimalZeroingAttribute)); set => WriteStructure(nameof(OptimalZeroingAttribute), value); }

        [Offset(184UL)]
        [Length(3)]
        public DynamicArray ZeroCostCounts { get => ReadStructure<DynamicArray>(nameof(ZeroCostCounts)); set => WriteStructure(nameof(ZeroCostCounts), value); }

        [Offset(376UL)]
        public IntPtr SystemNodeInformation { get => ReadHere<IntPtr>(nameof(SystemNodeInformation)); set => WriteHere(nameof(SystemNodeInformation), value); }

        public MiSystemNodeNonpagedPool(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSystemNodeNonpagedPool>();
        }
    }
}