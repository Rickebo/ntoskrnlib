using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EVENT_PAYLOAD_PREDICATE")]
    public sealed class EventPayloadPredicate : DynamicStructure
    {
        [Offset(0UL)]
        public ushort FieldIndex { get => ReadHere<ushort>(nameof(FieldIndex)); set => WriteHere(nameof(FieldIndex), value); }

        [Offset(2UL)]
        public ushort CompareOp { get => ReadHere<ushort>(nameof(CompareOp)); set => WriteHere(nameof(CompareOp), value); }

        [Offset(8UL)]
        [Length(2)]
        public DynamicArray Value { get => ReadStructure<DynamicArray>(nameof(Value)); set => WriteStructure(nameof(Value), value); }

        public EventPayloadPredicate(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EventPayloadPredicate>();
        }
    }
}