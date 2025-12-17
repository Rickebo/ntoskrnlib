using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_DEVICE_DIRECTED_TRANSITION_STATE")]
    public sealed class _POP_FX_DEVICE_DIRECTED_TRANSITION_STATE : DynamicStructure
    {
        public IntPtr CompletionContext { get; }
        public int CompletionStatus { get; }
        public uint DIrpPending { get; }
        public uint DIrpCompleted { get; }

        public _POP_FX_DEVICE_DIRECTED_TRANSITION_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_DEVICE_DIRECTED_TRANSITION_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_DEVICE_DIRECTED_TRANSITION_STATE.CompletionContext),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_DIRECTED_TRANSITION_STATE.CompletionStatus),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_DIRECTED_TRANSITION_STATE.DIrpPending),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_POP_FX_DEVICE_DIRECTED_TRANSITION_STATE.DIrpCompleted),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_POP_FX_DEVICE_DIRECTED_TRANSITION_STATE>((mem, ptr) => new _POP_FX_DEVICE_DIRECTED_TRANSITION_STATE(mem, ptr), offsets);
        }
    }
}