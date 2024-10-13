namespace WebMVCR1.Models
{
    public class ModelClass
    {
        public static string ModelHello()
        {
            int hour = DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день"; return Greeting;
        }


    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() => FirstName + " " +
       LastName;
    }






}
