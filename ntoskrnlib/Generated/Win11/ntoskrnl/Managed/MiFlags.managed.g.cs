using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_FLAGS")]
    public sealed class MiFlags : DynamicStructure
    {
        [Offset(0UL)]
        public ulong VerifierEnabled { get => ReadHere<ulong>(nameof(VerifierEnabled)); set => WriteHere(nameof(VerifierEnabled), value); }

        [Offset(0UL)]
        public ulong KernelVerifierEnabled { get => ReadHere<ulong>(nameof(KernelVerifierEnabled)); set => WriteHere(nameof(KernelVerifierEnabled), value); }

        [Offset(0UL)]
        public ulong LargePageKernel { get => ReadHere<ulong>(nameof(LargePageKernel)); set => WriteHere(nameof(LargePageKernel), value); }

        [Offset(0UL)]
        public ulong StopOn4d { get => ReadHere<ulong>(nameof(StopOn4d)); set => WriteHere(nameof(StopOn4d), value); }

        [Offset(0UL)]
        public ulong InitializationPhase { get => ReadHere<ulong>(nameof(InitializationPhase)); set => WriteHere(nameof(InitializationPhase), value); }

        [Offset(0UL)]
        public ulong PageKernelStacks { get => ReadHere<ulong>(nameof(PageKernelStacks)); set => WriteHere(nameof(PageKernelStacks), value); }

        [Offset(0UL)]
        public ulong CheckZeroPages { get => ReadHere<ulong>(nameof(CheckZeroPages)); set => WriteHere(nameof(CheckZeroPages), value); }

        [Offset(0UL)]
        public ulong ProcessorPrewalks { get => ReadHere<ulong>(nameof(ProcessorPrewalks)); set => WriteHere(nameof(ProcessorPrewalks), value); }

        [Offset(0UL)]
        public ulong ProcessorPostwalks { get => ReadHere<ulong>(nameof(ProcessorPostwalks)); set => WriteHere(nameof(ProcessorPostwalks), value); }

        [Offset(0UL)]
        public ulong CoverageBuild { get => ReadHere<ulong>(nameof(CoverageBuild)); set => WriteHere(nameof(CoverageBuild), value); }

        [Offset(0UL)]
        public ulong CheckExecute { get => ReadHere<ulong>(nameof(CheckExecute)); set => WriteHere(nameof(CheckExecute), value); }

        [Offset(0UL)]
        public ulong ProtectedPagesEnabled { get => ReadHere<ulong>(nameof(ProtectedPagesEnabled)); set => WriteHere(nameof(ProtectedPagesEnabled), value); }

        [Offset(0UL)]
        public ulong SecureRelocations { get => ReadHere<ulong>(nameof(SecureRelocations)); set => WriteHere(nameof(SecureRelocations), value); }

        [Offset(0UL)]
        public ulong StrongPageIdentity { get => ReadHere<ulong>(nameof(StrongPageIdentity)); set => WriteHere(nameof(StrongPageIdentity), value); }

        [Offset(0UL)]
        public ulong StrongCodeGuarantees { get => ReadHere<ulong>(nameof(StrongCodeGuarantees)); set => WriteHere(nameof(StrongCodeGuarantees), value); }

        [Offset(0UL)]
        public ulong HardCodeGuarantees { get => ReadHere<ulong>(nameof(HardCodeGuarantees)); set => WriteHere(nameof(HardCodeGuarantees), value); }

        [Offset(0UL)]
        public ulong ExecutePagePrivilegeRequired { get => ReadHere<ulong>(nameof(ExecutePagePrivilegeRequired)); set => WriteHere(nameof(ExecutePagePrivilegeRequired), value); }

        [Offset(0UL)]
        public ulong SecureKernelCfgEnabled { get => ReadHere<ulong>(nameof(SecureKernelCfgEnabled)); set => WriteHere(nameof(SecureKernelCfgEnabled), value); }

        [Offset(0UL)]
        public ulong FullHvci { get => ReadHere<ulong>(nameof(FullHvci)); set => WriteHere(nameof(FullHvci), value); }

        [Offset(0UL)]
        public ulong BootDebuggerActive { get => ReadHere<ulong>(nameof(BootDebuggerActive)); set => WriteHere(nameof(BootDebuggerActive), value); }

        [Offset(0UL)]
        public ulong KvaShadow { get => ReadHere<ulong>(nameof(KvaShadow)); set => WriteHere(nameof(KvaShadow), value); }

        [Offset(0UL)]
        public ulong ExceptionHandlingReady { get => ReadHere<ulong>(nameof(ExceptionHandlingReady)); set => WriteHere(nameof(ExceptionHandlingReady), value); }

        [Offset(0UL)]
        public ulong ShadowStacksSupported { get => ReadHere<ulong>(nameof(ShadowStacksSupported)); set => WriteHere(nameof(ShadowStacksSupported), value); }

        [Offset(0UL)]
        public ulong AccessBitFenceRequired { get => ReadHere<ulong>(nameof(AccessBitFenceRequired)); set => WriteHere(nameof(AccessBitFenceRequired), value); }

        [Offset(0UL)]
        public ulong AccessBitReplacementCapability { get => ReadHere<ulong>(nameof(AccessBitReplacementCapability)); set => WriteHere(nameof(AccessBitReplacementCapability), value); }

        [Offset(0UL)]
        public ulong PfnDatabaseExists { get => ReadHere<ulong>(nameof(PfnDatabaseExists)); set => WriteHere(nameof(PfnDatabaseExists), value); }

        [Offset(0UL)]
        public ulong PfnDatabaseGapsFilled { get => ReadHere<ulong>(nameof(PfnDatabaseGapsFilled)); set => WriteHere(nameof(PfnDatabaseGapsFilled), value); }

        [Offset(0UL)]
        public ulong SystemPtesReady { get => ReadHere<ulong>(nameof(SystemPtesReady)); set => WriteHere(nameof(SystemPtesReady), value); }

        [Offset(0UL)]
        public ulong BootImageUnprivilegedPagesUnregistered { get => ReadHere<ulong>(nameof(BootImageUnprivilegedPagesUnregistered)); set => WriteHere(nameof(BootImageUnprivilegedPagesUnregistered), value); }

        [Offset(0UL)]
        public ulong ImageProtectedSlabExecutableOnly { get => ReadHere<ulong>(nameof(ImageProtectedSlabExecutableOnly)); set => WriteHere(nameof(ImageProtectedSlabExecutableOnly), value); }

        [Offset(0UL)]
        public ulong SpecialReadOnlyProtectedSlabPages { get => ReadHere<ulong>(nameof(SpecialReadOnlyProtectedSlabPages)); set => WriteHere(nameof(SpecialReadOnlyProtectedSlabPages), value); }

        [Offset(0UL)]
        public ulong SlabAllocatorsReady { get => ReadHere<ulong>(nameof(SlabAllocatorsReady)); set => WriteHere(nameof(SlabAllocatorsReady), value); }

        [Offset(0UL)]
        public ulong KasanEnabled { get => ReadHere<ulong>(nameof(KasanEnabled)); set => WriteHere(nameof(KasanEnabled), value); }

        [Offset(0UL)]
        public ulong HvptEnabled { get => ReadHere<ulong>(nameof(HvptEnabled)); set => WriteHere(nameof(HvptEnabled), value); }

        [Offset(0UL)]
        public ulong HvptVisible { get => ReadHere<ulong>(nameof(HvptVisible)); set => WriteHere(nameof(HvptVisible), value); }

        [Offset(0UL)]
        public ulong ProcessorsConfigured { get => ReadHere<ulong>(nameof(ProcessorsConfigured)); set => WriteHere(nameof(ProcessorsConfigured), value); }

        [Offset(0UL)]
        public ulong GlobalBitsInitialized { get => ReadHere<ulong>(nameof(GlobalBitsInitialized)); set => WriteHere(nameof(GlobalBitsInitialized), value); }

        [Offset(0UL)]
        public ulong GlobalBitsChanging { get => ReadHere<ulong>(nameof(GlobalBitsChanging)); set => WriteHere(nameof(GlobalBitsChanging), value); }

        [Offset(0UL)]
        public ulong ProcessorSupportsShadowStacks { get => ReadHere<ulong>(nameof(ProcessorSupportsShadowStacks)); set => WriteHere(nameof(ProcessorSupportsShadowStacks), value); }

        [Offset(0UL)]
        public ulong EntireField { get => ReadHere<ulong>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        public MiFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiFlags>();
        }
    }
}