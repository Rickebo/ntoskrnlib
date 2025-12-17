using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_ACCELERATORS")]
    public sealed class MiSystemAccelerators : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry HardwareInstances { get => ReadStructure<ListEntry>(nameof(HardwareInstances)); set => WriteStructure(nameof(HardwareInstances), value); }

        [Offset(16UL)]
        public uint NumberOfHardwareInstances { get => ReadHere<uint>(nameof(NumberOfHardwareInstances)); set => WriteHere(nameof(NumberOfHardwareInstances), value); }

        [Offset(20UL)]
        public byte ShuttingDown { get => ReadHere<byte>(nameof(ShuttingDown)); set => WriteHere(nameof(ShuttingDown), value); }

        [Offset(21UL)]
        public byte AllocationFailures { get => ReadHere<byte>(nameof(AllocationFailures)); set => WriteHere(nameof(AllocationFailures), value); }

        [Offset(22UL)]
        public byte AllocationQueryFailures { get => ReadHere<byte>(nameof(AllocationQueryFailures)); set => WriteHere(nameof(AllocationQueryFailures), value); }

        [Offset(23UL)]
        public byte AllocationQueryBadNodes { get => ReadHere<byte>(nameof(AllocationQueryBadNodes)); set => WriteHere(nameof(AllocationQueryBadNodes), value); }

        [Offset(24UL)]
        public SingleListEntry DeferredPoolFrees { get => ReadStructure<SingleListEntry>(nameof(DeferredPoolFrees)); set => WriteStructure(nameof(DeferredPoolFrees), value); }

        [Offset(32UL)]
        public IntPtr OpaqueContext { get => ReadHere<IntPtr>(nameof(OpaqueContext)); set => WriteHere(nameof(OpaqueContext), value); }

        [Offset(40UL)]
        public int Lock { get => ReadHere<int>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        public MiSystemAccelerators(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSystemAccelerators>();
        }
    }
}