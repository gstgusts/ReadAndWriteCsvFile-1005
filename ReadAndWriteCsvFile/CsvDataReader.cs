using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadAndWriteCsvFile
{
    public class CsvDataReader
    {
        private const string filePath = "data.csv";

        public List<Person> Load()
        {
            var lines = File.ReadAllLines(filePath);

            var list = new List<Person>();

            for (int i = 1; i < lines.Length; i++)
            {
                var dataLine = lines[i];
                var parts = dataLine.Split(";", StringSplitOptions.None);

                var person = new Person() { Name = parts[0], Surname = parts[1] };

                list.Add(person);

            }

            return list;
        }

        public void Save(List<Person> persons)
        {
            List<string> lines = new List<string>();
            lines.Add("name;surname");

            foreach (var person in persons)
            {
                lines.Add($"{person.Name};{person.Surname}");
            }

            File.WriteAllLines(filePath, lines);
        }
    }
}
