using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_DRIVER_CALLBACKS")]
    public sealed class PopFxDriverCallbacks : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ComponentActive { get => ReadHere<IntPtr>(nameof(ComponentActive)); set => WriteHere(nameof(ComponentActive), value); }

        [Offset(8UL)]
        public IntPtr ComponentIdle { get => ReadHere<IntPtr>(nameof(ComponentIdle)); set => WriteHere(nameof(ComponentIdle), value); }

        [Offset(16UL)]
        public IntPtr ComponentIdleState { get => ReadHere<IntPtr>(nameof(ComponentIdleState)); set => WriteHere(nameof(ComponentIdleState), value); }

        [Offset(24UL)]
        public IntPtr DevicePowerRequired { get => ReadHere<IntPtr>(nameof(DevicePowerRequired)); set => WriteHere(nameof(DevicePowerRequired), value); }

        [Offset(32UL)]
        public IntPtr DevicePowerNotRequired { get => ReadHere<IntPtr>(nameof(DevicePowerNotRequired)); set => WriteHere(nameof(DevicePowerNotRequired), value); }

        [Offset(40UL)]
        public IntPtr PowerControl { get => ReadHere<IntPtr>(nameof(PowerControl)); set => WriteHere(nameof(PowerControl), value); }

        [Offset(48UL)]
        public IntPtr ComponentCriticalTransition { get => ReadHere<IntPtr>(nameof(ComponentCriticalTransition)); set => WriteHere(nameof(ComponentCriticalTransition), value); }

        [Offset(56UL)]
        public IntPtr DripsWatchdogCallback { get => ReadHere<IntPtr>(nameof(DripsWatchdogCallback)); set => WriteHere(nameof(DripsWatchdogCallback), value); }

        [Offset(64UL)]
        public IntPtr DirectedPowerUpCallback { get => ReadHere<IntPtr>(nameof(DirectedPowerUpCallback)); set => WriteHere(nameof(DirectedPowerUpCallback), value); }

        [Offset(72UL)]
        public IntPtr DirectedPowerDownCallback { get => ReadHere<IntPtr>(nameof(DirectedPowerDownCallback)); set => WriteHere(nameof(DirectedPowerDownCallback), value); }

        public PopFxDriverCallbacks(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxDriverCallbacks>();
        }
    }
}