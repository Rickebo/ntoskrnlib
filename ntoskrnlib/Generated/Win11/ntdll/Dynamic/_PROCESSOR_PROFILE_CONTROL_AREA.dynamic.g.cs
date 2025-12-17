using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PROCESSOR_PROFILE_CONTROL_AREA")]
    public sealed class _PROCESSOR_PROFILE_CONTROL_AREA : DynamicStructure
    {
        public _PEBS_DS_SAVE_AREA PebsDsSaveArea { get; }
        public IntPtr RawBuffer { get; }

        public _PROCESSOR_PROFILE_CONTROL_AREA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESSOR_PROFILE_CONTROL_AREA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESSOR_PROFILE_CONTROL_AREA.PebsDsSaveArea),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESSOR_PROFILE_CONTROL_AREA.RawBuffer),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PROCESSOR_PROFILE_CONTROL_AREA>((mem, ptr) => new _PROCESSOR_PROFILE_CONTROL_AREA(mem, ptr), offsets);
        }
    }
}