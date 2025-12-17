using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOGGED_STREAM_CALLBACK_V1")]
    public sealed class LoggedStreamCallbackV1 : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr LogHandle { get => ReadHere<IntPtr>(nameof(LogHandle)); set => WriteHere(nameof(LogHandle), value); }

        [Offset(8UL)]
        public IntPtr FlushToLsnRoutine { get => ReadHere<IntPtr>(nameof(FlushToLsnRoutine)); set => WriteHere(nameof(FlushToLsnRoutine), value); }

        public LoggedStreamCallbackV1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoggedStreamCallbackV1>();
        }
    }
}