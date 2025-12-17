using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_DEVICE_DIRECTED_TRANSITION_STATE")]
    public sealed class PopFxDeviceDirectedTransitionState : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr CompletionContext { get => ReadHere<IntPtr>(nameof(CompletionContext)); set => WriteHere(nameof(CompletionContext), value); }

        [Offset(8UL)]
        public int CompletionStatus { get => ReadHere<int>(nameof(CompletionStatus)); set => WriteHere(nameof(CompletionStatus), value); }

        [Offset(12UL)]
        public uint DIrpPending { get => ReadHere<uint>(nameof(DIrpPending)); set => WriteHere(nameof(DIrpPending), value); }

        [Offset(12UL)]
        public uint DIrpCompleted { get => ReadHere<uint>(nameof(DIrpCompleted)); set => WriteHere(nameof(DIrpCompleted), value); }

        public PopFxDeviceDirectedTransitionState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxDeviceDirectedTransitionState>();
        }
    }
}