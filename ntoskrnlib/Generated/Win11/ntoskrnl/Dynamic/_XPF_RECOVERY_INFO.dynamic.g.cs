using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_XPF_RECOVERY_INFO")]
    public sealed class _XPF_RECOVERY_INFO : DynamicStructure
    {
        public _unnamed_tag_ FailureReason { get; }
        public _unnamed_tag_ Action { get; }
        public byte ActionRequired { get; }
        public byte RecoverySucceeded { get; }
        public byte RecoveryKernel { get; }
        public byte Reserved { get; }
        public ushort Reserved2 { get; }
        public ushort Reserved3 { get; }
        public uint Reserved4 { get; }

        public _XPF_RECOVERY_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _XPF_RECOVERY_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_XPF_RECOVERY_INFO.FailureReason),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XPF_RECOVERY_INFO.Action),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_XPF_RECOVERY_INFO.ActionRequired),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_XPF_RECOVERY_INFO.RecoverySucceeded),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_XPF_RECOVERY_INFO.RecoveryKernel),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_XPF_RECOVERY_INFO.Reserved),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_XPF_RECOVERY_INFO.Reserved2),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_XPF_RECOVERY_INFO.Reserved3),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_XPF_RECOVERY_INFO.Reserved4),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_XPF_RECOVERY_INFO>((mem, ptr) => new _XPF_RECOVERY_INFO(mem, ptr), offsets);
        }
    }
}