using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FAST_ERESOURCE_INTERNAL")]
    public sealed class FastEresourceInternal : DynamicStructure
    {
        [Offset(0UL)]
        public FastEresourceLockState LockWord { get => ReadStructure<FastEresourceLockState>(nameof(LockWord)); set => WriteStructure(nameof(LockWord), value); }

        [Offset(8UL)]
        public KwaitChain SharedWaiters { get => ReadStructure<KwaitChain>(nameof(SharedWaiters)); set => WriteStructure(nameof(SharedWaiters), value); }

        [Offset(16UL)]
        public KwaitChain ExclusiveWaiters { get => ReadStructure<KwaitChain>(nameof(ExclusiveWaiters)); set => WriteStructure(nameof(ExclusiveWaiters), value); }

        [Offset(24UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(25UL)]
        public sbyte MiscFlags { get => ReadHere<sbyte>(nameof(MiscFlags)); set => WriteHere(nameof(MiscFlags), value); }

        [Offset(26UL)]
        public ushort Flag { get => ReadHere<ushort>(nameof(Flag)); set => WriteHere(nameof(Flag), value); }

        [Offset(28UL)]
        public uint ResourceTimeoutCount { get => ReadHere<uint>(nameof(ResourceTimeoutCount)); set => WriteHere(nameof(ResourceTimeoutCount), value); }

        [Offset(32UL)]
        public uint Reserved1 { get => ReadHere<uint>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(40UL)]
        public ulong CreatorBackTraceIndex { get => ReadHere<ulong>(nameof(CreatorBackTraceIndex)); set => WriteHere(nameof(CreatorBackTraceIndex), value); }

        [Offset(48UL)]
        public ulong SpinLock { get => ReadHere<ulong>(nameof(SpinLock)); set => WriteHere(nameof(SpinLock), value); }

        [Offset(56UL)]
        public uint NumberOfSharedWaiters { get => ReadHere<uint>(nameof(NumberOfSharedWaiters)); set => WriteHere(nameof(NumberOfSharedWaiters), value); }

        [Offset(60UL)]
        public uint ContentionCount { get => ReadHere<uint>(nameof(ContentionCount)); set => WriteHere(nameof(ContentionCount), value); }

        [Offset(64UL)]
        public FastOwnerEntryInternal ExclusiveOwnerEntry { get => ReadStructure<FastOwnerEntryInternal>(nameof(ExclusiveOwnerEntry)); set => WriteStructure(nameof(ExclusiveOwnerEntry), value); }

        public FastEresourceInternal(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FastEresourceInternal>();
        }
    }
}