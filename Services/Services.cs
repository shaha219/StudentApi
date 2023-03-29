using StudentApi.Models;

namespace StudentApi.Services;

public static class StudentService
{
    static List<Student> Students { get; }
    static StudentService()
    {
        Students = new List<Student>
        {
            new Student {
                Id = 1,
                Name = "Leanne Graham",
                Gender = "Male",
                Email = "Sincere@april.biz",
                Phone = "7073156442",
                Address = "hildegard.org",
                Dob = "11.12.1971"
            },
            new Student {
                Id = 2,
                Name = "Ervin Howell",
                Gender = "Male",
                Email = "Shanna@melissa.tv",
                Phone = "81659309125",
                Address = "anastasia.net",
                Dob = "05.01.1995"
            },
            new Student {
                Id = 3,
                Name = "Clementine Bauch",
                Gender = "Female",
                Email = "Nathan@yesenia.net",
                Phone = "9146313444",
                Address = "ramiro.info",
                Dob = "03.10.2000"
            },
            new Student {
                Id = 4,
                Name = "Patricia Lebsack A",
                Gender = "Female",
                Email = "Julianne.O@kory.org",
                Phone = "7931709623",
                Address = "kale.biz",
                Dob = "13.05.2002"
            },
            new Student {
                Id = 5,
                Name = "Chelsey Dietrich",
                Gender = "Female",
                Email = "Lucio_Hettinger@annie.ca",
                Phone = "2549541289",
                Address = "demarco.info",
                Dob = "29.02.1994"
            },
            new Student {
                Id = 6,
                Name = "Mrs. Dennis Schulist",
                Gender = "Male",
                Email = "Karley_Dach@jasper.info",
                Phone = "84779358478",
                Address = "ola.org",
                Dob = "05.01.1995"
            },
            new Student {
                Id = 7,
                Name = "Kurtis Weissnat",
                Gender = "Male",
                Email = "Telly.Hoeger@billy.biz",
                Phone = "9849541289",
                Address = "elvis.io",
                Dob = "17.10.1998"
            },
            new Student {
                Id = 8,
                Name = "Nicholas Runolfsdottir V",
                Gender = "Male",
                Email = "Sherwood@rosamond.me",
                Phone = "9875641320",
                Address = "jacynthe.com",
                Dob = "06.10.2006"
            },
            new Student {
                Id = 9,
                Name = "Glenna Reichert",
                Gender = "Male",
                Email = "Chaim_Dermott@dana.io",
                Phone = "94379358471",
                Address = "conrad.com",
                Dob = "14.04.2003"
            },
            new Student {
                Id = 10,
                Name = "Clementina DuBuque",
                Gender = "Female",
                Email = "Rey.Padberg@karina.biz",
                Phone = "78751124369",
                Address = "ambrose.net",
                Dob = "06.04.2001"
            }
        };
    }

    public static List<Student> GetAll() => Students;

    public static Student? Get(int id) => Students.FirstOrDefault(p => p.Id == id);

    public static void Add(Student student)
    {
        student.Id = Students.Count+1;
        Students.Add(student);
    }

    public static void Delete(int id)
    {
        var student = Get(id);
        if(student is null)
            return;

        Students.Remove(student);
    }

    public static void Update(Student student)
    {
        var index = Students.FindIndex(p => p.Id == student.Id);
        if(index == -1)
            return;

        Students[index] = student;
    }
}