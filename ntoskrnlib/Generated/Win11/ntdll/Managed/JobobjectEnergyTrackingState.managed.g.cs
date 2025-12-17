using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_JOBOBJECT_ENERGY_TRACKING_STATE")]
    public sealed class JobobjectEnergyTrackingState : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Value { get => ReadHere<ulong>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public uint UpdateMask { get => ReadHere<uint>(nameof(UpdateMask)); set => WriteHere(nameof(UpdateMask), value); }

        [Offset(4UL)]
        public uint DesiredState { get => ReadHere<uint>(nameof(DesiredState)); set => WriteHere(nameof(DesiredState), value); }

        public JobobjectEnergyTrackingState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<JobobjectEnergyTrackingState>();
        }
    }
}