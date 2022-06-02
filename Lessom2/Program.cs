class Programm
{
    static void Main(string[] args)
    {
        string surname = "Петров", name = "Василий", patronymic = "Семёнович";
        int age = 19;
        string email = "ya@ya.ru";
        int gradeCoding = 46, gradeMath = 57, gradePhysic = 45;
        string pattern = "Фамилия:\t{0}\nИмя:\t\t{1}\nОтчество:\t{2}\nВозраст:\t{3}\nEMail:\t\t{4}\n\nБаллы по программированию:\t {5:f2}\nБаллы по математике:\t\t {6:f2}\nБаллы по физике:\t\t {7:f2}\nСредний балл:\t\t\t {8:f2}\nСуммарный балл:\t\t\t{9:f2}";
        int summGrade = gradePhysic + gradeMath + gradeCoding;
        Console.ReadKey();
        Console.WriteLine(pattern,
                            surname,
                            name,
                            patronymic,
                            age,
                            email,
                            gradeCoding,
                            gradeMath,
                            gradePhysic,
                            summGrade / 3.0,
                            summGrade);
        Console.ReadKey();
    }
}