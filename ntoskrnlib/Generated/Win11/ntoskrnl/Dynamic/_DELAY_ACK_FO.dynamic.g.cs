using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DELAY_ACK_FO")]
    public sealed class _DELAY_ACK_FO : DynamicStructure
    {
        public _LIST_ENTRY Links { get; }
        public IntPtr OriginalFileObject { get; }
        public _OPLOCK_TELEMETRY TelemetryData { get; }
        public IntPtr AckTimeout { get; }

        public _DELAY_ACK_FO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DELAY_ACK_FO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DELAY_ACK_FO.Links),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DELAY_ACK_FO.OriginalFileObject),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DELAY_ACK_FO.TelemetryData),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DELAY_ACK_FO.AckTimeout),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_DELAY_ACK_FO>((mem, ptr) => new _DELAY_ACK_FO(mem, ptr), offsets);
        }
    }
}