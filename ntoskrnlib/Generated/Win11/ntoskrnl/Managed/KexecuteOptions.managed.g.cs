using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KEXECUTE_OPTIONS")]
    public sealed class KexecuteOptions : DynamicStructure
    {
        [Offset(0UL)]
        public byte ExecuteDisable { get => ReadHere<byte>(nameof(ExecuteDisable)); set => WriteHere(nameof(ExecuteDisable), value); }

        [Offset(0UL)]
        public byte ExecuteEnable { get => ReadHere<byte>(nameof(ExecuteEnable)); set => WriteHere(nameof(ExecuteEnable), value); }

        [Offset(0UL)]
        public byte DisableThunkEmulation { get => ReadHere<byte>(nameof(DisableThunkEmulation)); set => WriteHere(nameof(DisableThunkEmulation), value); }

        [Offset(0UL)]
        public byte Permanent { get => ReadHere<byte>(nameof(Permanent)); set => WriteHere(nameof(Permanent), value); }

        [Offset(0UL)]
        public byte ExecuteDispatchEnable { get => ReadHere<byte>(nameof(ExecuteDispatchEnable)); set => WriteHere(nameof(ExecuteDispatchEnable), value); }

        [Offset(0UL)]
        public byte ImageDispatchEnable { get => ReadHere<byte>(nameof(ImageDispatchEnable)); set => WriteHere(nameof(ImageDispatchEnable), value); }

        [Offset(0UL)]
        public byte DisableExceptionChainValidation { get => ReadHere<byte>(nameof(DisableExceptionChainValidation)); set => WriteHere(nameof(DisableExceptionChainValidation), value); }

        [Offset(0UL)]
        public byte Spare { get => ReadHere<byte>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(0UL)]
        public byte ExecuteOptions { get => ReadHere<byte>(nameof(ExecuteOptions)); set => WriteHere(nameof(ExecuteOptions), value); }

        [Offset(0UL)]
        public byte ExecuteOptionsNV { get => ReadHere<byte>(nameof(ExecuteOptionsNV)); set => WriteHere(nameof(ExecuteOptionsNV), value); }

        public KexecuteOptions(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KexecuteOptions>();
        }
    }
}