using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PS_JOB_WAKE_INFORMATION")]
    public sealed class PsJobWakeInformation : DynamicStructure
    {
        [Offset(0UL)]
        public ulong NotificationChannel { get => ReadHere<ulong>(nameof(NotificationChannel)); set => WriteHere(nameof(NotificationChannel), value); }

        [Offset(8UL)]
        [Length(7)]
        public DynamicArray WakeCounters { get => ReadStructure<DynamicArray>(nameof(WakeCounters)); set => WriteStructure(nameof(WakeCounters), value); }

        [Offset(64UL)]
        public ulong NoWakeCounter { get => ReadHere<ulong>(nameof(NoWakeCounter)); set => WriteHere(nameof(NoWakeCounter), value); }

        public PsJobWakeInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsJobWakeInformation>();
        }
    }
}