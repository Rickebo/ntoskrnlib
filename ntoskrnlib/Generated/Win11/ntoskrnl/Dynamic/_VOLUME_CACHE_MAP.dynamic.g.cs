using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VOLUME_CACHE_MAP")]
    public sealed class _VOLUME_CACHE_MAP : DynamicStructure
    {
        public short NodeTypeCode { get; }
        public short NodeByteCode { get; }
        public long UseCount { get; }
        public IntPtr DeviceObject { get; }
        public _LIST_ENTRY VolumeCacheMapLinks { get; }
        public ulong DirtyPages { get; }
        public _LOG_HANDLE_CONTEXT LogHandleContext { get; }
        public uint Flags { get; }
        public uint PagesQueuedToDisk { get; }
        public uint LoggedPagesQueuedToDisk { get; }
        public uint VolumeId { get; }
        public _LIST_ENTRY PrivateVolumeList { get; }
        public _CC_VOLUME_TELEMETRY VolumeTelemetry { get; }
        public _KE_RCU_WORKITEM RcuContext { get; }

        public _VOLUME_CACHE_MAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VOLUME_CACHE_MAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VOLUME_CACHE_MAP.NodeTypeCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VOLUME_CACHE_MAP.NodeByteCode),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_VOLUME_CACHE_MAP.UseCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VOLUME_CACHE_MAP.DeviceObject),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VOLUME_CACHE_MAP.VolumeCacheMapLinks),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_VOLUME_CACHE_MAP.DirtyPages),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_VOLUME_CACHE_MAP.LogHandleContext),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_VOLUME_CACHE_MAP.Flags),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_VOLUME_CACHE_MAP.PagesQueuedToDisk),
                    new ulong[]
                    {
                        204UL
                    }
                },
                {
                    nameof(_VOLUME_CACHE_MAP.LoggedPagesQueuedToDisk),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_VOLUME_CACHE_MAP.VolumeId),
                    new ulong[]
                    {
                        212UL
                    }
                },
                {
                    nameof(_VOLUME_CACHE_MAP.PrivateVolumeList),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_VOLUME_CACHE_MAP.VolumeTelemetry),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_VOLUME_CACHE_MAP.RcuContext),
                    new ulong[]
                    {
                        2712UL
                    }
                }
            };
            Register<_VOLUME_CACHE_MAP>((mem, ptr) => new _VOLUME_CACHE_MAP(mem, ptr), offsets);
        }
    }
}