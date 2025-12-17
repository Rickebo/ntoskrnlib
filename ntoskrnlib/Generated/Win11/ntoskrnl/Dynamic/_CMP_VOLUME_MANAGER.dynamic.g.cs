using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CMP_VOLUME_MANAGER")]
    public sealed class _CMP_VOLUME_MANAGER : DynamicStructure
    {
        public _CMSI_RW_LOCK VolumeContextListLock { get; }
        public _LIST_ENTRY VolumeContextListHead { get; }

        public _CMP_VOLUME_MANAGER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CMP_VOLUME_MANAGER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CMP_VOLUME_MANAGER.VolumeContextListLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CMP_VOLUME_MANAGER.VolumeContextListHead),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CMP_VOLUME_MANAGER>((mem, ptr) => new _CMP_VOLUME_MANAGER(mem, ptr), offsets);
        }
    }
}