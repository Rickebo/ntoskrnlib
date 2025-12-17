using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOADER_BUGCHECK_PARAMETERS")]
    public sealed class _LOADER_BUGCHECK_PARAMETERS : DynamicStructure
    {
        public uint BugcheckCode { get; }
        public ulong BugcheckParameter1 { get; }
        public ulong BugcheckParameter2 { get; }
        public ulong BugcheckParameter3 { get; }
        public ulong BugcheckParameter4 { get; }

        public _LOADER_BUGCHECK_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOADER_BUGCHECK_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOADER_BUGCHECK_PARAMETERS.BugcheckCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_BUGCHECK_PARAMETERS.BugcheckParameter1),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LOADER_BUGCHECK_PARAMETERS.BugcheckParameter2),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_LOADER_BUGCHECK_PARAMETERS.BugcheckParameter3),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_LOADER_BUGCHECK_PARAMETERS.BugcheckParameter4),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_LOADER_BUGCHECK_PARAMETERS>((mem, ptr) => new _LOADER_BUGCHECK_PARAMETERS(mem, ptr), offsets);
        }
    }
}