using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_TRANS_PTR")]
    public sealed class _CM_TRANS_PTR : DynamicStructure
    {
        public ulong LightWeight { get; }
        public IntPtr TransPtr { get; }

        public _CM_TRANS_PTR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_TRANS_PTR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_TRANS_PTR.LightWeight),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_TRANS_PTR.TransPtr),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_CM_TRANS_PTR>((mem, ptr) => new _CM_TRANS_PTR(mem, ptr), offsets);
        }
    }
}