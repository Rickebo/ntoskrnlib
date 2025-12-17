using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_BOOT_ENTROPY_SOURCE_LDR_RESULT")]
    public sealed class _BOOT_ENTROPY_SOURCE_LDR_RESULT : DynamicStructure
    {
        public uint SourceId { get; }
        public ulong Policy { get; }
        public uint ResultCode { get; }
        public int ResultStatus { get; }
        public ulong Time { get; }
        public uint EntropyLength { get; }
        public byte[] EntropyData { get; }

        public _BOOT_ENTROPY_SOURCE_LDR_RESULT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _BOOT_ENTROPY_SOURCE_LDR_RESULT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_BOOT_ENTROPY_SOURCE_LDR_RESULT.SourceId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_BOOT_ENTROPY_SOURCE_LDR_RESULT.Policy),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_BOOT_ENTROPY_SOURCE_LDR_RESULT.ResultCode),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_BOOT_ENTROPY_SOURCE_LDR_RESULT.ResultStatus),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_BOOT_ENTROPY_SOURCE_LDR_RESULT.Time),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_BOOT_ENTROPY_SOURCE_LDR_RESULT.EntropyLength),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_BOOT_ENTROPY_SOURCE_LDR_RESULT.EntropyData),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_BOOT_ENTROPY_SOURCE_LDR_RESULT>((mem, ptr) => new _BOOT_ENTROPY_SOURCE_LDR_RESULT(mem, ptr), offsets);
        }
    }
}