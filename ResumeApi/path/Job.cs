using ResumeApi.model;

namespace ResumeApi.path
{
    public class Job
    {
        public List<modJob>? GetJobs()
        {
            List<modJob> jobs = new List<modJob>();

            var job = new modJob();
            job.company = "Mainfreight";
            job.title = "Full Stack Software Engineer";
            job.description = "Blah Blah Blah";

            jobs.Add(job);

            return jobs;
        }

        public modJob GetJobs(Guid id)
        {
            var job = new modJob();
            job.company = "Mainfreight";
            job.title = "Full Stack Software Engineer";
            job.description = "Blah Blah Blah";

            return job;
        }
    }
}
