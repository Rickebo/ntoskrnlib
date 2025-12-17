using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MAILSLOT_CREATE_PARAMETERS")]
    public sealed class MailslotCreateParameters : DynamicStructure
    {
        [Offset(0UL)]
        public uint MailslotQuota { get => ReadHere<uint>(nameof(MailslotQuota)); set => WriteHere(nameof(MailslotQuota), value); }

        [Offset(4UL)]
        public uint MaximumMessageSize { get => ReadHere<uint>(nameof(MaximumMessageSize)); set => WriteHere(nameof(MaximumMessageSize), value); }

        [Offset(8UL)]
        public LargeInteger ReadTimeout { get => ReadStructure<LargeInteger>(nameof(ReadTimeout)); set => WriteStructure(nameof(ReadTimeout), value); }

        [Offset(16UL)]
        public byte TimeoutSpecified { get => ReadHere<byte>(nameof(TimeoutSpecified)); set => WriteHere(nameof(TimeoutSpecified), value); }

        public MailslotCreateParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MailslotCreateParameters>();
        }
    }
}