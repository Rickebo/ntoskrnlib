using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_KEY_REFERENCE")]
    public sealed class _CM_KEY_REFERENCE : DynamicStructure
    {
        public uint KeyCell { get; }
        public IntPtr KeyHive { get; }

        public _CM_KEY_REFERENCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_KEY_REFERENCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_KEY_REFERENCE.KeyCell),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_KEY_REFERENCE.KeyHive),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CM_KEY_REFERENCE>((mem, ptr) => new _CM_KEY_REFERENCE(mem, ptr), offsets);
        }
    }
}