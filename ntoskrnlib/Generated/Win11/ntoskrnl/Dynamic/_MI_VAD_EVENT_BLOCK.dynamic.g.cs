using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_VAD_EVENT_BLOCK")]
    public sealed class _MI_VAD_EVENT_BLOCK : DynamicStructure
    {
        public IntPtr Next { get; }
        public _KGATE Gate { get; }
        public _MMADDRESS_LIST SecureInfo { get; }
        public _MI_WRITE_WATCH_BLOCK WriteWatch { get; }
        public IntPtr InPageSupport { get; }
        public _MI_LARGEPAGE_VAD_INFO LargePage { get; }
        public _MI_PHYSICAL_VIEW AweView { get; }
        public IntPtr CreatingThread { get; }
        public _MI_SUB64K_FREE_RANGES PebTeb { get; }
        public IntPtr PlaceholderVad { get; }
        public IntPtr HotPatchEntry { get; }
        public uint WaitReason { get; }
        public uint CaseSpecificFlags { get; }

        public _MI_VAD_EVENT_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_VAD_EVENT_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_VAD_EVENT_BLOCK.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_VAD_EVENT_BLOCK.Gate),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_VAD_EVENT_BLOCK.SecureInfo),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_VAD_EVENT_BLOCK.WriteWatch),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_VAD_EVENT_BLOCK.InPageSupport),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_VAD_EVENT_BLOCK.LargePage),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_VAD_EVENT_BLOCK.AweView),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_VAD_EVENT_BLOCK.CreatingThread),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_VAD_EVENT_BLOCK.PebTeb),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_VAD_EVENT_BLOCK.PlaceholderVad),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_VAD_EVENT_BLOCK.HotPatchEntry),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_VAD_EVENT_BLOCK.WaitReason),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MI_VAD_EVENT_BLOCK.CaseSpecificFlags),
                    new ulong[]
                    {
                        84UL
                    }
                }
            };
            Register<_MI_VAD_EVENT_BLOCK>((mem, ptr) => new _MI_VAD_EVENT_BLOCK(mem, ptr), offsets);
        }
    }
}