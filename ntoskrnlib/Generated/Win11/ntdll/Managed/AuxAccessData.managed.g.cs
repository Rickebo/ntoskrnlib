using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_AUX_ACCESS_DATA")]
    public sealed class AuxAccessData : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr PrivilegesUsed { get => ReadHere<IntPtr>(nameof(PrivilegesUsed)); set => WriteHere(nameof(PrivilegesUsed), value); }

        [Offset(8UL)]
        public GenericMapping GenericMapping { get => ReadStructure<GenericMapping>(nameof(GenericMapping)); set => WriteStructure(nameof(GenericMapping), value); }

        [Offset(24UL)]
        public uint AccessesToAudit { get => ReadHere<uint>(nameof(AccessesToAudit)); set => WriteHere(nameof(AccessesToAudit), value); }

        [Offset(28UL)]
        public uint MaximumAuditMask { get => ReadHere<uint>(nameof(MaximumAuditMask)); set => WriteHere(nameof(MaximumAuditMask), value); }

        [Offset(32UL)]
        public Guid TransactionId { get => ReadStructure<Guid>(nameof(TransactionId)); set => WriteStructure(nameof(TransactionId), value); }

        [Offset(48UL)]
        public IntPtr NewSecurityDescriptor { get => ReadHere<IntPtr>(nameof(NewSecurityDescriptor)); set => WriteHere(nameof(NewSecurityDescriptor), value); }

        [Offset(56UL)]
        public IntPtr ExistingSecurityDescriptor { get => ReadHere<IntPtr>(nameof(ExistingSecurityDescriptor)); set => WriteHere(nameof(ExistingSecurityDescriptor), value); }

        [Offset(64UL)]
        public IntPtr ParentSecurityDescriptor { get => ReadHere<IntPtr>(nameof(ParentSecurityDescriptor)); set => WriteHere(nameof(ParentSecurityDescriptor), value); }

        [Offset(72UL)]
        public IntPtr DeRefSecurityDescriptor { get => ReadHere<IntPtr>(nameof(DeRefSecurityDescriptor)); set => WriteHere(nameof(DeRefSecurityDescriptor), value); }

        [Offset(80UL)]
        public IntPtr SDLock { get => ReadHere<IntPtr>(nameof(SDLock)); set => WriteHere(nameof(SDLock), value); }

        [Offset(88UL)]
        public AccessReasons AccessReasons { get => ReadStructure<AccessReasons>(nameof(AccessReasons)); set => WriteStructure(nameof(AccessReasons), value); }

        [Offset(216UL)]
        public byte GenerateStagingEvents { get => ReadHere<byte>(nameof(GenerateStagingEvents)); set => WriteHere(nameof(GenerateStagingEvents), value); }

        public AuxAccessData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AuxAccessData>();
        }
    }
}