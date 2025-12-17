using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_ADAPTER_OBJECT")]
    public sealed class _HALP_DMA_ADAPTER_OBJECT : DynamicStructure
    {
        public _DMA_ADAPTER DmaHeader { get; }
        public uint Signature { get; }
        public IntPtr ContiguousMapRegisters { get; }
        public IntPtr ScatterBufferListHead { get; }
        public uint NumberOfFreeScatterBuffers { get; }
        public IntPtr ContiguousTranslations { get; }
        public IntPtr ScatterTranslations { get; }
        public _HALP_DMA_TRANSLATION_BUFFER_POSITION ContiguousTranslationEnd { get; }
        public _HALP_DMA_TRANSLATION_BUFFER_POSITION ScatterTranslationEnd { get; }
        public _unnamed_tag_ CrashDump { get; }
        public ulong SpinLock { get; }
        public ulong GrowLock { get; }
        public _LARGE_INTEGER MaximumPhysicalAddress { get; }
        public byte IsMasterAdapter { get; }
        public byte DmaCanCross64K { get; }
        public uint LibraryVersion { get; }

        public _HALP_DMA_ADAPTER_OBJECT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HALP_DMA_ADAPTER_OBJECT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.DmaHeader),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.Signature),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.ContiguousMapRegisters),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.ScatterBufferListHead),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.NumberOfFreeScatterBuffers),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.ContiguousTranslations),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.ScatterTranslations),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.ContiguousTranslationEnd),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.ScatterTranslationEnd),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.CrashDump),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.SpinLock),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.GrowLock),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.MaximumPhysicalAddress),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.IsMasterAdapter),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.DmaCanCross64K),
                    new ulong[]
                    {
                        153UL
                    }
                },
                {
                    nameof(_HALP_DMA_ADAPTER_OBJECT.LibraryVersion),
                    new ulong[]
                    {
                        156UL
                    }
                }
            };
            Register<_HALP_DMA_ADAPTER_OBJECT>((mem, ptr) => new _HALP_DMA_ADAPTER_OBJECT(mem, ptr), offsets);
        }
    }
}