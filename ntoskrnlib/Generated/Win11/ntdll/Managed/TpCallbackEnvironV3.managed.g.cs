using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TP_CALLBACK_ENVIRON_V3")]
    public sealed class TpCallbackEnvironV3 : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(8UL)]
        public IntPtr Pool { get => ReadHere<IntPtr>(nameof(Pool)); set => WriteHere(nameof(Pool), value); }

        [Offset(16UL)]
        public IntPtr CleanupGroup { get => ReadHere<IntPtr>(nameof(CleanupGroup)); set => WriteHere(nameof(CleanupGroup), value); }

        [Offset(24UL)]
        public IntPtr CleanupGroupCancelCallback { get => ReadHere<IntPtr>(nameof(CleanupGroupCancelCallback)); set => WriteHere(nameof(CleanupGroupCancelCallback), value); }

        [Offset(32UL)]
        public IntPtr RaceDll { get => ReadHere<IntPtr>(nameof(RaceDll)); set => WriteHere(nameof(RaceDll), value); }

        [Offset(40UL)]
        public IntPtr ActivationContext { get => ReadHere<IntPtr>(nameof(ActivationContext)); set => WriteHere(nameof(ActivationContext), value); }

        [Offset(48UL)]
        public IntPtr FinalizationCallback { get => ReadHere<IntPtr>(nameof(FinalizationCallback)); set => WriteHere(nameof(FinalizationCallback), value); }

        [Offset(56UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        [Offset(60UL)]
        public uint CallbackPriority { get => ReadHere<uint>(nameof(CallbackPriority)); set => WriteHere(nameof(CallbackPriority), value); }

        [Offset(64UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        public TpCallbackEnvironV3(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TpCallbackEnvironV3>();
        }
    }
}