using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_XSTATE_SAVE")]
    public sealed class _XSTATE_SAVE : DynamicStructure
    {
        public IntPtr Prev { get; }
        public IntPtr Thread { get; }
        public byte Level { get; }
        public _XSTATE_CONTEXT XStateContext { get; }

        public _XSTATE_SAVE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _XSTATE_SAVE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_XSTATE_SAVE.Prev),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XSTATE_SAVE.Thread),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_XSTATE_SAVE.Level),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_XSTATE_SAVE.XStateContext),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_XSTATE_SAVE>((mem, ptr) => new _XSTATE_SAVE(mem, ptr), offsets);
        }
    }
}