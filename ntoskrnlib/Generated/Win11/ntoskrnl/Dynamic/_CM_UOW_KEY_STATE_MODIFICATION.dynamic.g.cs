using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_UOW_KEY_STATE_MODIFICATION")]
    public sealed class _CM_UOW_KEY_STATE_MODIFICATION : DynamicStructure
    {
        public uint RefCount { get; }
        public uint[] SubKeyListCount { get; }
        public uint[] NewSubKeyList { get; }

        public _CM_UOW_KEY_STATE_MODIFICATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_UOW_KEY_STATE_MODIFICATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_UOW_KEY_STATE_MODIFICATION.RefCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_UOW_KEY_STATE_MODIFICATION.SubKeyListCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CM_UOW_KEY_STATE_MODIFICATION.NewSubKeyList),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_CM_UOW_KEY_STATE_MODIFICATION>((mem, ptr) => new _CM_UOW_KEY_STATE_MODIFICATION(mem, ptr), offsets);
        }
    }
}