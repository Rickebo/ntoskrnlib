using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PS_PROCESS_WAKE_INFORMATION")]
    public sealed class PsProcessWakeInformation : DynamicStructure
    {
        [Offset(0UL)]
        public ulong NotificationChannel { get => ReadHere<ulong>(nameof(NotificationChannel)); set => WriteHere(nameof(NotificationChannel), value); }

        [Offset(8UL)]
        [Length(7)]
        public DynamicArray WakeCounters { get => ReadStructure<DynamicArray>(nameof(WakeCounters)); set => WriteStructure(nameof(WakeCounters), value); }

        [Offset(36UL)]
        public JobobjectWakeFilter WakeFilter { get => ReadStructure<JobobjectWakeFilter>(nameof(WakeFilter)); set => WriteStructure(nameof(WakeFilter), value); }

        [Offset(44UL)]
        public uint NoWakeCounter { get => ReadHere<uint>(nameof(NoWakeCounter)); set => WriteHere(nameof(NoWakeCounter), value); }

        public PsProcessWakeInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsProcessWakeInformation>();
        }
    }
}