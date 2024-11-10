namespace Tickets.Controllers
{
    public class Resume
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Min { get; set; }
        public int Age { get; set; }
        public int Heigth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string StudiesSubject { get; set; }
        public string EducationalInstitution { get; set; }




        public Resume()
        {

        }

        public Resume(int id, string name, string min, int age, int heigth, string phone, string address,  string studiesSubject, string educationalInstitution)
        {
            Id = id;
            Name = name;
            Min = min;
            Age = age;
            Heigth = heigth;
            Phone = phone;
            Address = address;
            StudiesSubject = studiesSubject;
            EducationalInstitution = educationalInstitution;
        }



    }


}
