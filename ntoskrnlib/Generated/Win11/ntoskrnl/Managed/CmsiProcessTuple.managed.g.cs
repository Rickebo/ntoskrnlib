using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CMSI_PROCESS_TUPLE")]
    public sealed class CmsiProcessTuple : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ProcessHandle { get => ReadHere<IntPtr>(nameof(ProcessHandle)); set => WriteHere(nameof(ProcessHandle), value); }

        [Offset(8UL)]
        public IntPtr ProcessReference { get => ReadHere<IntPtr>(nameof(ProcessReference)); set => WriteHere(nameof(ProcessReference), value); }

        [Offset(16UL)]
        public CmsiRwLock WorkingSetLock { get => ReadStructure<CmsiRwLock>(nameof(WorkingSetLock)); set => WriteStructure(nameof(WorkingSetLock), value); }

        [Offset(24UL)]
        public ulong LockedPageCharges { get => ReadHere<ulong>(nameof(LockedPageCharges)); set => WriteHere(nameof(LockedPageCharges), value); }

        [Offset(32UL)]
        public ulong WorkingSetMinimum { get => ReadHere<ulong>(nameof(WorkingSetMinimum)); set => WriteHere(nameof(WorkingSetMinimum), value); }

        [Offset(40UL)]
        public ulong WorkingSetMaximum { get => ReadHere<ulong>(nameof(WorkingSetMaximum)); set => WriteHere(nameof(WorkingSetMaximum), value); }

        public CmsiProcessTuple(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmsiProcessTuple>();
        }
    }
}