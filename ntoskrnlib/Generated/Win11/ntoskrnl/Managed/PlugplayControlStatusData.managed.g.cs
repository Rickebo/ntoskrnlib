using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PLUGPLAY_CONTROL_STATUS_DATA")]
    public sealed class PlugplayControlStatusData : DynamicStructure
    {
        [Offset(0UL)]
        public UnicodeString DeviceInstance { get => ReadStructure<UnicodeString>(nameof(DeviceInstance)); set => WriteStructure(nameof(DeviceInstance), value); }

        [Offset(16UL)]
        public uint Operation { get => ReadHere<uint>(nameof(Operation)); set => WriteHere(nameof(Operation), value); }

        [Offset(20UL)]
        public uint DeviceStatus { get => ReadHere<uint>(nameof(DeviceStatus)); set => WriteHere(nameof(DeviceStatus), value); }

        [Offset(24UL)]
        public uint DeviceProblem { get => ReadHere<uint>(nameof(DeviceProblem)); set => WriteHere(nameof(DeviceProblem), value); }

        [Offset(28UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(32UL)]
        public int ProblemStatus { get => ReadHere<int>(nameof(ProblemStatus)); set => WriteHere(nameof(ProblemStatus), value); }

        public PlugplayControlStatusData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PlugplayControlStatusData>();
        }
    }
}