using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_BOOT_ENTROPY_LDR_RESULT")]
    public sealed class _BOOT_ENTROPY_LDR_RESULT : DynamicStructure
    {
        public uint maxEntropySources { get; }
        public byte[] EntropySourceResult { get; }
        public byte[] SeedBytesForCng { get; }
        public byte[] RngBytesForNtoskrnl { get; }
        public byte[] KdEntropy { get; }

        public _BOOT_ENTROPY_LDR_RESULT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _BOOT_ENTROPY_LDR_RESULT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_BOOT_ENTROPY_LDR_RESULT.maxEntropySources),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_BOOT_ENTROPY_LDR_RESULT.EntropySourceResult),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_BOOT_ENTROPY_LDR_RESULT.SeedBytesForCng),
                    new ulong[]
                    {
                        1048UL
                    }
                },
                {
                    nameof(_BOOT_ENTROPY_LDR_RESULT.RngBytesForNtoskrnl),
                    new ulong[]
                    {
                        1096UL
                    }
                },
                {
                    nameof(_BOOT_ENTROPY_LDR_RESULT.KdEntropy),
                    new ulong[]
                    {
                        2120UL
                    }
                }
            };
            Register<_BOOT_ENTROPY_LDR_RESULT>((mem, ptr) => new _BOOT_ENTROPY_LDR_RESULT(mem, ptr), offsets);
        }
    }
}