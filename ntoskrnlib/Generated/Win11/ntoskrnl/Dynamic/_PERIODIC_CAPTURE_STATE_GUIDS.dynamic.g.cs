using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PERIODIC_CAPTURE_STATE_GUIDS")]
    public sealed class _PERIODIC_CAPTURE_STATE_GUIDS : DynamicStructure
    {
        public ushort ProviderCount { get; }
        public IntPtr Providers { get; }

        public _PERIODIC_CAPTURE_STATE_GUIDS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PERIODIC_CAPTURE_STATE_GUIDS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PERIODIC_CAPTURE_STATE_GUIDS.ProviderCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PERIODIC_CAPTURE_STATE_GUIDS.Providers),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PERIODIC_CAPTURE_STATE_GUIDS>((mem, ptr) => new _PERIODIC_CAPTURE_STATE_GUIDS(mem, ptr), offsets);
        }
    }
}