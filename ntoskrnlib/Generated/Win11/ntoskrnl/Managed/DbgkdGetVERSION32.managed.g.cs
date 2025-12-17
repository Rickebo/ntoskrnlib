using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_GET_VERSION32")]
    public sealed class DbgkdGetVERSION32 : DynamicStructure
    {
        [Offset(0UL)]
        public ushort MajorVersion { get => ReadHere<ushort>(nameof(MajorVersion)); set => WriteHere(nameof(MajorVersion), value); }

        [Offset(2UL)]
        public ushort MinorVersion { get => ReadHere<ushort>(nameof(MinorVersion)); set => WriteHere(nameof(MinorVersion), value); }

        [Offset(4UL)]
        public ushort ProtocolVersion { get => ReadHere<ushort>(nameof(ProtocolVersion)); set => WriteHere(nameof(ProtocolVersion), value); }

        [Offset(6UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(8UL)]
        public uint KernBase { get => ReadHere<uint>(nameof(KernBase)); set => WriteHere(nameof(KernBase), value); }

        [Offset(12UL)]
        public uint PsLoadedModuleList { get => ReadHere<uint>(nameof(PsLoadedModuleList)); set => WriteHere(nameof(PsLoadedModuleList), value); }

        [Offset(16UL)]
        public ushort MachineType { get => ReadHere<ushort>(nameof(MachineType)); set => WriteHere(nameof(MachineType), value); }

        [Offset(18UL)]
        public ushort ThCallbackStack { get => ReadHere<ushort>(nameof(ThCallbackStack)); set => WriteHere(nameof(ThCallbackStack), value); }

        [Offset(20UL)]
        public ushort NextCallback { get => ReadHere<ushort>(nameof(NextCallback)); set => WriteHere(nameof(NextCallback), value); }

        [Offset(22UL)]
        public ushort FramePointer { get => ReadHere<ushort>(nameof(FramePointer)); set => WriteHere(nameof(FramePointer), value); }

        [Offset(24UL)]
        public uint KiCallUserMode { get => ReadHere<uint>(nameof(KiCallUserMode)); set => WriteHere(nameof(KiCallUserMode), value); }

        [Offset(28UL)]
        public uint KeUserCallbackDispatcher { get => ReadHere<uint>(nameof(KeUserCallbackDispatcher)); set => WriteHere(nameof(KeUserCallbackDispatcher), value); }

        [Offset(32UL)]
        public uint BreakpointWithStatus { get => ReadHere<uint>(nameof(BreakpointWithStatus)); set => WriteHere(nameof(BreakpointWithStatus), value); }

        [Offset(36UL)]
        public uint DebuggerDataList { get => ReadHere<uint>(nameof(DebuggerDataList)); set => WriteHere(nameof(DebuggerDataList), value); }

        public DbgkdGetVERSION32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdGetVERSION32>();
        }
    }
}