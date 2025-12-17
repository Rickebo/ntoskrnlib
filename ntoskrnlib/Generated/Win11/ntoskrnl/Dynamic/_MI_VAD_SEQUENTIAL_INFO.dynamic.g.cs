using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_VAD_SEQUENTIAL_INFO")]
    public sealed class _MI_VAD_SEQUENTIAL_INFO : DynamicStructure
    {
        public ulong Length { get; }
        public ulong Vpn { get; }
        public ulong MustBeZero { get; }
        public ulong EntireField { get; }

        public _MI_VAD_SEQUENTIAL_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_VAD_SEQUENTIAL_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_VAD_SEQUENTIAL_INFO.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_VAD_SEQUENTIAL_INFO.Vpn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_VAD_SEQUENTIAL_INFO.MustBeZero),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_VAD_SEQUENTIAL_INFO.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_VAD_SEQUENTIAL_INFO>((mem, ptr) => new _MI_VAD_SEQUENTIAL_INFO(mem, ptr), offsets);
        }
    }
}