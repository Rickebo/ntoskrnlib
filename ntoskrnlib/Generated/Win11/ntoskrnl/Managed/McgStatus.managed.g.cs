using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MCG_STATUS")]
    public sealed class McgStatus : DynamicStructure
    {
        [Offset(0UL)]
        public uint RestartIpValid { get => ReadHere<uint>(nameof(RestartIpValid)); set => WriteHere(nameof(RestartIpValid), value); }

        [Offset(0UL)]
        public uint ErrorIpValid { get => ReadHere<uint>(nameof(ErrorIpValid)); set => WriteHere(nameof(ErrorIpValid), value); }

        [Offset(0UL)]
        public uint MachineCheckInProgress { get => ReadHere<uint>(nameof(MachineCheckInProgress)); set => WriteHere(nameof(MachineCheckInProgress), value); }

        [Offset(0UL)]
        public uint LocalMceValid { get => ReadHere<uint>(nameof(LocalMceValid)); set => WriteHere(nameof(LocalMceValid), value); }

        [Offset(0UL)]
        public uint Reserved1 { get => ReadHere<uint>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(4UL)]
        public uint Reserved2 { get => ReadHere<uint>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(0UL)]
        public ulong QuadPart { get => ReadHere<ulong>(nameof(QuadPart)); set => WriteHere(nameof(QuadPart), value); }

        public McgStatus(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<McgStatus>();
        }
    }
}