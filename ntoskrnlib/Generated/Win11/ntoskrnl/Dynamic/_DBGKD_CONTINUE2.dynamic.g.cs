using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_CONTINUE2")]
    public sealed class _DBGKD_CONTINUE2 : DynamicStructure
    {
        public int ContinueStatus { get; }
        public _AMD64_DBGKD_CONTROL_SET ControlSet { get; }
        public _DBGKD_ANY_CONTROL_SET AnyControlSet { get; }

        public _DBGKD_CONTINUE2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_CONTINUE2()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_CONTINUE2.ContinueStatus),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_CONTINUE2.ControlSet),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DBGKD_CONTINUE2.AnyControlSet),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_DBGKD_CONTINUE2>((mem, ptr) => new _DBGKD_CONTINUE2(mem, ptr), offsets);
        }
    }
}