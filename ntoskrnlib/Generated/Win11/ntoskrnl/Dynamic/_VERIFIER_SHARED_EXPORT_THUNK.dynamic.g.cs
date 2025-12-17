using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VERIFIER_SHARED_EXPORT_THUNK")]
    public sealed class _VERIFIER_SHARED_EXPORT_THUNK : DynamicStructure
    {
        public _VERIFIER_SHARED_EXPORT_THUNK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VERIFIER_SHARED_EXPORT_THUNK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
            };
            Register<_VERIFIER_SHARED_EXPORT_THUNK>((mem, ptr) => new _VERIFIER_SHARED_EXPORT_THUNK(mem, ptr), offsets);
        }
    }
}