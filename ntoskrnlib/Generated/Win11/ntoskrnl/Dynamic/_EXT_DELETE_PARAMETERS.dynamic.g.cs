using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_DELETE_PARAMETERS")]
    public sealed class _EXT_DELETE_PARAMETERS : DynamicStructure
    {
        public uint Version { get; }
        public uint Reserved { get; }
        public IntPtr DeleteCallback { get; }
        public IntPtr DeleteContext { get; }

        public _EXT_DELETE_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_DELETE_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_DELETE_PARAMETERS.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_DELETE_PARAMETERS.Reserved),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_EXT_DELETE_PARAMETERS.DeleteCallback),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXT_DELETE_PARAMETERS.DeleteContext),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_EXT_DELETE_PARAMETERS>((mem, ptr) => new _EXT_DELETE_PARAMETERS(mem, ptr), offsets);
        }
    }
}