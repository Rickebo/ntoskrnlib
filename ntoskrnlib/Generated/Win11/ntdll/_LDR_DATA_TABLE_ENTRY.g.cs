#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 312)]
    public partial struct _LDR_DATA_TABLE_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY InLoadOrderLinks;
        [FieldOffset(16)]
        public _LIST_ENTRY InMemoryOrderLinks;
        [FieldOffset(32)]
        public _LIST_ENTRY InInitializationOrderLinks;
        [FieldOffset(48)]
        public IntPtr DllBase;
        [FieldOffset(56)]
        public IntPtr EntryPoint;
        [FieldOffset(64)]
        public uint SizeOfImage;
        [FieldOffset(72)]
        public _UNICODE_STRING FullDllName;
        [FieldOffset(88)]
        public _UNICODE_STRING BaseDllName;
        [FieldOffset(104)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] FlagGroup;
        [FieldOffset(104)]
        public uint Flags;
        [FieldOffset(104)]
        public uint PackagedBinary;
        [FieldOffset(104)]
        public uint MarkedForRemoval;
        [FieldOffset(104)]
        public uint ImageDll;
        [FieldOffset(104)]
        public uint LoadNotificationsSent;
        [FieldOffset(104)]
        public uint TelemetryEntryProcessed;
        [FieldOffset(104)]
        public uint ProcessStaticImport;
        [FieldOffset(104)]
        public uint InLegacyLists;
        [FieldOffset(104)]
        public uint InIndexes;
        [FieldOffset(104)]
        public uint ShimDll;
        [FieldOffset(104)]
        public uint InExceptionTable;
        [FieldOffset(104)]
        public uint VerifierProvider;
        [FieldOffset(104)]
        public uint ShimEngineCalloutSent;
        [FieldOffset(104)]
        public uint LoadInProgress;
        [FieldOffset(104)]
        public uint LoadConfigProcessed;
        [FieldOffset(104)]
        public uint EntryProcessed;
        [FieldOffset(104)]
        public uint ProtectDelayLoad;
        [FieldOffset(104)]
        public uint AuxIatCopyPrivate;
        [FieldOffset(104)]
        public uint ReservedFlags3;
        [FieldOffset(104)]
        public uint DontCallForThreads;
        [FieldOffset(104)]
        public uint ProcessAttachCalled;
        [FieldOffset(104)]
        public uint ProcessAttachFailed;
        [FieldOffset(104)]
        public uint ScpInExceptionTable;
        [FieldOffset(104)]
        public uint CorImage;
        [FieldOffset(104)]
        public uint DontRelocate;
        [FieldOffset(104)]
        public uint CorILOnly;
        [FieldOffset(104)]
        public uint ChpeImage;
        [FieldOffset(104)]
        public uint ChpeEmulatorImage;
        [FieldOffset(104)]
        public uint ReservedFlags5;
        [FieldOffset(104)]
        public uint Redirected;
        [FieldOffset(104)]
        public uint ReservedFlags6;
        [FieldOffset(104)]
        public uint CompatDatabaseProcessed;
        [FieldOffset(108)]
        public ushort ObsoleteLoadCount;
        [FieldOffset(110)]
        public ushort TlsIndex;
        [FieldOffset(112)]
        public _LIST_ENTRY HashLinks;
        [FieldOffset(128)]
        public uint TimeDateStamp;
        [FieldOffset(136)]
        public IntPtr EntryPointActivationContext;
        [FieldOffset(144)]
        public IntPtr Lock;
        [FieldOffset(152)]
        public IntPtr DdagNode;
        [FieldOffset(160)]
        public _LIST_ENTRY NodeModuleLink;
        [FieldOffset(176)]
        public IntPtr LoadContext;
        [FieldOffset(184)]
        public IntPtr ParentDllBase;
        [FieldOffset(192)]
        public IntPtr SwitchBackContext;
        [FieldOffset(200)]
        public _RTL_BALANCED_NODE BaseAddressIndexNode;
        [FieldOffset(224)]
        public _RTL_BALANCED_NODE MappingInfoIndexNode;
        [FieldOffset(248)]
        public ulong OriginalBase;
        [FieldOffset(256)]
        public _LARGE_INTEGER LoadTime;
        [FieldOffset(264)]
        public uint BaseNameHashValue;
        [FieldOffset(268)]
        public uint LoadReason;
        [FieldOffset(272)]
        public uint ImplicitPathOptions;
        [FieldOffset(276)]
        public uint ReferenceCount;
        [FieldOffset(280)]
        public uint DependentLoadFlags;
        [FieldOffset(284)]
        public byte SigningLevel;
        [FieldOffset(288)]
        public uint CheckSum;
        [FieldOffset(296)]
        public IntPtr ActivePatchImageBase;
        [FieldOffset(304)]
        public uint HotPatchState;
    }
}