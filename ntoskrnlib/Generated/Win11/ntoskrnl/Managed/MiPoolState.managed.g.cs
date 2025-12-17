using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_POOL_STATE")]
    public sealed class MiPoolState : DynamicStructure
    {
        [Offset(0UL)]
        public ulong MaximumNonPagedPoolThreshold { get => ReadHere<ulong>(nameof(MaximumNonPagedPoolThreshold)); set => WriteHere(nameof(MaximumNonPagedPoolThreshold), value); }

        [Offset(8UL)]
        public ulong AllocatedNonPagedPool { get => ReadHere<ulong>(nameof(AllocatedNonPagedPool)); set => WriteHere(nameof(AllocatedNonPagedPool), value); }

        [Offset(16UL)]
        public ulong AllocatedSecureNonPagedPool { get => ReadHere<ulong>(nameof(AllocatedSecureNonPagedPool)); set => WriteHere(nameof(AllocatedSecureNonPagedPool), value); }

        [Offset(24UL)]
        public uint HighEventSets { get => ReadHere<uint>(nameof(HighEventSets)); set => WriteHere(nameof(HighEventSets), value); }

        [Offset(28UL)]
        public byte HighEventSetsValid { get => ReadHere<byte>(nameof(HighEventSetsValid)); set => WriteHere(nameof(HighEventSetsValid), value); }

        [Offset(32UL)]
        public ulong LowPagedPoolThreshold { get => ReadHere<ulong>(nameof(LowPagedPoolThreshold)); set => WriteHere(nameof(LowPagedPoolThreshold), value); }

        [Offset(40UL)]
        public ulong HighPagedPoolThreshold { get => ReadHere<ulong>(nameof(HighPagedPoolThreshold)); set => WriteHere(nameof(HighPagedPoolThreshold), value); }

        [Offset(48UL)]
        public int PermittedFaultsLock { get => ReadHere<int>(nameof(PermittedFaultsLock)); set => WriteHere(nameof(PermittedFaultsLock), value); }

        [Offset(56UL)]
        public RtlAvlTree PermittedFaultsTree { get => ReadStructure<RtlAvlTree>(nameof(PermittedFaultsTree)); set => WriteStructure(nameof(PermittedFaultsTree), value); }

        [Offset(64UL)]
        [Length(2)]
        public DynamicArray PermittedFaultsInitialNode { get => ReadStructure<DynamicArray>(nameof(PermittedFaultsInitialNode)); set => WriteStructure(nameof(PermittedFaultsInitialNode), value); }

        [Offset(144UL)]
        public ulong TotalPagedPoolQuota { get => ReadHere<ulong>(nameof(TotalPagedPoolQuota)); set => WriteHere(nameof(TotalPagedPoolQuota), value); }

        [Offset(152UL)]
        public ulong TotalNonPagedPoolQuota { get => ReadHere<ulong>(nameof(TotalNonPagedPoolQuota)); set => WriteHere(nameof(TotalNonPagedPoolQuota), value); }

        [Offset(192UL)]
        [Length(4)]
        public DynamicArray PagedPoolWorkingSetLockArray { get => ReadStructure<DynamicArray>(nameof(PagedPoolWorkingSetLockArray)); set => WriteStructure(nameof(PagedPoolWorkingSetLockArray), value); }

        public MiPoolState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPoolState>();
        }
    }
}