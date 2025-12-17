using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CLS_LSN")]
    public sealed class _CLS_LSN : DynamicStructure
    {
        public _unnamed_tag_ offset { get; }
        public ulong ullOffset { get; }

        public _CLS_LSN(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CLS_LSN()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CLS_LSN.offset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CLS_LSN.ullOffset),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_CLS_LSN>((mem, ptr) => new _CLS_LSN(mem, ptr), offsets);
        }
    }
}