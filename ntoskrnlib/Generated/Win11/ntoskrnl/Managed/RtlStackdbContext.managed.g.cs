using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_STACKDB_CONTEXT")]
    public sealed class RtlStackdbContext : DynamicStructure
    {
        [Offset(0UL)]
        public RtlHashTable StackSegmentTable { get => ReadStructure<RtlHashTable>(nameof(StackSegmentTable)); set => WriteStructure(nameof(StackSegmentTable), value); }

        [Offset(16UL)]
        public RtlHashTable StackEntryTable { get => ReadStructure<RtlHashTable>(nameof(StackEntryTable)); set => WriteStructure(nameof(StackEntryTable), value); }

        [Offset(32UL)]
        public RtlSrwlock StackEntryTableLock { get => ReadStructure<RtlSrwlock>(nameof(StackEntryTableLock)); set => WriteStructure(nameof(StackEntryTableLock), value); }

        [Offset(40UL)]
        public RtlSrwlock SegmentTableLock { get => ReadStructure<RtlSrwlock>(nameof(SegmentTableLock)); set => WriteStructure(nameof(SegmentTableLock), value); }

        [Offset(48UL)]
        public IntPtr Allocate { get => ReadHere<IntPtr>(nameof(Allocate)); set => WriteHere(nameof(Allocate), value); }

        [Offset(56UL)]
        public IntPtr Free { get => ReadHere<IntPtr>(nameof(Free)); set => WriteHere(nameof(Free), value); }

        [Offset(64UL)]
        public IntPtr AllocatorContext { get => ReadHere<IntPtr>(nameof(AllocatorContext)); set => WriteHere(nameof(AllocatorContext), value); }

        public RtlStackdbContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlStackdbContext>();
        }
    }
}