using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Listing2_84_ImplementingIDisposableAndAFinalizer
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class UnmanagedWrapper : IDisposable
    {
        private IntPtr unmanagedBuffer;
        public FileStream Stream { get; set; }

        public UnmanagedWrapper()
        {
            CreateBuffer();
            this.Stream = File.Open("temp.dat", FileMode.Create);
        }

        private void CreateBuffer()
        {
            byte[] data = new byte[1024];
            new Random().NextBytes(data);
            unmanagedBuffer = Marshal.AllocHGlobal(data.Length);
            Marshal.Copy(data, 0, unmanagedBuffer, data.Length);
        }

        ~UnmanagedWrapper()
        {
            Dispose(false); 
        }

        public void Close()
        {
            Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            Marshal.FreeHGlobal(unmanagedBuffer);
            if (disposing)
            {
                if (Stream != null)
                {
                    Stream.Close();
                }
            }
        }
    }
}
