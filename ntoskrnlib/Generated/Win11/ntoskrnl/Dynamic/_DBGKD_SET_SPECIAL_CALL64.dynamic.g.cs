using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_SET_SPECIAL_CALL64")]
    public sealed class _DBGKD_SET_SPECIAL_CALL64 : DynamicStructure
    {
        public ulong SpecialCall { get; }

        public _DBGKD_SET_SPECIAL_CALL64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_SET_SPECIAL_CALL64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_SET_SPECIAL_CALL64.SpecialCall),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_DBGKD_SET_SPECIAL_CALL64>((mem, ptr) => new _DBGKD_SET_SPECIAL_CALL64(mem, ptr), offsets);
        }
    }
}