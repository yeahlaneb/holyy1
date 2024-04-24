using System;

interface ОсвітнійЗаклад
{
    int ВизначитиКількістьВикладачів();
    void PrintInfo();
}

abstract class НавчальнийЗаклад : ОсвітнійЗаклад
{
    protected int кількістьУчнів;

    public int КількістьУчнів
    {
        get { return кількістьУчнів; }
        protected set { кількістьУчнів = value; }
    }

    public НавчальнийЗаклад(int кількістьУчнів)
    {
        КількістьУчнів = кількістьУчнів;
    }

    public abstract int ВизначитиКількістьВикладачів();
    public abstract void PrintInfo();
}

class Школа : НавчальнийЗаклад
{
    private int кількістьКласів;

    public Школа(int кількістьУчнів, int кількістьКласів) : base(кількістьУчнів)
    {
        this.кількістьКласів = кількістьКласів;
    }

    public override int ВизначитиКількістьВикладачів()
    {
        return кількістьКласів * 2; // Логіка для визначення кількості викладачів у школі
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Shkola mae {КількістьУчнів} uchniv ta {кількістьКласів} clasiv.");
    }
}

class Університет : НавчальнийЗаклад
{
    private int кількістьФакультетів;

    // Властивість для доступу до кількості факультетів
    public int КількістьФакультетів
    {
        get { return кількістьФакультетів; }
        set { кількістьФакультетів = value; }
    }

    // Конструктор, який приймає кількість учнів та кількість факультетів
    public Університет(int кількістьУчнів, int кількістьФакультетів) : base(кількістьУчнів)
    {
        КількістьФакультетів = кількістьФакультетів;
    }

    // Реалізує метод для визначення кількості викладачів у університеті
    public override int ВизначитиКількістьВикладачів()
    {
        return КількістьФакультетів * 10; // Логіка для визначення кількості викладачів в університеті
    }

    // Реалізує метод для виведення інформації про університет
    public override void PrintInfo()
    {
        Console.WriteLine($"Universitet mae {КількістьУчнів} uchniv ta {КількістьФакультетів} fakultetiv.");
    }

    // Додаємо метод для виведення кількості факультетів на екран
    public void PrintFacultyCount()
    {
        Console.WriteLine($"Universitet mae {КількістьФакультетів} fakultetiv.");
    }
}



class Факультет : НавчальнийЗаклад
{
    private int рікЗаснування;

    public Факультет(int кількістьУчнів, int рікЗаснування) : base(кількістьУчнів)
    {
        this.рікЗаснування = рікЗаснування;
    }

    public override int ВизначитиКількістьВикладачів()
    {
        return 20; // Логіка для визначення кількості викладачів у факультеті
    }

    public int ВизначитиРікЗаснування()
    {
        return рікЗаснування;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Fakultet mae {кількістьУчнів} uchniv. Rik zasnuvannya: {рікЗаснування}.");
    }
}

class Кафедра : НавчальнийЗаклад
{
    public Кафедра(int кількістьУчнів) : base(кількістьУчнів)
    {
    }

    public override int ВизначитиКількістьВикладачів()
    {
        return 10; // Логіка для визначення кількості викладачів на кафедрі
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Kafedra mae {кількістьУчнів} uchniv.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Школа школа = new Школа(200, 10);
        школа.PrintInfo();
        Console.WriteLine($"Kilkist vikladachiv v shkoli: {школа.ВизначитиКількістьВикладачів()}");
        Console.WriteLine();

        Університет університет = new Університет(3000, 10);
        університет.PrintInfo();
        Console.WriteLine($"Kilkist vikladachiv v universiteti: {університет.ВизначитиКількістьВикладачів()}");
        Console.WriteLine();

        Факультет факультет = new Факультет(1000, 1985);
        факультет.PrintInfo();
        Console.WriteLine($"Kilkist vikladachiv na fakulteti: {факультет.ВизначитиКількістьВикладачів()}");
        Console.WriteLine();

        Кафедра кафедра = new Кафедра(300);
        кафедра.PrintInfo();
        Console.WriteLine($"Kilkist vikladachiv na kafedri: {кафедра.ВизначитиКількістьВикладачів()}");
    }
}
