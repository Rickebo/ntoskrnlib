using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KIST_BASE_FRAME")]
    public sealed class _KIST_BASE_FRAME : DynamicStructure
    {
        public IntPtr KernelGsBase { get; }
        public IntPtr IstStack { get; }
        public ulong PreviousGsBase { get; }
        public ulong PreviousCr3 { get; }
        public ulong IstPad { get; }
        public ulong Reserved { get; }

        public _KIST_BASE_FRAME(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KIST_BASE_FRAME()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KIST_BASE_FRAME.KernelGsBase),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KIST_BASE_FRAME.IstStack),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KIST_BASE_FRAME.PreviousGsBase),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KIST_BASE_FRAME.PreviousCr3),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KIST_BASE_FRAME.IstPad),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KIST_BASE_FRAME.Reserved),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_KIST_BASE_FRAME>((mem, ptr) => new _KIST_BASE_FRAME(mem, ptr), offsets);
        }
    }
}