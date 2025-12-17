using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_VS_SUBSEGMENT")]
    public sealed class _HEAP_VS_SUBSEGMENT : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public ulong CommitBitmap { get; }
        public ulong CommitLock { get; }
        public ushort Size { get; }
        public ushort OwnerSlotRef { get; }
        public ushort Signature { get; }
        public ushort FullCommit { get; }

        public _HEAP_VS_SUBSEGMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_VS_SUBSEGMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_VS_SUBSEGMENT.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_SUBSEGMENT.CommitBitmap),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_VS_SUBSEGMENT.CommitLock),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_VS_SUBSEGMENT.Size),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_VS_SUBSEGMENT.OwnerSlotRef),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_HEAP_VS_SUBSEGMENT.Signature),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_HEAP_VS_SUBSEGMENT.FullCommit),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_HEAP_VS_SUBSEGMENT>((mem, ptr) => new _HEAP_VS_SUBSEGMENT(mem, ptr), offsets);
        }
    }
}