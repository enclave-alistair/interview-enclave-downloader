using System;
using System.IO;
using System.Net;
using System.Text;

namespace EnclaveDownloader
{
    class Program
    {
        const string ManifestUrl = "https://dl.enclave.io/tech-test-linux-manifest.json";

        static void Main(string[] args)
        {
            Console.Write("Downloading Manifest...");

            var manifestContent = DownloadString(ManifestUrl);

            // TODO: Parse manifest into a Manifest instance.
            //       Download all the files simultaneously and verify their hashes before copying to the current folder.
            //       Return a non-zero exit codes if any of the files are invalid.
        }

        /// <summary>
        /// Download a file and get a string.
        /// </summary>
        public static string DownloadString(string url)
        {
            return Encoding.ASCII.GetString(Download(url));
        }

        /// <summary>
        /// Download a file and get bytes.
        /// </summary>
        public static byte[] Download(string url)
        {
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var stream = (response as HttpWebResponse)?.GetResponseStream() ?? throw new InvalidOperationException();

            var buffer = new byte[256];
            using (var memoryStream = new MemoryStream())
            {
                int bytesRead;
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    memoryStream.Write(buffer, 0, bytesRead);
                }

                return memoryStream.ToArray();
            }
        }
    }
}
