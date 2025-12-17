using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSOFTWARE_INTERRUPT_BATCH")]
    public sealed class _KSOFTWARE_INTERRUPT_BATCH : DynamicStructure
    {
        public byte Level { get; }
        public byte TargetType { get; }
        public byte ReservedBatchInProgress { get; }
        public byte Spare { get; }
        public uint SingleTargetIndex { get; }
        public _KAFFINITY_EX MultipleTargetAffinity { get; }
        public ulong[] Padding { get; }

        public _KSOFTWARE_INTERRUPT_BATCH(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSOFTWARE_INTERRUPT_BATCH()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSOFTWARE_INTERRUPT_BATCH.Level),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSOFTWARE_INTERRUPT_BATCH.TargetType),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_KSOFTWARE_INTERRUPT_BATCH.ReservedBatchInProgress),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_KSOFTWARE_INTERRUPT_BATCH.Spare),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_KSOFTWARE_INTERRUPT_BATCH.SingleTargetIndex),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KSOFTWARE_INTERRUPT_BATCH.MultipleTargetAffinity),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KSOFTWARE_INTERRUPT_BATCH.Padding),
                    new ulong[]
                    {
                        272UL
                    }
                }
            };
            Register<_KSOFTWARE_INTERRUPT_BATCH>((mem, ptr) => new _KSOFTWARE_INTERRUPT_BATCH(mem, ptr), offsets);
        }
    }
}