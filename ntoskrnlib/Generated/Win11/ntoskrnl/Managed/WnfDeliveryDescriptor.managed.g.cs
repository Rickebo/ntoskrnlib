using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_DELIVERY_DESCRIPTOR")]
    public sealed class WnfDeliveryDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public ulong SubscriptionId { get => ReadHere<ulong>(nameof(SubscriptionId)); set => WriteHere(nameof(SubscriptionId), value); }

        [Offset(8UL)]
        public WnfStateName StateName { get => ReadStructure<WnfStateName>(nameof(StateName)); set => WriteStructure(nameof(StateName), value); }

        [Offset(16UL)]
        public uint ChangeStamp { get => ReadHere<uint>(nameof(ChangeStamp)); set => WriteHere(nameof(ChangeStamp), value); }

        [Offset(20UL)]
        public uint StateDataSize { get => ReadHere<uint>(nameof(StateDataSize)); set => WriteHere(nameof(StateDataSize), value); }

        [Offset(24UL)]
        public uint EventMask { get => ReadHere<uint>(nameof(EventMask)); set => WriteHere(nameof(EventMask), value); }

        [Offset(28UL)]
        public WnfTypeId TypeId { get => ReadStructure<WnfTypeId>(nameof(TypeId)); set => WriteStructure(nameof(TypeId), value); }

        [Offset(44UL)]
        public uint StateDataOffset { get => ReadHere<uint>(nameof(StateDataOffset)); set => WriteHere(nameof(StateDataOffset), value); }

        public WnfDeliveryDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfDeliveryDescriptor>();
        }
    }
}