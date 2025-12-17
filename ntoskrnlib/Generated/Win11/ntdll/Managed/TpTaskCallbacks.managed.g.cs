using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TP_TASK_CALLBACKS")]
    public sealed class TpTaskCallbacks : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ExecuteCallback { get => ReadHere<IntPtr>(nameof(ExecuteCallback)); set => WriteHere(nameof(ExecuteCallback), value); }

        [Offset(8UL)]
        public IntPtr Unposted { get => ReadHere<IntPtr>(nameof(Unposted)); set => WriteHere(nameof(Unposted), value); }

        public TpTaskCallbacks(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TpTaskCallbacks>();
        }
    }
}