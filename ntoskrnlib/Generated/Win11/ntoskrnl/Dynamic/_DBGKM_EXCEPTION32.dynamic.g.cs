using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKM_EXCEPTION32")]
    public sealed class _DBGKM_EXCEPTION32 : DynamicStructure
    {
        public _EXCEPTION_RECORD32 ExceptionRecord { get; }
        public uint FirstChance { get; }

        public _DBGKM_EXCEPTION32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKM_EXCEPTION32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKM_EXCEPTION32.ExceptionRecord),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKM_EXCEPTION32.FirstChance),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_DBGKM_EXCEPTION32>((mem, ptr) => new _DBGKM_EXCEPTION32(mem, ptr), offsets);
        }
    }
}