using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETWP_NOTIFICATION_HEADER")]
    public sealed class _ETWP_NOTIFICATION_HEADER : DynamicStructure
    {
        public uint NotificationType { get; }
        public uint NotificationSize { get; }
        public int RefCount { get; }
        public byte ReplyRequested { get; }
        public uint ReplyIndex { get; }
        public uint Timeout { get; }
        public uint ReplyCount { get; }
        public uint NotifyeeCount { get; }
        public ulong ReplyHandle { get; }
        public IntPtr ReplyObject { get; }
        public uint RegIndex { get; }
        public uint TargetPID { get; }
        public uint SourcePID { get; }
        public _GUID DestinationGuid { get; }
        public _GUID SourceGuid { get; }

        public _ETWP_NOTIFICATION_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETWP_NOTIFICATION_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.NotificationType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.NotificationSize),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.RefCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.ReplyRequested),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.ReplyIndex),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.Timeout),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.ReplyCount),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.NotifyeeCount),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.ReplyHandle),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.ReplyObject),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.RegIndex),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.TargetPID),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.SourcePID),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.DestinationGuid),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ETWP_NOTIFICATION_HEADER.SourceGuid),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_ETWP_NOTIFICATION_HEADER>((mem, ptr) => new _ETWP_NOTIFICATION_HEADER(mem, ptr), offsets);
        }
    }
}