using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TP_CLEANUP_GROUP")]
    public sealed class _TP_CLEANUP_GROUP : DynamicStructure
    {
        public _TP_CLEANUP_GROUP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_CLEANUP_GROUP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_TP_CLEANUP_GROUP>((mem, ptr) => new _TP_CLEANUP_GROUP(mem, ptr), offsets);
        }
    }
}