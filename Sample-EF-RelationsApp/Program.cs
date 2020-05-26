using System;

namespace Sample_EF_RelationsApp
{
    class Program
    {
    private static DemoDataContext db = new DemoDataContext();
        static void Main(string[] args)
        {
            CleanDatabase();
            AddPerson();
            AddCustomTask();

            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }

        private static void AddCustomTask()
        {
            CustomTask c = new CustomTask
            {
                TaskGuid = Guid.NewGuid(),
                TaskName = "Coding",
                TypeOfTask = TaskType.NonBillable
            };
            db.TastList.Add(c);
            db.SaveChanges();
        }

        private static void AddPerson()
        {
            Person p = new Person
            {
                BirthDate = DateTime.Now.AddYears(-45),
                Firstname = "Christian",
                Lastname = "Casutt",
                PersonGender = Gender.Male,
                PersonGuid = Guid.NewGuid()
            };
            db.PersonList.Add(p);
            db.SaveChanges();
            Console.WriteLine($"Person ({p.PersonGender}): {p.Lastname},{p.Firstname} " +
                $"born: {p.BirthDate} with GUID: {p.PersonGuid} added");

        }

        private static void CleanDatabase()
        {
            db.PersonList.RemoveRange(db.PersonList);
        }
    }
}
