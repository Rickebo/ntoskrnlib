using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_AGGREGATED_PAYLOAD_FILTER")]
    public sealed class AggregatedPayloadFilter : DynamicStructure
    {
        [Offset(0UL)]
        public ushort MagicValue { get => ReadHere<ushort>(nameof(MagicValue)); set => WriteHere(nameof(MagicValue), value); }

        [Offset(0UL)]
        public ushort DescriptorVersion { get => ReadHere<ushort>(nameof(DescriptorVersion)); set => WriteHere(nameof(DescriptorVersion), value); }

        [Offset(2UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(4UL)]
        public ushort PredicateCount { get => ReadHere<ushort>(nameof(PredicateCount)); set => WriteHere(nameof(PredicateCount), value); }

        [Offset(6UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(8UL)]
        public ulong HashedEventIdBitmap { get => ReadHere<ulong>(nameof(HashedEventIdBitmap)); set => WriteHere(nameof(HashedEventIdBitmap), value); }

        [Offset(16UL)]
        public Guid ProviderGuid { get => ReadStructure<Guid>(nameof(ProviderGuid)); set => WriteStructure(nameof(ProviderGuid), value); }

        [Offset(32UL)]
        public ushort EachEventTableOffset { get => ReadHere<ushort>(nameof(EachEventTableOffset)); set => WriteHere(nameof(EachEventTableOffset), value); }

        [Offset(34UL)]
        public ushort EachEventTableLength { get => ReadHere<ushort>(nameof(EachEventTableLength)); set => WriteHere(nameof(EachEventTableLength), value); }

        [Offset(36UL)]
        public ushort PayloadDecoderTableOffset { get => ReadHere<ushort>(nameof(PayloadDecoderTableOffset)); set => WriteHere(nameof(PayloadDecoderTableOffset), value); }

        [Offset(38UL)]
        public ushort PayloadDecoderTableLength { get => ReadHere<ushort>(nameof(PayloadDecoderTableLength)); set => WriteHere(nameof(PayloadDecoderTableLength), value); }

        [Offset(40UL)]
        public ushort EventFilterTableOffset { get => ReadHere<ushort>(nameof(EventFilterTableOffset)); set => WriteHere(nameof(EventFilterTableOffset), value); }

        [Offset(42UL)]
        public ushort EventFilterTableLength { get => ReadHere<ushort>(nameof(EventFilterTableLength)); set => WriteHere(nameof(EventFilterTableLength), value); }

        [Offset(44UL)]
        public ushort UNICODEStringTableOffset { get => ReadHere<ushort>(nameof(UNICODEStringTableOffset)); set => WriteHere(nameof(UNICODEStringTableOffset), value); }

        [Offset(46UL)]
        public ushort UNICODEStringTableLength { get => ReadHere<ushort>(nameof(UNICODEStringTableLength)); set => WriteHere(nameof(UNICODEStringTableLength), value); }

        [Offset(48UL)]
        public ushort ANSIStringTableOffset { get => ReadHere<ushort>(nameof(ANSIStringTableOffset)); set => WriteHere(nameof(ANSIStringTableOffset), value); }

        [Offset(50UL)]
        public ushort ANSIStringTableLength { get => ReadHere<ushort>(nameof(ANSIStringTableLength)); set => WriteHere(nameof(ANSIStringTableLength), value); }

        [Offset(56UL)]
        [Length(1)]
        public DynamicArray PredicateTable { get => ReadStructure<DynamicArray>(nameof(PredicateTable)); set => WriteStructure(nameof(PredicateTable), value); }

        public AggregatedPayloadFilter(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AggregatedPayloadFilter>();
        }
    }
}