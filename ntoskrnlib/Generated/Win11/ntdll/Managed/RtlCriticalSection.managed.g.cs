using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_CRITICAL_SECTION")]
    public sealed class RtlCriticalSection : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DebugInfo { get => ReadHere<IntPtr>(nameof(DebugInfo)); set => WriteHere(nameof(DebugInfo), value); }

        [Offset(8UL)]
        public int LockCount { get => ReadHere<int>(nameof(LockCount)); set => WriteHere(nameof(LockCount), value); }

        [Offset(12UL)]
        public int RecursionCount { get => ReadHere<int>(nameof(RecursionCount)); set => WriteHere(nameof(RecursionCount), value); }

        [Offset(16UL)]
        public IntPtr OwningThread { get => ReadHere<IntPtr>(nameof(OwningThread)); set => WriteHere(nameof(OwningThread), value); }

        [Offset(24UL)]
        public IntPtr LockSemaphore { get => ReadHere<IntPtr>(nameof(LockSemaphore)); set => WriteHere(nameof(LockSemaphore), value); }

        [Offset(32UL)]
        public ulong SpinCount { get => ReadHere<ulong>(nameof(SpinCount)); set => WriteHere(nameof(SpinCount), value); }

        public RtlCriticalSection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlCriticalSection>();
        }
    }
}