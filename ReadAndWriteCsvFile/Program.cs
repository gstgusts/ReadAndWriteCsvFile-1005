using System;

namespace ReadAndWriteCsvFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //var reader = new CsvDataReader();
            var reader = new CsvDataReaderFromNuget();

            var result = reader.Load();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} {item.Surname}");
            }

            result.Add(new Person() { Name = "Baiba", Surname = "Liepa" });
            result.Add(new Person() { Name = "Baiba1", Surname = "Liepa1" });
            result.Add(new Person() { Name = "Baiba2", Surname = "Liepa2" });

            reader.Save(result);

            Console.ReadLine();
        }
    }
}
