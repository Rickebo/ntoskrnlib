using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_HP_VS_CONFIG")]
    public sealed class _RTL_HP_VS_CONFIG : DynamicStructure
    {
        public _unnamed_tag_ Flags { get; }

        public _RTL_HP_VS_CONFIG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_HP_VS_CONFIG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_HP_VS_CONFIG.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_RTL_HP_VS_CONFIG>((mem, ptr) => new _RTL_HP_VS_CONFIG(mem, ptr), offsets);
        }
    }
}