using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PERF_CONTROL_STATE_SELECTION")]
    public sealed class PerfControlStateSelection : DynamicStructure
    {
        [Offset(0UL)]
        public ulong SelectedState { get => ReadHere<ulong>(nameof(SelectedState)); set => WriteHere(nameof(SelectedState), value); }

        [Offset(8UL)]
        public ulong SelectedResourcePriority { get => ReadHere<ulong>(nameof(SelectedResourcePriority)); set => WriteHere(nameof(SelectedResourcePriority), value); }

        [Offset(16UL)]
        public uint SelectedPercent { get => ReadHere<uint>(nameof(SelectedPercent)); set => WriteHere(nameof(SelectedPercent), value); }

        [Offset(20UL)]
        public uint SelectedFrequency { get => ReadHere<uint>(nameof(SelectedFrequency)); set => WriteHere(nameof(SelectedFrequency), value); }

        [Offset(24UL)]
        public uint MinPercent { get => ReadHere<uint>(nameof(MinPercent)); set => WriteHere(nameof(MinPercent), value); }

        [Offset(28UL)]
        public uint MaxPercent { get => ReadHere<uint>(nameof(MaxPercent)); set => WriteHere(nameof(MaxPercent), value); }

        [Offset(32UL)]
        public uint TolerancePercent { get => ReadHere<uint>(nameof(TolerancePercent)); set => WriteHere(nameof(TolerancePercent), value); }

        [Offset(36UL)]
        public uint EppPercent { get => ReadHere<uint>(nameof(EppPercent)); set => WriteHere(nameof(EppPercent), value); }

        [Offset(40UL)]
        public uint AutonomousActivityWindow { get => ReadHere<uint>(nameof(AutonomousActivityWindow)); set => WriteHere(nameof(AutonomousActivityWindow), value); }

        [Offset(44UL)]
        public uint ResourcePriorityPercent { get => ReadHere<uint>(nameof(ResourcePriorityPercent)); set => WriteHere(nameof(ResourcePriorityPercent), value); }

        [Offset(48UL)]
        public byte Autonomous { get => ReadHere<byte>(nameof(Autonomous)); set => WriteHere(nameof(Autonomous), value); }

        [Offset(49UL)]
        public byte InheritFromDomain { get => ReadHere<byte>(nameof(InheritFromDomain)); set => WriteHere(nameof(InheritFromDomain), value); }

        public PerfControlStateSelection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PerfControlStateSelection>();
        }
    }
}