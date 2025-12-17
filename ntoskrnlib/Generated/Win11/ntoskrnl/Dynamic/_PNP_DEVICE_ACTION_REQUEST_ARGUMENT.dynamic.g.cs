using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PNP_DEVICE_ACTION_REQUEST_ARGUMENT")]
    public sealed class _PNP_DEVICE_ACTION_REQUEST_ARGUMENT : DynamicStructure
    {
        public IntPtr PdcActivatorHandle { get; }
        public _unnamed_tag_ u { get; }

        public _PNP_DEVICE_ACTION_REQUEST_ARGUMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PNP_DEVICE_ACTION_REQUEST_ARGUMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PNP_DEVICE_ACTION_REQUEST_ARGUMENT.PdcActivatorHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PNP_DEVICE_ACTION_REQUEST_ARGUMENT.u),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PNP_DEVICE_ACTION_REQUEST_ARGUMENT>((mem, ptr) => new _PNP_DEVICE_ACTION_REQUEST_ARGUMENT(mem, ptr), offsets);
        }
    }
}