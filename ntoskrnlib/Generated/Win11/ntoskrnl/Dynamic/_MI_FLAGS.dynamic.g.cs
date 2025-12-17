using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_FLAGS")]
    public sealed class _MI_FLAGS : DynamicStructure
    {
        public ulong VerifierEnabled { get; }
        public ulong KernelVerifierEnabled { get; }
        public ulong LargePageKernel { get; }
        public ulong StopOn4d { get; }
        public ulong InitializationPhase { get; }
        public ulong PageKernelStacks { get; }
        public ulong CheckZeroPages { get; }
        public ulong ProcessorPrewalks { get; }
        public ulong ProcessorPostwalks { get; }
        public ulong CoverageBuild { get; }
        public ulong CheckExecute { get; }
        public ulong ProtectedPagesEnabled { get; }
        public ulong SecureRelocations { get; }
        public ulong StrongPageIdentity { get; }
        public ulong StrongCodeGuarantees { get; }
        public ulong HardCodeGuarantees { get; }
        public ulong ExecutePagePrivilegeRequired { get; }
        public ulong SecureKernelCfgEnabled { get; }
        public ulong FullHvci { get; }
        public ulong BootDebuggerActive { get; }
        public ulong KvaShadow { get; }
        public ulong ExceptionHandlingReady { get; }
        public ulong ShadowStacksSupported { get; }
        public ulong AccessBitFenceRequired { get; }
        public ulong AccessBitReplacementCapability { get; }
        public ulong PfnDatabaseExists { get; }
        public ulong PfnDatabaseGapsFilled { get; }
        public ulong SystemPtesReady { get; }
        public ulong BootImageUnprivilegedPagesUnregistered { get; }
        public ulong ImageProtectedSlabExecutableOnly { get; }
        public ulong SpecialReadOnlyProtectedSlabPages { get; }
        public ulong SlabAllocatorsReady { get; }
        public ulong KasanEnabled { get; }
        public ulong HvptEnabled { get; }
        public ulong HvptVisible { get; }
        public ulong ProcessorsConfigured { get; }
        public ulong GlobalBitsInitialized { get; }
        public ulong GlobalBitsChanging { get; }
        public ulong ProcessorSupportsShadowStacks { get; }
        public ulong EntireField { get; }

        public _MI_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_FLAGS.VerifierEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.KernelVerifierEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.LargePageKernel),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.StopOn4d),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.InitializationPhase),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.PageKernelStacks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.CheckZeroPages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.ProcessorPrewalks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.ProcessorPostwalks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.CoverageBuild),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.CheckExecute),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.ProtectedPagesEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.SecureRelocations),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.StrongPageIdentity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.StrongCodeGuarantees),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.HardCodeGuarantees),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.ExecutePagePrivilegeRequired),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.SecureKernelCfgEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.FullHvci),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.BootDebuggerActive),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.KvaShadow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.ExceptionHandlingReady),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.ShadowStacksSupported),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.AccessBitFenceRequired),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.AccessBitReplacementCapability),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.PfnDatabaseExists),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.PfnDatabaseGapsFilled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.SystemPtesReady),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.BootImageUnprivilegedPagesUnregistered),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.ImageProtectedSlabExecutableOnly),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.SpecialReadOnlyProtectedSlabPages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.SlabAllocatorsReady),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.KasanEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.HvptEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.HvptVisible),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.ProcessorsConfigured),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.GlobalBitsInitialized),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.GlobalBitsChanging),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.ProcessorSupportsShadowStacks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_FLAGS.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_FLAGS>((mem, ptr) => new _MI_FLAGS(mem, ptr), offsets);
        }
    }
}