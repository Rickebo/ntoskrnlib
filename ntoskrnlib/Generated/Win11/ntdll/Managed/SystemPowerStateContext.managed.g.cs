using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_SYSTEM_POWER_STATE_CONTEXT")]
    public sealed class SystemPowerStateContext : DynamicStructure
    {
        [Offset(0UL)]
        public uint Reserved1 { get => ReadHere<uint>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(0UL)]
        public uint TargetSystemState { get => ReadHere<uint>(nameof(TargetSystemState)); set => WriteHere(nameof(TargetSystemState), value); }

        [Offset(0UL)]
        public uint EffectiveSystemState { get => ReadHere<uint>(nameof(EffectiveSystemState)); set => WriteHere(nameof(EffectiveSystemState), value); }

        [Offset(0UL)]
        public uint CurrentSystemState { get => ReadHere<uint>(nameof(CurrentSystemState)); set => WriteHere(nameof(CurrentSystemState), value); }

        [Offset(0UL)]
        public uint IgnoreHibernationPath { get => ReadHere<uint>(nameof(IgnoreHibernationPath)); set => WriteHere(nameof(IgnoreHibernationPath), value); }

        [Offset(0UL)]
        public uint PseudoTransition { get => ReadHere<uint>(nameof(PseudoTransition)); set => WriteHere(nameof(PseudoTransition), value); }

        [Offset(0UL)]
        public uint KernelSoftReboot { get => ReadHere<uint>(nameof(KernelSoftReboot)); set => WriteHere(nameof(KernelSoftReboot), value); }

        [Offset(0UL)]
        public uint DirectedDripsTransition { get => ReadHere<uint>(nameof(DirectedDripsTransition)); set => WriteHere(nameof(DirectedDripsTransition), value); }

        [Offset(0UL)]
        public uint Reserved2 { get => ReadHere<uint>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(0UL)]
        public uint ContextAsUlong { get => ReadHere<uint>(nameof(ContextAsUlong)); set => WriteHere(nameof(ContextAsUlong), value); }

        public SystemPowerStateContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SystemPowerStateContext>();
        }
    }
}