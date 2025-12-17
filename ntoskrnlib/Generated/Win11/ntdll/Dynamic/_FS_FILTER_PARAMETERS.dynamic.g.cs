using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_FS_FILTER_PARAMETERS")]
    public sealed class _FS_FILTER_PARAMETERS : DynamicStructure
    {
        public _unnamed_tag_ AcquireForModifiedPageWriter { get; }
        public _unnamed_tag_ ReleaseForModifiedPageWriter { get; }
        public _unnamed_tag_ AcquireForSectionSynchronization { get; }
        public _unnamed_tag_ QueryOpen { get; }
        public _unnamed_tag_ Others { get; }

        public _FS_FILTER_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FS_FILTER_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FS_FILTER_PARAMETERS.AcquireForModifiedPageWriter),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FS_FILTER_PARAMETERS.ReleaseForModifiedPageWriter),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FS_FILTER_PARAMETERS.AcquireForSectionSynchronization),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FS_FILTER_PARAMETERS.QueryOpen),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FS_FILTER_PARAMETERS.Others),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_FS_FILTER_PARAMETERS>((mem, ptr) => new _FS_FILTER_PARAMETERS(mem, ptr), offsets);
        }
    }
}