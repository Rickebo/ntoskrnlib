using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_HARD_FAULT_STATE")]
    public sealed class _MI_HARD_FAULT_STATE : DynamicStructure
    {
        public IntPtr SwapPfn { get; }
        public _MI_STORE_INPAGE_COMPLETE_FLAGS StoreFlags { get; }

        public _MI_HARD_FAULT_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_HARD_FAULT_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_HARD_FAULT_STATE.SwapPfn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_HARD_FAULT_STATE.StoreFlags),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_MI_HARD_FAULT_STATE>((mem, ptr) => new _MI_HARD_FAULT_STATE(mem, ptr), offsets);
        }
    }
}