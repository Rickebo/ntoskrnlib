using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!RTL_HP_ENV_HANDLE")]
    public sealed class RTL_HP_ENV_HANDLE : DynamicStructure
    {
        public byte[] h { get; }

        public RTL_HP_ENV_HANDLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static RTL_HP_ENV_HANDLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(RTL_HP_ENV_HANDLE.h),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<RTL_HP_ENV_HANDLE>((mem, ptr) => new RTL_HP_ENV_HANDLE(mem, ptr), offsets);
        }
    }
}