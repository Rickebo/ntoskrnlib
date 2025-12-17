using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_IRP_DATA")]
    public sealed class _POP_IRP_DATA : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public IntPtr Irp { get; }
        public IntPtr Pdo { get; }
        public IntPtr TargetDevice { get; }
        public IntPtr CurrentDevice { get; }
        public ulong WatchdogStart { get; }
        public _KTIMER WatchdogTimer { get; }
        public _KDPC WatchdogDpc { get; }
        public byte MinorFunction { get; }
        public uint PowerStateType { get; }
        public _POWER_STATE PowerState { get; }
        public IntPtr FxDevice { get; }
        public byte SystemTransition { get; }
        public byte NotifyPEP { get; }
        public int IrpSequenceID { get; }
        public _unnamed_tag_ Device { get; }
        public _unnamed_tag_ System { get; }
        public uint DStateReason { get; }
        public ulong WatchdogLock { get; }
        public uint WatchdogState { get; }
        public ulong BlackboxWatchdogStartTime { get; }

        public _POP_IRP_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_IRP_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_IRP_DATA.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.Irp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.Pdo),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.TargetDevice),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.CurrentDevice),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.WatchdogStart),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.WatchdogTimer),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.WatchdogDpc),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.MinorFunction),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.PowerStateType),
                    new ulong[]
                    {
                        188UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.PowerState),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.FxDevice),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.SystemTransition),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.NotifyPEP),
                    new ulong[]
                    {
                        209UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.IrpSequenceID),
                    new ulong[]
                    {
                        212UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.Device),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.System),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.DStateReason),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.WatchdogLock),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.WatchdogState),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_POP_IRP_DATA.BlackboxWatchdogStartTime),
                    new ulong[]
                    {
                        304UL
                    }
                }
            };
            Register<_POP_IRP_DATA>((mem, ptr) => new _POP_IRP_DATA(mem, ptr), offsets);
        }
    }
}