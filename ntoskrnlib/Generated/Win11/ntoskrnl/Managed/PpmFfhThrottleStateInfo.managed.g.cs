using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PPM_FFH_THROTTLE_STATE_INFO")]
    public sealed class PpmFfhThrottleStateInfo : DynamicStructure
    {
        [Offset(0UL)]
        public byte EnableLogging { get => ReadHere<byte>(nameof(EnableLogging)); set => WriteHere(nameof(EnableLogging), value); }

        [Offset(4UL)]
        public uint MismatchCount { get => ReadHere<uint>(nameof(MismatchCount)); set => WriteHere(nameof(MismatchCount), value); }

        [Offset(8UL)]
        public byte Initialized { get => ReadHere<byte>(nameof(Initialized)); set => WriteHere(nameof(Initialized), value); }

        [Offset(16UL)]
        public ulong LastValue { get => ReadHere<ulong>(nameof(LastValue)); set => WriteHere(nameof(LastValue), value); }

        [Offset(24UL)]
        public LargeInteger LastLogTickCount { get => ReadStructure<LargeInteger>(nameof(LastLogTickCount)); set => WriteStructure(nameof(LastLogTickCount), value); }

        public PpmFfhThrottleStateInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmFfhThrottleStateInfo>();
        }
    }
}