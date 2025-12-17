using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_SET_SPECIAL_CALL32")]
    public sealed class _DBGKD_SET_SPECIAL_CALL32 : DynamicStructure
    {
        public uint SpecialCall { get; }

        public _DBGKD_SET_SPECIAL_CALL32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_SET_SPECIAL_CALL32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_SET_SPECIAL_CALL32.SpecialCall),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_DBGKD_SET_SPECIAL_CALL32>((mem, ptr) => new _DBGKD_SET_SPECIAL_CALL32(mem, ptr), offsets);
        }
    }
}