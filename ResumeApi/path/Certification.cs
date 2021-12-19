using ResumeApi.model;

namespace ResumeApi.src
{
    public class Certification
    {
        public List<modCertification>? GetCerts()
        {
            var certifications = new List<modCertification>();

            modCertification cert = new modCertification();
            cert.name = "Az-204";

            certifications.Add(cert);

            return certifications;
        }

        public modCertification GetCert(int id)
        {
            var certifications = new List<modCertification>();

            modCertification cert = new modCertification();

            return cert;
        }
    }
}
