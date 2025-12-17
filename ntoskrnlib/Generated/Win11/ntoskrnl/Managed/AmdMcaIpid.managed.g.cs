using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_AMD_MCA_IPID")]
    public sealed class AmdMcaIpid : DynamicStructure
    {
        [Offset(0UL)]
        public ulong InstanceId { get => ReadHere<ulong>(nameof(InstanceId)); set => WriteHere(nameof(InstanceId), value); }

        [Offset(0UL)]
        public ulong HardwareId { get => ReadHere<ulong>(nameof(HardwareId)); set => WriteHere(nameof(HardwareId), value); }

        [Offset(0UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ulong McaType { get => ReadHere<ulong>(nameof(McaType)); set => WriteHere(nameof(McaType), value); }

        [Offset(0UL)]
        public ulong AsUINT64 { get => ReadHere<ulong>(nameof(AsUINT64)); set => WriteHere(nameof(AsUINT64), value); }

        public AmdMcaIpid(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AmdMcaIpid>();
        }
    }
}