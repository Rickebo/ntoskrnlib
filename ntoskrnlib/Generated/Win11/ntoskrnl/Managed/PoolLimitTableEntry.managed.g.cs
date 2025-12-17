using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POOL_LIMIT_TABLE_ENTRY")]
    public sealed class PoolLimitTableEntry : DynamicStructure
    {
        [Offset(0UL)]
        public RtlHashEntry HashEntry { get => ReadStructure<RtlHashEntry>(nameof(HashEntry)); set => WriteStructure(nameof(HashEntry), value); }

        [Offset(0UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(8UL)]
        public SingleListEntry SListEntry { get => ReadStructure<SingleListEntry>(nameof(SListEntry)); set => WriteStructure(nameof(SListEntry), value); }

        [Offset(16UL)]
        [Length(2)]
        public DynamicArray LimitInfo { get => ReadStructure<DynamicArray>(nameof(LimitInfo)); set => WriteStructure(nameof(LimitInfo), value); }

        [Offset(64UL)]
        public WnfStateName NotificationObject { get => ReadStructure<WnfStateName>(nameof(NotificationObject)); set => WriteStructure(nameof(NotificationObject), value); }

        [Offset(80UL)]
        public SlistEntry NotificationEntry { get => ReadStructure<SlistEntry>(nameof(NotificationEntry)); set => WriteStructure(nameof(NotificationEntry), value); }

        [Offset(96UL)]
        public uint Scheduled { get => ReadHere<uint>(nameof(Scheduled)); set => WriteHere(nameof(Scheduled), value); }

        public PoolLimitTableEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoolLimitTableEntry>();
        }
    }
}