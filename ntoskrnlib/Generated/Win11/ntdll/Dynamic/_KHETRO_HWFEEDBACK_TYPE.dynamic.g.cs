using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KHETRO_HWFEEDBACK_TYPE")]
    public sealed class _KHETRO_HWFEEDBACK_TYPE : DynamicStructure
    {
        public uint Count { get; }
        public byte[] HwFeedbackClass { get; }

        public _KHETRO_HWFEEDBACK_TYPE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KHETRO_HWFEEDBACK_TYPE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KHETRO_HWFEEDBACK_TYPE.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KHETRO_HWFEEDBACK_TYPE.HwFeedbackClass),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_KHETRO_HWFEEDBACK_TYPE>((mem, ptr) => new _KHETRO_HWFEEDBACK_TYPE(mem, ptr), offsets);
        }
    }
}