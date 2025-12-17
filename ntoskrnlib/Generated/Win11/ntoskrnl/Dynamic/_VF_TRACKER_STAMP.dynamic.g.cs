using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VF_TRACKER_STAMP")]
    public sealed class _VF_TRACKER_STAMP : DynamicStructure
    {
        public IntPtr Thread { get; }
        public byte Flags { get; }
        public byte OldIrql { get; }
        public byte NewIrql { get; }
        public byte Processor { get; }

        public _VF_TRACKER_STAMP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VF_TRACKER_STAMP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VF_TRACKER_STAMP.Thread),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VF_TRACKER_STAMP.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VF_TRACKER_STAMP.OldIrql),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_VF_TRACKER_STAMP.NewIrql),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_VF_TRACKER_STAMP.Processor),
                    new ulong[]
                    {
                        11UL
                    }
                }
            };
            Register<_VF_TRACKER_STAMP>((mem, ptr) => new _VF_TRACKER_STAMP(mem, ptr), offsets);
        }
    }
}