using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SUBSECTION")]
    public sealed class _SUBSECTION : DynamicStructure
    {
        public IntPtr ControlArea { get; }
        public IntPtr SubsectionBase { get; }
        public IntPtr NextSubsection { get; }
        public _RTL_AVL_TREE GlobalPerSessionHead { get; }
        public IntPtr CreationWaitList { get; }
        public _MMSUBSECTION_FLAGS SubsectionFlags { get; }
        public uint StartingSector { get; }
        public uint NumberOfFullSectors { get; }
        public uint PtesInSubsection { get; }
        public _unnamed_tag_ u1 { get; }
        public uint UnusedPtes { get; }
        public uint ExtentQueryNeeded { get; }
        public uint Spare { get; }

        public _SUBSECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SUBSECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SUBSECTION.ControlArea),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SUBSECTION.SubsectionBase),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SUBSECTION.NextSubsection),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SUBSECTION.GlobalPerSessionHead),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SUBSECTION.CreationWaitList),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SUBSECTION.SubsectionFlags),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SUBSECTION.StartingSector),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_SUBSECTION.NumberOfFullSectors),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_SUBSECTION.PtesInSubsection),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_SUBSECTION.u1),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_SUBSECTION.UnusedPtes),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_SUBSECTION.ExtentQueryNeeded),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_SUBSECTION.Spare),
                    new ulong[]
                    {
                        52UL
                    }
                }
            };
            Register<_SUBSECTION>((mem, ptr) => new _SUBSECTION(mem, ptr), offsets);
        }
    }
}