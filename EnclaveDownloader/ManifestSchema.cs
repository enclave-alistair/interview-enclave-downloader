using System.Collections.Generic;

namespace EnclaveDownloader
{
    public class Manifest
    {
        public string ProductName { get; set; }

        public string DocumentHash { get; set; }

        public string DocumentSignature { get; set; }

        public long TimeToLive { get; set; }

        public List<ReleaseVersion> ReleaseVersions { get; set; }
    }

    public class ReleaseVersion
    {
        public long MajorVersion { get; set; }

        public long MinorVersion { get; set; }

        public long BuildVersion { get; set; }

        public long RevisionVersion { get; set; }

        public string ReleaseType { get; set; }

        public long ReleaseDate { get; set; }
        
        public long HardStop { get; set; }

        public string TargetEnvironment { get; set; }

        public List<Package> Packages { get; set; }

        public string ReleaseNotes { get; set; }
    }

    public class Package
    {
        public string Platform { get; set; }

        public string Architecture { get; set; }

        public string Uri { get; set; }

        public string Hash { get; set; }

        public string HashAlg { get; set; }
    }
}
