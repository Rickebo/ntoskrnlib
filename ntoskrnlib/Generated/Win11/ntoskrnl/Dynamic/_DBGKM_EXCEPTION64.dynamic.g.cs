using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKM_EXCEPTION64")]
    public sealed class _DBGKM_EXCEPTION64 : DynamicStructure
    {
        public _EXCEPTION_RECORD64 ExceptionRecord { get; }
        public uint FirstChance { get; }

        public _DBGKM_EXCEPTION64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKM_EXCEPTION64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKM_EXCEPTION64.ExceptionRecord),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKM_EXCEPTION64.FirstChance),
                    new ulong[]
                    {
                        152UL
                    }
                }
            };
            Register<_DBGKM_EXCEPTION64>((mem, ptr) => new _DBGKM_EXCEPTION64(mem, ptr), offsets);
        }
    }
}