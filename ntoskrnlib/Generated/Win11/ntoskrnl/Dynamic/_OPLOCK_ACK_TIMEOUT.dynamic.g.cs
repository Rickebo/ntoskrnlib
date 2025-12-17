using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OPLOCK_ACK_TIMEOUT")]
    public sealed class _OPLOCK_ACK_TIMEOUT : DynamicStructure
    {
        public _KTIMER Timer { get; }
        public _KDPC Dpc { get; }
        public _WORK_QUEUE_ITEM WorkItem { get; }
        public IntPtr Oplock { get; }
        public IntPtr OplockRequestFileObject { get; }
        public uint OplockOwnerIntegrityLevel { get; }
        public byte TimerSet { get; }
        public byte AckDone { get; }

        public _OPLOCK_ACK_TIMEOUT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OPLOCK_ACK_TIMEOUT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OPLOCK_ACK_TIMEOUT.Timer),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OPLOCK_ACK_TIMEOUT.Dpc),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_OPLOCK_ACK_TIMEOUT.WorkItem),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_OPLOCK_ACK_TIMEOUT.Oplock),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_OPLOCK_ACK_TIMEOUT.OplockRequestFileObject),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_OPLOCK_ACK_TIMEOUT.OplockOwnerIntegrityLevel),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_OPLOCK_ACK_TIMEOUT.TimerSet),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_OPLOCK_ACK_TIMEOUT.AckDone),
                    new ulong[]
                    {
                        181UL
                    }
                }
            };
            Register<_OPLOCK_ACK_TIMEOUT>((mem, ptr) => new _OPLOCK_ACK_TIMEOUT(mem, ptr), offsets);
        }
    }
}