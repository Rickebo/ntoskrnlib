using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_KCB_LAYER_INFO")]
    public sealed class _CM_KCB_LAYER_INFO : DynamicStructure
    {
        public _LIST_ENTRY LayerListEntry { get; }
        public IntPtr Kcb { get; }
        public IntPtr LowerLayer { get; }
        public _LIST_ENTRY UpperLayerListHead { get; }
        public _LIST_ENTRY DiscardedUpperLayerListHead { get; }

        public _CM_KCB_LAYER_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_KCB_LAYER_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_KCB_LAYER_INFO.LayerListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_KCB_LAYER_INFO.Kcb),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CM_KCB_LAYER_INFO.LowerLayer),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CM_KCB_LAYER_INFO.UpperLayerListHead),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CM_KCB_LAYER_INFO.DiscardedUpperLayerListHead),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_CM_KCB_LAYER_INFO>((mem, ptr) => new _CM_KCB_LAYER_INFO(mem, ptr), offsets);
        }
    }
}