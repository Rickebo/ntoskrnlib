using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PPM_COORDINATED_SELECTION")]
    public sealed class _PPM_COORDINATED_SELECTION : DynamicStructure
    {
        public uint MaximumStates { get; }
        public uint SelectedStates { get; }
        public uint DefaultSelection { get; }
        public IntPtr Selection { get; }

        public _PPM_COORDINATED_SELECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_COORDINATED_SELECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_COORDINATED_SELECTION.MaximumStates),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_COORDINATED_SELECTION.SelectedStates),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PPM_COORDINATED_SELECTION.DefaultSelection),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_COORDINATED_SELECTION.Selection),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_PPM_COORDINATED_SELECTION>((mem, ptr) => new _PPM_COORDINATED_SELECTION(mem, ptr), offsets);
        }
    }
}