using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_AUTHZBASEP_SECURITY_ATTRIBUTES_INFORMATION")]
    public sealed class AuthzbasepSecurityAttributesInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint SecurityAttributeCount { get => ReadHere<uint>(nameof(SecurityAttributeCount)); set => WriteHere(nameof(SecurityAttributeCount), value); }

        [Offset(8UL)]
        public ListEntry SecurityAttributesList { get => ReadStructure<ListEntry>(nameof(SecurityAttributesList)); set => WriteStructure(nameof(SecurityAttributesList), value); }

        [Offset(24UL)]
        public uint WorkingSecurityAttributeCount { get => ReadHere<uint>(nameof(WorkingSecurityAttributeCount)); set => WriteHere(nameof(WorkingSecurityAttributeCount), value); }

        [Offset(32UL)]
        public ListEntry WorkingSecurityAttributesList { get => ReadStructure<ListEntry>(nameof(WorkingSecurityAttributesList)); set => WriteStructure(nameof(WorkingSecurityAttributesList), value); }

        public AuthzbasepSecurityAttributesInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AuthzbasepSecurityAttributesInformation>();
        }
    }
}