using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOADER_BUGCHECK_PARAMETERS")]
    public sealed class LoaderBugcheckParameters : DynamicStructure
    {
        [Offset(0UL)]
        public uint BugcheckCode { get => ReadHere<uint>(nameof(BugcheckCode)); set => WriteHere(nameof(BugcheckCode), value); }

        [Offset(8UL)]
        public ulong BugcheckParameter1 { get => ReadHere<ulong>(nameof(BugcheckParameter1)); set => WriteHere(nameof(BugcheckParameter1), value); }

        [Offset(16UL)]
        public ulong BugcheckParameter2 { get => ReadHere<ulong>(nameof(BugcheckParameter2)); set => WriteHere(nameof(BugcheckParameter2), value); }

        [Offset(24UL)]
        public ulong BugcheckParameter3 { get => ReadHere<ulong>(nameof(BugcheckParameter3)); set => WriteHere(nameof(BugcheckParameter3), value); }

        [Offset(32UL)]
        public ulong BugcheckParameter4 { get => ReadHere<ulong>(nameof(BugcheckParameter4)); set => WriteHere(nameof(BugcheckParameter4), value); }

        public LoaderBugcheckParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoaderBugcheckParameters>();
        }
    }
}