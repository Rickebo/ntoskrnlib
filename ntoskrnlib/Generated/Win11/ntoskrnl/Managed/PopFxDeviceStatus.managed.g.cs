using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_DEVICE_STATUS")]
    public sealed class PopFxDeviceStatus : DynamicStructure
    {
        [Offset(0UL)]
        public int Value { get => ReadHere<int>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public uint SystemTransition { get => ReadHere<uint>(nameof(SystemTransition)); set => WriteHere(nameof(SystemTransition), value); }

        [Offset(0UL)]
        public uint PepD0Notify { get => ReadHere<uint>(nameof(PepD0Notify)); set => WriteHere(nameof(PepD0Notify), value); }

        [Offset(0UL)]
        public uint IdleTimerOn { get => ReadHere<uint>(nameof(IdleTimerOn)); set => WriteHere(nameof(IdleTimerOn), value); }

        [Offset(0UL)]
        public uint IgnoreIdleTimeout { get => ReadHere<uint>(nameof(IgnoreIdleTimeout)); set => WriteHere(nameof(IgnoreIdleTimeout), value); }

        [Offset(0UL)]
        public uint IrpInUse { get => ReadHere<uint>(nameof(IrpInUse)); set => WriteHere(nameof(IrpInUse), value); }

        [Offset(0UL)]
        public uint IrpPending { get => ReadHere<uint>(nameof(IrpPending)); set => WriteHere(nameof(IrpPending), value); }

        [Offset(0UL)]
        public uint DPNRDeviceNotified { get => ReadHere<uint>(nameof(DPNRDeviceNotified)); set => WriteHere(nameof(DPNRDeviceNotified), value); }

        [Offset(0UL)]
        public uint DPNRReceivedFromPep { get => ReadHere<uint>(nameof(DPNRReceivedFromPep)); set => WriteHere(nameof(DPNRReceivedFromPep), value); }

        [Offset(0UL)]
        public uint IrpFirstPendingIndex { get => ReadHere<uint>(nameof(IrpFirstPendingIndex)); set => WriteHere(nameof(IrpFirstPendingIndex), value); }

        [Offset(0UL)]
        public uint IrpLastPendingIndex { get => ReadHere<uint>(nameof(IrpLastPendingIndex)); set => WriteHere(nameof(IrpLastPendingIndex), value); }

        [Offset(0UL)]
        public uint SIrpBlocked { get => ReadHere<uint>(nameof(SIrpBlocked)); set => WriteHere(nameof(SIrpBlocked), value); }

        [Offset(0UL)]
        public uint BlockFastResume { get => ReadHere<uint>(nameof(BlockFastResume)); set => WriteHere(nameof(BlockFastResume), value); }

        [Offset(0UL)]
        public uint DirectedPoweredDown { get => ReadHere<uint>(nameof(DirectedPoweredDown)); set => WriteHere(nameof(DirectedPoweredDown), value); }

        [Offset(0UL)]
        public uint DirectedTransitionInProgress { get => ReadHere<uint>(nameof(DirectedTransitionInProgress)); set => WriteHere(nameof(DirectedTransitionInProgress), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public PopFxDeviceStatus(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxDeviceStatus>();
        }
    }
}