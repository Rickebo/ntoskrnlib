using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!wil_details_RecordUsageResult")]
    public sealed class wil_details_RecordUsageResult : DynamicStructure
    {
        public int queueBackground { get; }
        public uint countImmediate { get; }
        public uint kindImmediate { get; }
        public uint payloadId { get; }
        public int ignoredUse { get; }
        public int isWexpConfiguration { get; }

        public wil_details_RecordUsageResult(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static wil_details_RecordUsageResult()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(wil_details_RecordUsageResult.queueBackground),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(wil_details_RecordUsageResult.countImmediate),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(wil_details_RecordUsageResult.kindImmediate),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(wil_details_RecordUsageResult.payloadId),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(wil_details_RecordUsageResult.ignoredUse),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(wil_details_RecordUsageResult.isWexpConfiguration),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<wil_details_RecordUsageResult>((mem, ptr) => new wil_details_RecordUsageResult(mem, ptr), offsets);
        }
    }
}