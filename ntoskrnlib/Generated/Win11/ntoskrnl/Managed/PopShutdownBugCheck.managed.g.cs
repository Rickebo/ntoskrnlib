using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_SHUTDOWN_BUG_CHECK")]
    public sealed class PopShutdownBugCheck : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr InitiatingThread { get => ReadHere<IntPtr>(nameof(InitiatingThread)); set => WriteHere(nameof(InitiatingThread), value); }

        [Offset(8UL)]
        public IntPtr InitiatingProcess { get => ReadHere<IntPtr>(nameof(InitiatingProcess)); set => WriteHere(nameof(InitiatingProcess), value); }

        [Offset(16UL)]
        public IntPtr ThreadId { get => ReadHere<IntPtr>(nameof(ThreadId)); set => WriteHere(nameof(ThreadId), value); }

        [Offset(24UL)]
        public IntPtr ProcessId { get => ReadHere<IntPtr>(nameof(ProcessId)); set => WriteHere(nameof(ProcessId), value); }

        [Offset(32UL)]
        public uint Code { get => ReadHere<uint>(nameof(Code)); set => WriteHere(nameof(Code), value); }

        [Offset(40UL)]
        public ulong Parameter1 { get => ReadHere<ulong>(nameof(Parameter1)); set => WriteHere(nameof(Parameter1), value); }

        [Offset(48UL)]
        public ulong Parameter2 { get => ReadHere<ulong>(nameof(Parameter2)); set => WriteHere(nameof(Parameter2), value); }

        [Offset(56UL)]
        public ulong Parameter3 { get => ReadHere<ulong>(nameof(Parameter3)); set => WriteHere(nameof(Parameter3), value); }

        [Offset(64UL)]
        public ulong Parameter4 { get => ReadHere<ulong>(nameof(Parameter4)); set => WriteHere(nameof(Parameter4), value); }

        public PopShutdownBugCheck(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopShutdownBugCheck>();
        }
    }
}