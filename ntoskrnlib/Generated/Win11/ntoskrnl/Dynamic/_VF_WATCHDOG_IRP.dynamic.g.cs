using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VF_WATCHDOG_IRP")]
    public sealed class _VF_WATCHDOG_IRP : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public IntPtr Irp { get; }
        public uint DueTickCount { get; }
        public byte Inserted { get; }
        public sbyte TrackedStackLocation { get; }
        public ushort CancelTimeoutTicks { get; }

        public _VF_WATCHDOG_IRP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VF_WATCHDOG_IRP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VF_WATCHDOG_IRP.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VF_WATCHDOG_IRP.Irp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VF_WATCHDOG_IRP.DueTickCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_VF_WATCHDOG_IRP.Inserted),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_VF_WATCHDOG_IRP.TrackedStackLocation),
                    new ulong[]
                    {
                        29UL
                    }
                },
                {
                    nameof(_VF_WATCHDOG_IRP.CancelTimeoutTicks),
                    new ulong[]
                    {
                        30UL
                    }
                }
            };
            Register<_VF_WATCHDOG_IRP>((mem, ptr) => new _VF_WATCHDOG_IRP(mem, ptr), offsets);
        }
    }
}