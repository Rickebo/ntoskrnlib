using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OB_EXTENDED_USER_INFO")]
    public sealed class _OB_EXTENDED_USER_INFO : DynamicStructure
    {
        public IntPtr Context1 { get; }
        public IntPtr Context2 { get; }

        public _OB_EXTENDED_USER_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OB_EXTENDED_USER_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OB_EXTENDED_USER_INFO.Context1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OB_EXTENDED_USER_INFO.Context2),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_OB_EXTENDED_USER_INFO>((mem, ptr) => new _OB_EXTENDED_USER_INFO(mem, ptr), offsets);
        }
    }
}