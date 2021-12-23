using ResumeApi.model;

namespace ResumeApi.path
{
    public class Project
    {
        public List<modProject> GetProject()
        {
            List<modProject> projects = new List<modProject>();

            var project = new modProject();
            project.title = "Some Project";
            project.description = "Blah Blah Blah";
            project.github = "blah/github.com";

            projects.Add(project);

            return projects;
        }

        public modProject GetProject(Guid id)
        {
            var project = new modProject();
            project.title = "Some Project";
            project.description = "Blah Blah Blah";
            project.github = "blah/github.com";

            return project;
        }
    }
}
