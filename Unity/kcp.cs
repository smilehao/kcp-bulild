namespace KCP
{
    using System;
    using System.Runtime.InteropServices;

    public class kcp
    {
#if UNITY_IPHONE && !UNITY_EDITOR
        const string KcpDLL = "__Internal";
#else
        const string KcpDLL = "kcp";
#endif

        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ikcp_check(IntPtr kcp, uint current);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern IntPtr ikcp_create(uint conv, IntPtr user);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern void ikcp_flush(IntPtr kcp);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern uint ikcp_getconv(IntPtr ptr);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern int ikcp_input(IntPtr kcp, byte[] data, long size);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern int ikcp_nodelay(IntPtr kcp, int nodelay, int interval, int resend, int nc);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern int ikcp_peeksize(IntPtr kcp);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern int ikcp_recv(IntPtr kcp, byte[] buffer, int len);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern void ikcp_release(IntPtr kcp);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern int ikcp_send(IntPtr kcp, byte[] buffer, int len);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern void ikcp_setminrto(IntPtr ptr, int minrto);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern int ikcp_setmtu(IntPtr kcp, int mtu);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern void ikcp_setoutput(IntPtr kcp, kcp_output output);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern void ikcp_update(IntPtr kcp, uint current);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern int ikcp_waitsnd(IntPtr kcp);
        [DllImport(KcpDLL, CallingConvention=CallingConvention.Cdecl)]
        public static extern int ikcp_wndsize(IntPtr kcp, int sndwnd, int rcvwnd);
    }
}

