using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOGGED_STREAM_CALLBACK_V2")]
    public sealed class LoggedStreamCallbackV2 : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr LogHandleContext { get => ReadHere<IntPtr>(nameof(LogHandleContext)); set => WriteHere(nameof(LogHandleContext), value); }

        public LoggedStreamCallbackV2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoggedStreamCallbackV2>();
        }
    }
}