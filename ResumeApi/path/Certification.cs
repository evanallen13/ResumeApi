using ResumeApi.model;

namespace ResumeApi.src
{
    public class Certification
    {
        public List<modCertification>? GetCerts()
        {
            var certifications = new List<modCertification>();

            modCertification cert = new modCertification();
            cert.title = "Azure Developer Associate";
            cert.name = "Az-204";
            cert.imgageUrl = "url";
            cert.credentialUrl = "8439";

            certifications.Add(cert);

            return certifications;
        }

        public modCertification GetCert(int id)
        {
            var certifications = new List<modCertification>();

            modCertification cert = new modCertification();

            return cert;
        }

        public string SayHello()
        {
            string myString = Environment.GetEnvironmentVariable("hello") ?? "This is wrong";


            return myString;
        }
    }
}
