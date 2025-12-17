#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 624)]
    public partial struct _SILO_USER_SHARED_DATA
    {
        [FieldOffset(0)]
        public uint ServiceSessionId;
        [FieldOffset(4)]
        public uint ActiveConsoleId;
        [FieldOffset(8)]
        public long ConsoleSessionForegroundProcessId;
        [FieldOffset(16)]
        public uint NtProductType;
        [FieldOffset(20)]
        public uint SuiteMask;
        [FieldOffset(24)]
        public uint SharedUserSessionId;
        [FieldOffset(28)]
        public byte IsMultiSessionSku;
        [FieldOffset(29)]
        public byte IsStateSeparationEnabled;
        [FieldOffset(30)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        public short[] NtSystemRoot;
        [FieldOffset(550)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] UserModeGlobalLogger;
        [FieldOffset(584)]
        public uint TimeZoneId;
        [FieldOffset(588)]
        public int TimeZoneBiasStamp;
        [FieldOffset(592)]
        public _KSYSTEM_TIME TimeZoneBias;
        [FieldOffset(608)]
        public _LARGE_INTEGER TimeZoneBiasEffectiveStart;
        [FieldOffset(616)]
        public _LARGE_INTEGER TimeZoneBiasEffectiveEnd;
    }
}