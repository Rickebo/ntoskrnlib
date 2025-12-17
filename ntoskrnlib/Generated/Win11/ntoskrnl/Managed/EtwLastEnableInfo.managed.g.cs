using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_LAST_ENABLE_INFO")]
    public sealed class EtwLastEnableInfo : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger EnableFlags { get => ReadStructure<LargeInteger>(nameof(EnableFlags)); set => WriteStructure(nameof(EnableFlags), value); }

        [Offset(8UL)]
        public ushort LoggerId { get => ReadHere<ushort>(nameof(LoggerId)); set => WriteHere(nameof(LoggerId), value); }

        [Offset(10UL)]
        public byte Level { get => ReadHere<byte>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(11UL)]
        public byte Enabled { get => ReadHere<byte>(nameof(Enabled)); set => WriteHere(nameof(Enabled), value); }

        [Offset(11UL)]
        public byte InternalFlag { get => ReadHere<byte>(nameof(InternalFlag)); set => WriteHere(nameof(InternalFlag), value); }

        public EtwLastEnableInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwLastEnableInfo>();
        }
    }
}