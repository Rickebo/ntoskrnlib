using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_LINE_INTERNAL_STATE")]
    public sealed class InterruptLineInternalState : DynamicStructure
    {
        [Offset(0UL)]
        public byte Fixed { get => ReadHere<byte>(nameof(Fixed)); set => WriteHere(nameof(Fixed), value); }

        [Offset(1UL)]
        public byte Irql { get => ReadHere<byte>(nameof(Irql)); set => WriteHere(nameof(Irql), value); }

        [Offset(2UL)]
        public byte Swapping { get => ReadHere<byte>(nameof(Swapping)); set => WriteHere(nameof(Swapping), value); }

        [Offset(4UL)]
        public uint OldClusterId { get => ReadHere<uint>(nameof(OldClusterId)); set => WriteHere(nameof(OldClusterId), value); }

        [Offset(8UL)]
        public uint OldClusterMask { get => ReadHere<uint>(nameof(OldClusterMask)); set => WriteHere(nameof(OldClusterMask), value); }

        [Offset(12UL)]
        public byte LineStateDetermined { get => ReadHere<byte>(nameof(LineStateDetermined)); set => WriteHere(nameof(LineStateDetermined), value); }

        public InterruptLineInternalState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InterruptLineInternalState>();
        }
    }
}