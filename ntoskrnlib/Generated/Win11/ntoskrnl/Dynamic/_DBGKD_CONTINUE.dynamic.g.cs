using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_CONTINUE")]
    public sealed class _DBGKD_CONTINUE : DynamicStructure
    {
        public int ContinueStatus { get; }

        public _DBGKD_CONTINUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_CONTINUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_CONTINUE.ContinueStatus),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_DBGKD_CONTINUE>((mem, ptr) => new _DBGKD_CONTINUE(mem, ptr), offsets);
        }
    }
}