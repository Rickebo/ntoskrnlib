using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_SEP_SILOSTATE")]
    public sealed class _SEP_SILOSTATE : DynamicStructure
    {
        public IntPtr SystemLogonSession { get; }
        public IntPtr AnonymousLogonSession { get; }
        public IntPtr AnonymousLogonToken { get; }
        public IntPtr AnonymousLogonTokenNoEveryone { get; }
        public IntPtr UncSystemPaths { get; }
        public IntPtr NgenPaths { get; }

        public _SEP_SILOSTATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEP_SILOSTATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEP_SILOSTATE.SystemLogonSession),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEP_SILOSTATE.AnonymousLogonSession),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SEP_SILOSTATE.AnonymousLogonToken),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SEP_SILOSTATE.AnonymousLogonTokenNoEveryone),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SEP_SILOSTATE.UncSystemPaths),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SEP_SILOSTATE.NgenPaths),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_SEP_SILOSTATE>((mem, ptr) => new _SEP_SILOSTATE(mem, ptr), offsets);
        }
    }
}