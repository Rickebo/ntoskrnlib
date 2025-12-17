using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_NOTIFICATION_FLAGS")]
    public sealed class _WHEA_NOTIFICATION_FLAGS : DynamicStructure
    {
        public ushort PollIntervalRW { get; }
        public ushort SwitchToPollingThresholdRW { get; }
        public ushort SwitchToPollingWindowRW { get; }
        public ushort ErrorThresholdRW { get; }
        public ushort ErrorThresholdWindowRW { get; }
        public ushort Reserved { get; }
        public ushort AsUSHORT { get; }

        public _WHEA_NOTIFICATION_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_NOTIFICATION_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_NOTIFICATION_FLAGS.PollIntervalRW),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_NOTIFICATION_FLAGS.SwitchToPollingThresholdRW),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_NOTIFICATION_FLAGS.SwitchToPollingWindowRW),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_NOTIFICATION_FLAGS.ErrorThresholdRW),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_NOTIFICATION_FLAGS.ErrorThresholdWindowRW),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_NOTIFICATION_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_NOTIFICATION_FLAGS.AsUSHORT),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_NOTIFICATION_FLAGS>((mem, ptr) => new _WHEA_NOTIFICATION_FLAGS(mem, ptr), offsets);
        }
    }
}