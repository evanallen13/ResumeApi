using ResumeApi.model;

namespace ResumeApi.path
{
    public class Education
    {
        public List<modEducation> GetEducation()
        {
            List<modEducation> educations = new List<modEducation>();

            var education = new modEducation();
            education.Id = Guid.NewGuid();
            education.school = "Califoria State Univeristy, Long Beach";
            education.degree = "Bachelors of Businesss Administration - Information Systems";
            education.startDate = DateTime.Parse("01/15/2018");

            educations.Add(education);

            return educations;
        }

        public modEducation GetEducation(Guid? id)
        {
            var education = new modEducation();
            education.Id = Guid.NewGuid();
            education.school = "Califoria State Univeristy, Long Beach";
            education.degree = "Bachelors of Businesss Administration - Information Systems";
            education.startDate = DateTime.Parse("01/15/2018");

            return education;
        }
    }
}
