using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PLUGPLAY_EVENT_BLOCK")]
    public sealed class _PLUGPLAY_EVENT_BLOCK : DynamicStructure
    {
        public _GUID EventGuid { get; }
        public uint EventCategory { get; }
        public IntPtr Result { get; }
        public uint Flags { get; }
        public uint TotalSize { get; }
        public IntPtr DeviceObject { get; }
        public _unnamed_tag_ u { get; }

        public _PLUGPLAY_EVENT_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PLUGPLAY_EVENT_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PLUGPLAY_EVENT_BLOCK.EventGuid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PLUGPLAY_EVENT_BLOCK.EventCategory),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PLUGPLAY_EVENT_BLOCK.Result),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PLUGPLAY_EVENT_BLOCK.Flags),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PLUGPLAY_EVENT_BLOCK.TotalSize),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_PLUGPLAY_EVENT_BLOCK.DeviceObject),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PLUGPLAY_EVENT_BLOCK.u),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_PLUGPLAY_EVENT_BLOCK>((mem, ptr) => new _PLUGPLAY_EVENT_BLOCK(mem, ptr), offsets);
        }
    }
}