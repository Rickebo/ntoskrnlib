using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_LBR_SUPPORT")]
    public sealed class _ETW_LBR_SUPPORT : DynamicStructure
    {
        public uint LbrHandle { get; }
        public uint LbrOptions { get; }
        public uint HookIdCount { get; }
        public ushort[] HookId { get; }

        public _ETW_LBR_SUPPORT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_LBR_SUPPORT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_LBR_SUPPORT.LbrHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_LBR_SUPPORT.LbrOptions),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ETW_LBR_SUPPORT.HookIdCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETW_LBR_SUPPORT.HookId),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_ETW_LBR_SUPPORT>((mem, ptr) => new _ETW_LBR_SUPPORT(mem, ptr), offsets);
        }
    }
}