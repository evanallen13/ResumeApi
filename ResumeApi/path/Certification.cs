using ResumeApi.model;

namespace ResumeApi.src
{
    public class Certification
    {
        public List<modCertification>? GetCerts()
        {
            var certifications = new List<modCertification>();

            modCertification cert = new modCertification();
            cert.title = "Az-204 Azure Developer Associate";

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
