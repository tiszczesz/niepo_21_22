using System.Text;

namespace MVCFormEx2.Models
{
    public class FileOperations
    {
        public static void SaveToFile(PartyStuff ps) {
            StringBuilder sb = new StringBuilder();
            var items = ps.Items.Where(i => i.IsChecked).ToList();
            if (items.Count > 0) {
                foreach (var item in items) {
                    if(item.IsChecked) sb.Append(item.Name).Append("| ");
                }
            }else {
                sb.Append("brak towaru..");
            }

            string line = $"{ps.FirstName} {ps.LastName} " +
                          $"{sb.ToString()} {DateTime.Now.ToLongDateString()}: " +
                          $"{DateTime.Now.ToLongTimeString()}";
            using (StreamWriter sw = new StreamWriter("dane.txt",append:true)) {
                sw.WriteLine(line);
            }
        }
    }
}
