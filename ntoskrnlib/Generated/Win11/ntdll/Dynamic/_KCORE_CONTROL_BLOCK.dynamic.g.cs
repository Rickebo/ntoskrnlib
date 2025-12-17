using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KCORE_CONTROL_BLOCK")]
    public sealed class _KCORE_CONTROL_BLOCK : DynamicStructure
    {
        public byte ProcessorCount { get; }
        public byte ScanStartIndex { get; }
        public byte[] Spare { get; }
        public byte[] Prcbs { get; }
        public IntPtr CoreControlBlockShadow { get; }

        public _KCORE_CONTROL_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KCORE_CONTROL_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KCORE_CONTROL_BLOCK.ProcessorCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KCORE_CONTROL_BLOCK.ScanStartIndex),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_KCORE_CONTROL_BLOCK.Spare),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_KCORE_CONTROL_BLOCK.Prcbs),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KCORE_CONTROL_BLOCK.CoreControlBlockShadow),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_KCORE_CONTROL_BLOCK>((mem, ptr) => new _KCORE_CONTROL_BLOCK(mem, ptr), offsets);
        }
    }
}