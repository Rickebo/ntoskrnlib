using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SEP_LOWBOX_NUMBER_MAPPING")]
    public sealed class _SEP_LOWBOX_NUMBER_MAPPING : DynamicStructure
    {
        public _EX_PUSH_LOCK Lock { get; }
        public _RTL_BITMAP Bitmap { get; }
        public IntPtr HashTable { get; }
        public byte Active { get; }

        public _SEP_LOWBOX_NUMBER_MAPPING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEP_LOWBOX_NUMBER_MAPPING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEP_LOWBOX_NUMBER_MAPPING.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEP_LOWBOX_NUMBER_MAPPING.Bitmap),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SEP_LOWBOX_NUMBER_MAPPING.HashTable),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SEP_LOWBOX_NUMBER_MAPPING.Active),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_SEP_LOWBOX_NUMBER_MAPPING>((mem, ptr) => new _SEP_LOWBOX_NUMBER_MAPPING(mem, ptr), offsets);
        }
    }
}