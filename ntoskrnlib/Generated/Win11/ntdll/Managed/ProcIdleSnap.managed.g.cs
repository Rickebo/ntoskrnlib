using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PROC_IDLE_SNAP")]
    public sealed class ProcIdleSnap : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Time { get => ReadHere<ulong>(nameof(Time)); set => WriteHere(nameof(Time), value); }

        [Offset(8UL)]
        public ulong Idle { get => ReadHere<ulong>(nameof(Idle)); set => WriteHere(nameof(Idle), value); }

        public ProcIdleSnap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcIdleSnap>();
        }
    }
}