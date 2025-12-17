#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MI_FLAGS
    {
        [FieldOffset(0)]
        public ulong VerifierEnabled;
        [FieldOffset(0)]
        public ulong KernelVerifierEnabled;
        [FieldOffset(0)]
        public ulong LargePageKernel;
        [FieldOffset(0)]
        public ulong StopOn4d;
        [FieldOffset(0)]
        public ulong InitializationPhase;
        [FieldOffset(0)]
        public ulong PageKernelStacks;
        [FieldOffset(0)]
        public ulong CheckZeroPages;
        [FieldOffset(0)]
        public ulong ProcessorPrewalks;
        [FieldOffset(0)]
        public ulong ProcessorPostwalks;
        [FieldOffset(0)]
        public ulong CoverageBuild;
        [FieldOffset(0)]
        public ulong CheckExecute;
        [FieldOffset(0)]
        public ulong ProtectedPagesEnabled;
        [FieldOffset(0)]
        public ulong SecureRelocations;
        [FieldOffset(0)]
        public ulong StrongPageIdentity;
        [FieldOffset(0)]
        public ulong StrongCodeGuarantees;
        [FieldOffset(0)]
        public ulong HardCodeGuarantees;
        [FieldOffset(0)]
        public ulong ExecutePagePrivilegeRequired;
        [FieldOffset(0)]
        public ulong SecureKernelCfgEnabled;
        [FieldOffset(0)]
        public ulong FullHvci;
        [FieldOffset(0)]
        public ulong BootDebuggerActive;
        [FieldOffset(0)]
        public ulong KvaShadow;
        [FieldOffset(0)]
        public ulong ExceptionHandlingReady;
        [FieldOffset(0)]
        public ulong ShadowStacksSupported;
        [FieldOffset(0)]
        public ulong AccessBitFenceRequired;
        [FieldOffset(0)]
        public ulong AccessBitReplacementCapability;
        [FieldOffset(0)]
        public ulong PfnDatabaseExists;
        [FieldOffset(0)]
        public ulong PfnDatabaseGapsFilled;
        [FieldOffset(0)]
        public ulong SystemPtesReady;
        [FieldOffset(0)]
        public ulong BootImageUnprivilegedPagesUnregistered;
        [FieldOffset(0)]
        public ulong ImageProtectedSlabExecutableOnly;
        [FieldOffset(0)]
        public ulong SpecialReadOnlyProtectedSlabPages;
        [FieldOffset(0)]
        public ulong SlabAllocatorsReady;
        [FieldOffset(0)]
        public ulong KasanEnabled;
        [FieldOffset(0)]
        public ulong HvptEnabled;
        [FieldOffset(0)]
        public ulong HvptVisible;
        [FieldOffset(0)]
        public ulong ProcessorsConfigured;
        [FieldOffset(0)]
        public ulong GlobalBitsInitialized;
        [FieldOffset(0)]
        public ulong GlobalBitsChanging;
        [FieldOffset(0)]
        public ulong ProcessorSupportsShadowStacks;
        [FieldOffset(0)]
        public ulong EntireField;
    }
}