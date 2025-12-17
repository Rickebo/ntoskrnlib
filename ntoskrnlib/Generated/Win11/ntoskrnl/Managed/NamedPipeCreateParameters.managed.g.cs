using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NAMED_PIPE_CREATE_PARAMETERS")]
    public sealed class NamedPipeCreateParameters : DynamicStructure
    {
        [Offset(0UL)]
        public uint NamedPipeType { get => ReadHere<uint>(nameof(NamedPipeType)); set => WriteHere(nameof(NamedPipeType), value); }

        [Offset(4UL)]
        public uint ReadMode { get => ReadHere<uint>(nameof(ReadMode)); set => WriteHere(nameof(ReadMode), value); }

        [Offset(8UL)]
        public uint CompletionMode { get => ReadHere<uint>(nameof(CompletionMode)); set => WriteHere(nameof(CompletionMode), value); }

        [Offset(12UL)]
        public uint MaximumInstances { get => ReadHere<uint>(nameof(MaximumInstances)); set => WriteHere(nameof(MaximumInstances), value); }

        [Offset(16UL)]
        public uint InboundQuota { get => ReadHere<uint>(nameof(InboundQuota)); set => WriteHere(nameof(InboundQuota), value); }

        [Offset(20UL)]
        public uint OutboundQuota { get => ReadHere<uint>(nameof(OutboundQuota)); set => WriteHere(nameof(OutboundQuota), value); }

        [Offset(24UL)]
        public LargeInteger DefaultTimeout { get => ReadStructure<LargeInteger>(nameof(DefaultTimeout)); set => WriteStructure(nameof(DefaultTimeout), value); }

        [Offset(32UL)]
        public byte TimeoutSpecified { get => ReadHere<byte>(nameof(TimeoutSpecified)); set => WriteHere(nameof(TimeoutSpecified), value); }

        public NamedPipeCreateParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NamedPipeCreateParameters>();
        }
    }
}