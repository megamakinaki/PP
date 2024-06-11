using System;
using System.Collections.Generic;
class DailyPlanner
{
    static Dictionary<DateTime, List<string>> tasks = new Dictionary<DateTime, List<string>>();
    static void Main()
    {
        string choice;
        do
        {
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Редактировать задачу");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите действие: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ViewTasksForToday();
                    break;
                case "2":
                    AddTask();
                    break;
                case "3":
                    DeleteTask();
                    break;
                case "4":
                    EditTask();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Такого действия нет. Повторите попытку.");
                    break;
            }

        } while (choice != "5");
    }

    static void ViewTasksForToday()
    {
        DateTime today = DateTime.Today;

        if (tasks.ContainsKey(today))
        {
            Console.WriteLine($"Задачи на {today.ToShortDateString()}:");
            List<string> tasksForToday = tasks[today];
            for (int i = 0; i < tasksForToday.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasksForToday[i]}");
            }
        }
        else
        {
            Console.WriteLine("На сегодня задач нет.");
        }
    }

    static void AddTask()
    {
        Console.Write("Введите дату задачи (гггг-мм-дд): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.Write("Введите новую задачу: ");
        string newTask = Console.ReadLine();

        if (tasks.ContainsKey(date))
        {
            tasks[date].Add(newTask);
        }
        else
        {
            tasks[date] = new List<string>() { newTask };
        }

        Console.WriteLine("Задача успешно добавлена.");
    }

    static void DeleteTask()
    {
        ViewTasksForToday();
        Console.Write("Введите номер задачи для удаления: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        DateTime today = DateTime.Today;
        if (tasks.ContainsKey(today) && index >= 0 && index < tasks[today].Count)
        {
            tasks[today].RemoveAt(index);
            Console.WriteLine("Задача успешно удалена.");
        }
        else
        {
            Console.WriteLine("Некорректный номер задачи.");
        }
    }

    static void EditTask()
    {
        ViewTasksForToday();
        Console.Write("Введите номер задачи для редактирования: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        DateTime today = DateTime.Today;
        if (tasks.ContainsKey(today) && index >= 0 && index < tasks[today].Count)
        {
            Console.Write("Введите новое описание для задачи: ");
            tasks[today][index] = Console.ReadLine();
            Console.WriteLine("Задача успешно отредактирована.");
        }
        else
        {
            Console.WriteLine("Некорректный номер задачи.");
        }
    }
}