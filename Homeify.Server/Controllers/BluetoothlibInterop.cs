using System;
using System.Runtime.InteropServices;

namespace Homeify.Server.Controllers
{
    public class BluetoothlibInterop
    {
        [DllImport("libbluetooth.so.3")]
        private static extern int hci_inquiry(int deviceId, int inquiryLength, int maxResponsesCount, object kA, InquiryItem[] inquiryItems, int flags);

        [DllImport("libbluetooth.so.3")]
        private static extern int hci_get_route(byte[] btAddr);

        [DllImport("libbluetooth.so.3")]
        private static extern int hci_open_dev(int deviceId);

        public void ListDevices()
        {
            var deviceId = hci_get_route(null);
            var socket = hci_open_dev(deviceId);
            var maxResponsesCount = 255;
            var inquiryItems = new InquiryItem[maxResponsesCount];
            var deviceCount = hci_inquiry(deviceId, 8, maxResponsesCount, null, inquiryItems, 0x0001);
            Console.WriteLine(deviceCount);
        }

        [StructLayout(LayoutKind.Sequential, Size=6)]
        private struct InquiryItem
        {
            private byte[] bdAddr;
            private byte repetitionMode;
            private byte periodMode;
            private byte mode;
            private uint deviceClass;
            private char clockOffset;
        }
    }
}