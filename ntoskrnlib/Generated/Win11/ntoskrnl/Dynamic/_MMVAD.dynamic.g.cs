using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMVAD")]
    public sealed class _MMVAD : DynamicStructure
    {
        public _MMVAD_SHORT Core { get; }
        public _MMVAD_FLAGS2 VadFlags2 { get; }
        public IntPtr Subsection { get; }
        public IntPtr FirstPrototypePte { get; }
        public IntPtr LastContiguousPte { get; }
        public _LIST_ENTRY ViewLinks { get; }
        public IntPtr VadsProcess { get; }
        public _unnamed_tag_ u4 { get; }
        public IntPtr FileObject { get; }

        public _MMVAD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMVAD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMVAD.Core),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMVAD.VadFlags2),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MMVAD.Subsection),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_MMVAD.FirstPrototypePte),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MMVAD.LastContiguousPte),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_MMVAD.ViewLinks),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_MMVAD.VadsProcess),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_MMVAD.u4),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_MMVAD.FileObject),
                    new ulong[]
                    {
                        128UL
                    }
                }
            };
            Register<_MMVAD>((mem, ptr) => new _MMVAD(mem, ptr), offsets);
        }
    }
}