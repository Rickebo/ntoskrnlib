using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK")]
    public sealed class _KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK : DynamicStructure
    {
        public _KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK>((mem, ptr) => new _KI_IDEAL_PROCESSOR_ASSIGNMENT_BLOCK(mem, ptr), offsets);
        }
    }
}