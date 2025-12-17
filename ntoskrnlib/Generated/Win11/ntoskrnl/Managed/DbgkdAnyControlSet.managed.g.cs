using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DBGKD_ANY_CONTROL_SET")]
    public sealed class DbgkdAnyControlSet : DynamicStructure
    {
        [Offset(0UL)]
        public X86DbgkdControlSet X86ControlSet { get => ReadStructure<X86DbgkdControlSet>(nameof(X86ControlSet)); set => WriteStructure(nameof(X86ControlSet), value); }

        [Offset(0UL)]
        public uint AlphaControlSet { get => ReadHere<uint>(nameof(AlphaControlSet)); set => WriteHere(nameof(AlphaControlSet), value); }

        [Offset(0UL)]
        public IA64DbgkdControlSet IA64ControlSet { get => ReadStructure<IA64DbgkdControlSet>(nameof(IA64ControlSet)); set => WriteStructure(nameof(IA64ControlSet), value); }

        [Offset(0UL)]
        public AMD64DbgkdControlSet Amd64ControlSet { get => ReadStructure<AMD64DbgkdControlSet>(nameof(Amd64ControlSet)); set => WriteStructure(nameof(Amd64ControlSet), value); }

        [Offset(0UL)]
        public ArmDbgkdControlSet ArmControlSet { get => ReadStructure<ArmDbgkdControlSet>(nameof(ArmControlSet)); set => WriteStructure(nameof(ArmControlSet), value); }

        [Offset(0UL)]
        public ARM64DbgkdControlSet Arm64ControlSet { get => ReadStructure<ARM64DbgkdControlSet>(nameof(Arm64ControlSet)); set => WriteStructure(nameof(Arm64ControlSet), value); }

        [Offset(0UL)]
        public ArmceDbgkdControlSet ArmCeControlSet { get => ReadStructure<ArmceDbgkdControlSet>(nameof(ArmCeControlSet)); set => WriteStructure(nameof(ArmCeControlSet), value); }

        [Offset(0UL)]
        public PpcDbgkdControlSet PpcControlSet { get => ReadStructure<PpcDbgkdControlSet>(nameof(PpcControlSet)); set => WriteStructure(nameof(PpcControlSet), value); }

        public DbgkdAnyControlSet(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DbgkdAnyControlSet>();
        }
    }
}