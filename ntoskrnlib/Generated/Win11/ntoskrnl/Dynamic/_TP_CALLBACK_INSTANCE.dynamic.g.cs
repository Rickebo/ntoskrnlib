using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TP_CALLBACK_INSTANCE")]
    public sealed class _TP_CALLBACK_INSTANCE : DynamicStructure
    {
        public _TP_CALLBACK_INSTANCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_CALLBACK_INSTANCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_TP_CALLBACK_INSTANCE>((mem, ptr) => new _TP_CALLBACK_INSTANCE(mem, ptr), offsets);
        }
    }
}