using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_CRASHDUMP_INFORMATION")]
    public sealed class _PEP_CRASHDUMP_INFORMATION : DynamicStructure
    {
        public IntPtr DeviceHandle { get; }
        public IntPtr DeviceContext { get; }

        public _PEP_CRASHDUMP_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_CRASHDUMP_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_CRASHDUMP_INFORMATION.DeviceHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_CRASHDUMP_INFORMATION.DeviceContext),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PEP_CRASHDUMP_INFORMATION>((mem, ptr) => new _PEP_CRASHDUMP_INFORMATION(mem, ptr), offsets);
        }
    }
}