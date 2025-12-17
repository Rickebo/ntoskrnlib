using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EVENT_PAYLOAD_PREDICATE")]
    public sealed class _EVENT_PAYLOAD_PREDICATE : DynamicStructure
    {
        public ushort FieldIndex { get; }
        public ushort CompareOp { get; }
        public ulong[] Value { get; }

        public _EVENT_PAYLOAD_PREDICATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EVENT_PAYLOAD_PREDICATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EVENT_PAYLOAD_PREDICATE.FieldIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EVENT_PAYLOAD_PREDICATE.CompareOp),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_EVENT_PAYLOAD_PREDICATE.Value),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_EVENT_PAYLOAD_PREDICATE>((mem, ptr) => new _EVENT_PAYLOAD_PREDICATE(mem, ptr), offsets);
        }
    }
}