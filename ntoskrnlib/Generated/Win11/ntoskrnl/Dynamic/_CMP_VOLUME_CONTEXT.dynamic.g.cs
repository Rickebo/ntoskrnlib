using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CMP_VOLUME_CONTEXT")]
    public sealed class _CMP_VOLUME_CONTEXT : DynamicStructure
    {
        public _LIST_ENTRY VolumeContextListEntry { get; }
        public IntPtr VolumeManager { get; }
        public long RefCount { get; }
        public _GUID VolumeGuid { get; }
        public IntPtr VolumeFileObject { get; }
        public _CMSI_RW_LOCK VolumeContextLock { get; }
        public uint DeviceUsageNotificationState { get; }

        public _CMP_VOLUME_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CMP_VOLUME_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CMP_VOLUME_CONTEXT.VolumeContextListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CMP_VOLUME_CONTEXT.VolumeManager),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CMP_VOLUME_CONTEXT.RefCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CMP_VOLUME_CONTEXT.VolumeGuid),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CMP_VOLUME_CONTEXT.VolumeFileObject),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CMP_VOLUME_CONTEXT.VolumeContextLock),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CMP_VOLUME_CONTEXT.DeviceUsageNotificationState),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_CMP_VOLUME_CONTEXT>((mem, ptr) => new _CMP_VOLUME_CONTEXT(mem, ptr), offsets);
        }
    }
}