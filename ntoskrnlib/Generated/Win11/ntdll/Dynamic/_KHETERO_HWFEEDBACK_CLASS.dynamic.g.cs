using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KHETERO_HWFEEDBACK_CLASS")]
    public sealed class _KHETERO_HWFEEDBACK_CLASS : DynamicStructure
    {
        public byte PerformanceClass { get; }
        public byte EfficiencyClass { get; }
        public byte PerformanceClassRawValue { get; }
        public byte EfficiencyClassRawValue { get; }

        public _KHETERO_HWFEEDBACK_CLASS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KHETERO_HWFEEDBACK_CLASS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KHETERO_HWFEEDBACK_CLASS.PerformanceClass),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KHETERO_HWFEEDBACK_CLASS.EfficiencyClass),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_KHETERO_HWFEEDBACK_CLASS.PerformanceClassRawValue),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_KHETERO_HWFEEDBACK_CLASS.EfficiencyClassRawValue),
                    new ulong[]
                    {
                        3UL
                    }
                }
            };
            Register<_KHETERO_HWFEEDBACK_CLASS>((mem, ptr) => new _KHETERO_HWFEEDBACK_CLASS(mem, ptr), offsets);
        }
    }
}