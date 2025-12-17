using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HIDDEN_PROCESSOR_POWER_INTERFACE")]
    public sealed class _HIDDEN_PROCESSOR_POWER_INTERFACE : DynamicStructure
    {
        public uint Version { get; }
        public IntPtr ReadPerfMsr { get; }
        public IntPtr WritePerfMsr { get; }
        public IntPtr ReadPerfIoPort { get; }
        public IntPtr WritePerfIoPort { get; }

        public _HIDDEN_PROCESSOR_POWER_INTERFACE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HIDDEN_PROCESSOR_POWER_INTERFACE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HIDDEN_PROCESSOR_POWER_INTERFACE.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HIDDEN_PROCESSOR_POWER_INTERFACE.ReadPerfMsr),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HIDDEN_PROCESSOR_POWER_INTERFACE.WritePerfMsr),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HIDDEN_PROCESSOR_POWER_INTERFACE.ReadPerfIoPort),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HIDDEN_PROCESSOR_POWER_INTERFACE.WritePerfIoPort),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_HIDDEN_PROCESSOR_POWER_INTERFACE>((mem, ptr) => new _HIDDEN_PROCESSOR_POWER_INTERFACE(mem, ptr), offsets);
        }
    }
}