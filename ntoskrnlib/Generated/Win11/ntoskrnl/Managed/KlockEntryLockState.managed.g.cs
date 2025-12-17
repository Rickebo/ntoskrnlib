using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KLOCK_ENTRY_LOCK_STATE")]
    public sealed class KlockEntryLockState : DynamicStructure
    {
        [Offset(0UL)]
        public ulong CrossThreadReleasable { get => ReadHere<ulong>(nameof(CrossThreadReleasable)); set => WriteHere(nameof(CrossThreadReleasable), value); }

        [Offset(0UL)]
        public ulong Busy { get => ReadHere<ulong>(nameof(Busy)); set => WriteHere(nameof(Busy), value); }

        [Offset(0UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ulong InTree { get => ReadHere<ulong>(nameof(InTree)); set => WriteHere(nameof(InTree), value); }

        [Offset(0UL)]
        public IntPtr LockState { get => ReadHere<IntPtr>(nameof(LockState)); set => WriteHere(nameof(LockState), value); }

        public KlockEntryLockState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KlockEntryLockState>();
        }
    }
}