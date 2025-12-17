using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VIRTUAL_EFI_RUNTIME_SERVICES")]
    public sealed class VirtualEfiRuntimeServices : DynamicStructure
    {
        [Offset(0UL)]
        public ulong GetTime { get => ReadHere<ulong>(nameof(GetTime)); set => WriteHere(nameof(GetTime), value); }

        [Offset(8UL)]
        public ulong SetTime { get => ReadHere<ulong>(nameof(SetTime)); set => WriteHere(nameof(SetTime), value); }

        [Offset(16UL)]
        public ulong GetWakeupTime { get => ReadHere<ulong>(nameof(GetWakeupTime)); set => WriteHere(nameof(GetWakeupTime), value); }

        [Offset(24UL)]
        public ulong SetWakeupTime { get => ReadHere<ulong>(nameof(SetWakeupTime)); set => WriteHere(nameof(SetWakeupTime), value); }

        [Offset(32UL)]
        public ulong SetVirtualAddressMap { get => ReadHere<ulong>(nameof(SetVirtualAddressMap)); set => WriteHere(nameof(SetVirtualAddressMap), value); }

        [Offset(40UL)]
        public ulong ConvertPointer { get => ReadHere<ulong>(nameof(ConvertPointer)); set => WriteHere(nameof(ConvertPointer), value); }

        [Offset(48UL)]
        public ulong GetVariable { get => ReadHere<ulong>(nameof(GetVariable)); set => WriteHere(nameof(GetVariable), value); }

        [Offset(56UL)]
        public ulong GetNextVariableName { get => ReadHere<ulong>(nameof(GetNextVariableName)); set => WriteHere(nameof(GetNextVariableName), value); }

        [Offset(64UL)]
        public ulong SetVariable { get => ReadHere<ulong>(nameof(SetVariable)); set => WriteHere(nameof(SetVariable), value); }

        [Offset(72UL)]
        public ulong GetNextHighMonotonicCount { get => ReadHere<ulong>(nameof(GetNextHighMonotonicCount)); set => WriteHere(nameof(GetNextHighMonotonicCount), value); }

        [Offset(80UL)]
        public ulong ResetSystem { get => ReadHere<ulong>(nameof(ResetSystem)); set => WriteHere(nameof(ResetSystem), value); }

        [Offset(88UL)]
        public ulong UpdateCapsule { get => ReadHere<ulong>(nameof(UpdateCapsule)); set => WriteHere(nameof(UpdateCapsule), value); }

        [Offset(96UL)]
        public ulong QueryCapsuleCapabilities { get => ReadHere<ulong>(nameof(QueryCapsuleCapabilities)); set => WriteHere(nameof(QueryCapsuleCapabilities), value); }

        [Offset(104UL)]
        public ulong QueryVariableInfo { get => ReadHere<ulong>(nameof(QueryVariableInfo)); set => WriteHere(nameof(QueryVariableInfo), value); }

        public VirtualEfiRuntimeServices(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VirtualEfiRuntimeServices>();
        }
    }
}