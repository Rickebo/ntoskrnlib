using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PPM_SELECTION_MENU_ENTRY")]
    public sealed class _PPM_SELECTION_MENU_ENTRY : DynamicStructure
    {
        public byte StrictDependency { get; }
        public byte InitiatingState { get; }
        public byte DependentState { get; }
        public uint StateIndex { get; }
        public uint Dependencies { get; }
        public IntPtr DependencyList { get; }

        public _PPM_SELECTION_MENU_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_SELECTION_MENU_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_SELECTION_MENU_ENTRY.StrictDependency),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_MENU_ENTRY.InitiatingState),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_MENU_ENTRY.DependentState),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_MENU_ENTRY.StateIndex),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_MENU_ENTRY.Dependencies),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_MENU_ENTRY.DependencyList),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_PPM_SELECTION_MENU_ENTRY>((mem, ptr) => new _PPM_SELECTION_MENU_ENTRY(mem, ptr), offsets);
        }
    }
}