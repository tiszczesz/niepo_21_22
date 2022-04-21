namespace WebWithForms.Models
{
    public class MyLogger
    {
        public static void SaveFile(Candidate candidate=null) {
            string data = candidate == null ? "" : $"{candidate.Firstname};{candidate.Lastname};{candidate.Division}";
            using (StreamWriter file = new StreamWriter("logger.txt",append:true)) {
                file.WriteLine($"Nowe zmiany: {DateTime.Now.ToShortDateString()}: {DateTime.Now.ToLongTimeString()}:  {data}");
            }
        }
    }
}
