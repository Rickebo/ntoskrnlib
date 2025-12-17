using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PPM_SELECTION_MENU")]
    public sealed class _PPM_SELECTION_MENU : DynamicStructure
    {
        public uint Count { get; }
        public IntPtr Entries { get; }

        public _PPM_SELECTION_MENU(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_SELECTION_MENU()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_SELECTION_MENU.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_SELECTION_MENU.Entries),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PPM_SELECTION_MENU>((mem, ptr) => new _PPM_SELECTION_MENU(mem, ptr), offsets);
        }
    }
}