using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTRANSACTION_HISTORY")]
    public sealed class _KTRANSACTION_HISTORY : DynamicStructure
    {
        public uint RecordType { get; }
        public uint Payload { get; }

        public _KTRANSACTION_HISTORY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTRANSACTION_HISTORY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTRANSACTION_HISTORY.RecordType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTRANSACTION_HISTORY.Payload),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_KTRANSACTION_HISTORY>((mem, ptr) => new _KTRANSACTION_HISTORY(mem, ptr), offsets);
        }
    }
}