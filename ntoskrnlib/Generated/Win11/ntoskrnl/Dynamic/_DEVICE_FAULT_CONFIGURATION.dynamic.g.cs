using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_FAULT_CONFIGURATION")]
    public sealed class _DEVICE_FAULT_CONFIGURATION : DynamicStructure
    {
        public IntPtr FaultHandler { get; }
        public IntPtr FaultContext { get; }

        public _DEVICE_FAULT_CONFIGURATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_FAULT_CONFIGURATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_FAULT_CONFIGURATION.FaultHandler),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_FAULT_CONFIGURATION.FaultContext),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_DEVICE_FAULT_CONFIGURATION>((mem, ptr) => new _DEVICE_FAULT_CONFIGURATION(mem, ptr), offsets);
        }
    }
}