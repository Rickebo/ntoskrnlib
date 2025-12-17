using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVPROPKEY")]
    public sealed class _DEVPROPKEY : DynamicStructure
    {
        public _GUID fmtid { get; }
        public uint pid { get; }

        public _DEVPROPKEY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVPROPKEY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVPROPKEY.fmtid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVPROPKEY.pid),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_DEVPROPKEY>((mem, ptr) => new _DEVPROPKEY(mem, ptr), offsets);
        }
    }
}