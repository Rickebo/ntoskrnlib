using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LDR_DATA_TABLE_ENTRY")]
    public sealed class _LDR_DATA_TABLE_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY InLoadOrderLinks { get; }
        public _LIST_ENTRY InMemoryOrderLinks { get; }
        public _LIST_ENTRY InInitializationOrderLinks { get; }
        public IntPtr DllBase { get; }
        public IntPtr EntryPoint { get; }
        public uint SizeOfImage { get; }
        public _UNICODE_STRING FullDllName { get; }
        public _UNICODE_STRING BaseDllName { get; }
        public byte[] FlagGroup { get; }
        public uint Flags { get; }
        public uint PackagedBinary { get; }
        public uint MarkedForRemoval { get; }
        public uint ImageDll { get; }
        public uint LoadNotificationsSent { get; }
        public uint TelemetryEntryProcessed { get; }
        public uint ProcessStaticImport { get; }
        public uint InLegacyLists { get; }
        public uint InIndexes { get; }
        public uint ShimDll { get; }
        public uint InExceptionTable { get; }
        public uint VerifierProvider { get; }
        public uint ShimEngineCalloutSent { get; }
        public uint LoadInProgress { get; }
        public uint LoadConfigProcessed { get; }
        public uint EntryProcessed { get; }
        public uint ProtectDelayLoad { get; }
        public uint AuxIatCopyPrivate { get; }
        public uint ReservedFlags3 { get; }
        public uint DontCallForThreads { get; }
        public uint ProcessAttachCalled { get; }
        public uint ProcessAttachFailed { get; }
        public uint ScpInExceptionTable { get; }
        public uint CorImage { get; }
        public uint DontRelocate { get; }
        public uint CorILOnly { get; }
        public uint ChpeImage { get; }
        public uint ChpeEmulatorImage { get; }
        public uint ReservedFlags5 { get; }
        public uint Redirected { get; }
        public uint ReservedFlags6 { get; }
        public uint CompatDatabaseProcessed { get; }
        public ushort ObsoleteLoadCount { get; }
        public ushort TlsIndex { get; }
        public _LIST_ENTRY HashLinks { get; }
        public uint TimeDateStamp { get; }
        public IntPtr EntryPointActivationContext { get; }
        public IntPtr Lock { get; }
        public IntPtr DdagNode { get; }
        public _LIST_ENTRY NodeModuleLink { get; }
        public IntPtr LoadContext { get; }
        public IntPtr ParentDllBase { get; }
        public IntPtr SwitchBackContext { get; }
        public _RTL_BALANCED_NODE BaseAddressIndexNode { get; }
        public _RTL_BALANCED_NODE MappingInfoIndexNode { get; }
        public ulong OriginalBase { get; }
        public _LARGE_INTEGER LoadTime { get; }
        public uint BaseNameHashValue { get; }
        public uint LoadReason { get; }
        public uint ImplicitPathOptions { get; }
        public uint ReferenceCount { get; }
        public uint DependentLoadFlags { get; }
        public byte SigningLevel { get; }
        public uint CheckSum { get; }
        public IntPtr ActivePatchImageBase { get; }
        public uint HotPatchState { get; }

        public _LDR_DATA_TABLE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LDR_DATA_TABLE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.InLoadOrderLinks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.InMemoryOrderLinks),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.InInitializationOrderLinks),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.DllBase),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.EntryPoint),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.SizeOfImage),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.FullDllName),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.BaseDllName),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.FlagGroup),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.Flags),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.PackagedBinary),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.MarkedForRemoval),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ImageDll),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.LoadNotificationsSent),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.TelemetryEntryProcessed),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ProcessStaticImport),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.InLegacyLists),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.InIndexes),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ShimDll),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.InExceptionTable),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.VerifierProvider),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ShimEngineCalloutSent),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.LoadInProgress),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.LoadConfigProcessed),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.EntryProcessed),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ProtectDelayLoad),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.AuxIatCopyPrivate),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ReservedFlags3),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.DontCallForThreads),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ProcessAttachCalled),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ProcessAttachFailed),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ScpInExceptionTable),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.CorImage),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.DontRelocate),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.CorILOnly),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ChpeImage),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ChpeEmulatorImage),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ReservedFlags5),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.Redirected),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ReservedFlags6),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.CompatDatabaseProcessed),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ObsoleteLoadCount),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.TlsIndex),
                    new ulong[]
                    {
                        110UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.HashLinks),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.TimeDateStamp),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.EntryPointActivationContext),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.Lock),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.DdagNode),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.NodeModuleLink),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.LoadContext),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ParentDllBase),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.SwitchBackContext),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.BaseAddressIndexNode),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.MappingInfoIndexNode),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.OriginalBase),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.LoadTime),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.BaseNameHashValue),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.LoadReason),
                    new ulong[]
                    {
                        268UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ImplicitPathOptions),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ReferenceCount),
                    new ulong[]
                    {
                        276UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.DependentLoadFlags),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.SigningLevel),
                    new ulong[]
                    {
                        284UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.CheckSum),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.ActivePatchImageBase),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_LDR_DATA_TABLE_ENTRY.HotPatchState),
                    new ulong[]
                    {
                        304UL
                    }
                }
            };
            Register<_LDR_DATA_TABLE_ENTRY>((mem, ptr) => new _LDR_DATA_TABLE_ENTRY(mem, ptr), offsets);
        }
    }
}