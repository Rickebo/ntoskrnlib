using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_XPF_RECOVERY_INFO")]
    public sealed class XpfRecoveryInfo : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag FailureReason { get => ReadStructure<UnnamedTag>(nameof(FailureReason)); set => WriteStructure(nameof(FailureReason), value); }

        [Offset(4UL)]
        public UnnamedTag Action { get => ReadStructure<UnnamedTag>(nameof(Action)); set => WriteStructure(nameof(Action), value); }

        [Offset(8UL)]
        public byte ActionRequired { get => ReadHere<byte>(nameof(ActionRequired)); set => WriteHere(nameof(ActionRequired), value); }

        [Offset(9UL)]
        public byte RecoverySucceeded { get => ReadHere<byte>(nameof(RecoverySucceeded)); set => WriteHere(nameof(RecoverySucceeded), value); }

        [Offset(10UL)]
        public byte RecoveryKernel { get => ReadHere<byte>(nameof(RecoveryKernel)); set => WriteHere(nameof(RecoveryKernel), value); }

        [Offset(11UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(12UL)]
        public ushort Reserved2 { get => ReadHere<ushort>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(14UL)]
        public ushort Reserved3 { get => ReadHere<ushort>(nameof(Reserved3)); set => WriteHere(nameof(Reserved3), value); }

        [Offset(16UL)]
        public uint Reserved4 { get => ReadHere<uint>(nameof(Reserved4)); set => WriteHere(nameof(Reserved4), value); }

        public XpfRecoveryInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<XpfRecoveryInfo>();
        }
    }
}