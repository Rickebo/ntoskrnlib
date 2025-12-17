using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KSECURE_FAULT_INFORMATION")]
    public sealed class _KSECURE_FAULT_INFORMATION : DynamicStructure
    {
        public ulong FaultCode { get; }
        public ulong FaultVa { get; }
        public ulong FaultPa { get; }

        public _KSECURE_FAULT_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSECURE_FAULT_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSECURE_FAULT_INFORMATION.FaultCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSECURE_FAULT_INFORMATION.FaultVa),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KSECURE_FAULT_INFORMATION.FaultPa),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_KSECURE_FAULT_INFORMATION>((mem, ptr) => new _KSECURE_FAULT_INFORMATION(mem, ptr), offsets);
        }
    }
}