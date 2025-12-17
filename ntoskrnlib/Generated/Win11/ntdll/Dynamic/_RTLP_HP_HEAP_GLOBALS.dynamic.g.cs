using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTLP_HP_HEAP_GLOBALS")]
    public sealed class _RTLP_HP_HEAP_GLOBALS : DynamicStructure
    {
        public ulong HeapKey { get; }
        public ulong LfhKey { get; }
        public IntPtr FailureInfo { get; }
        public _RTLP_HEAP_COMMIT_LIMIT_DATA CommitLimitData { get; }
        public uint Flags { get; }
        public uint CpuFeaturesChecked { get; }
        public uint ErmsSupported { get; }
        public uint BMI2Supported { get; }
        public ulong RandomSeed { get; }

        public _RTLP_HP_HEAP_GLOBALS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTLP_HP_HEAP_GLOBALS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTLP_HP_HEAP_GLOBALS.HeapKey),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTLP_HP_HEAP_GLOBALS.LfhKey),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTLP_HP_HEAP_GLOBALS.FailureInfo),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTLP_HP_HEAP_GLOBALS.CommitLimitData),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTLP_HP_HEAP_GLOBALS.Flags),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTLP_HP_HEAP_GLOBALS.CpuFeaturesChecked),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTLP_HP_HEAP_GLOBALS.ErmsSupported),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTLP_HP_HEAP_GLOBALS.BMI2Supported),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTLP_HP_HEAP_GLOBALS.RandomSeed),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_RTLP_HP_HEAP_GLOBALS>((mem, ptr) => new _RTLP_HP_HEAP_GLOBALS(mem, ptr), offsets);
        }
    }
}