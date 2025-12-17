using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMSUPPORT_SHARED")]
    public sealed class _MMSUPPORT_SHARED : DynamicStructure
    {
        public IntPtr WorkingSetLockArray { get; }
        public ulong ReleasedCommitDebt { get; }
        public ulong ResetPagesRepurposedCount { get; }
        public IntPtr WsSwapSupport { get; }
        public IntPtr CommitReleaseContext { get; }
        public IntPtr AccessLog { get; }
        public ulong ChargedWslePages { get; }
        public ulong ActualWslePages { get; }
        public int WorkingSetCoreLock { get; }
        public IntPtr ShadowMapping { get; }

        public _MMSUPPORT_SHARED(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMSUPPORT_SHARED()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMSUPPORT_SHARED.WorkingSetLockArray),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUPPORT_SHARED.ReleasedCommitDebt),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MMSUPPORT_SHARED.ResetPagesRepurposedCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MMSUPPORT_SHARED.WsSwapSupport),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MMSUPPORT_SHARED.CommitReleaseContext),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MMSUPPORT_SHARED.AccessLog),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MMSUPPORT_SHARED.ChargedWslePages),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MMSUPPORT_SHARED.ActualWslePages),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MMSUPPORT_SHARED.WorkingSetCoreLock),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MMSUPPORT_SHARED.ShadowMapping),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_MMSUPPORT_SHARED>((mem, ptr) => new _MMSUPPORT_SHARED(mem, ptr), offsets);
        }
    }
}