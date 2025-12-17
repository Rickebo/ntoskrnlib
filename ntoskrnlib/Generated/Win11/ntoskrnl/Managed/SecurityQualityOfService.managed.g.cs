using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SECURITY_QUALITY_OF_SERVICE")]
    public sealed class SecurityQualityOfService : DynamicStructure
    {
        [Offset(0UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(4UL)]
        public uint ImpersonationLevel { get => ReadHere<uint>(nameof(ImpersonationLevel)); set => WriteHere(nameof(ImpersonationLevel), value); }

        [Offset(8UL)]
        public byte ContextTrackingMode { get => ReadHere<byte>(nameof(ContextTrackingMode)); set => WriteHere(nameof(ContextTrackingMode), value); }

        [Offset(9UL)]
        public byte EffectiveOnly { get => ReadHere<byte>(nameof(EffectiveOnly)); set => WriteHere(nameof(EffectiveOnly), value); }

        public SecurityQualityOfService(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SecurityQualityOfService>();
        }
    }
}