namespace ChallengeApp_01
{
    public class Employee
    {

        private List<float> grades = new List<float>();

        // początek konstruktora
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        // koniec konstruktora

        // to jest propercja
        public string Name{ get; private set; }
        public string Surname { get; private set; }
        // koniec propercji


        // to jest metoda

        public void AddGrade(double grade)
        {
            // tutaj wykorzystuję mechanizm rzutowania jednej zmiennej w drugą
            // następuje zaokrąglenie do wartości całkowitej, np. 3.33 -> 3
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(long grade)
        {
            // tutaj wykorzystuję mechanizm rzutowania jednej zmiennej w drugą
            // następuje zaokrąglenie do wartości całkowitej, np. 3.33 -> 3
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(float grade)
        {
            // tutaj wykorzystuję mechanizm rzutowania jednej zmiennej w drugą
            // następuje zaokrąglenie do wartości całkowitej, np. 3.33 -> 3
            int valueInInt = (int)grade;
            
            // tutaj dodajemy walidację
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }
        // koniec metody     
        public void AddGrade(string grade)
        {
            // tutaj wykorzystamy metodę statyczną Parse zamiany stringa do floata
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not a float");
            }
        }

        // to jest nowa metoda, która wypełnia nasz Model Danych danymi
        public Statistics GetStatistics() 
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            { 
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }

    }
}
