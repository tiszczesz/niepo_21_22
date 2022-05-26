using System.Text;

namespace MVCFormEx2.Models
{
    public class FileOperations
    {
        public static void SaveToFile(PartyStuff ps) {
            StringBuilder sb = new StringBuilder();
            if (ps.Items.Count > 0) {
                foreach (var item in ps.Items) {
                    sb.Append(item.Name).Append("| ");
                }
            }else {
                sb.Append("brak towaru..");
            }

            string line = $"{ps.FirstName} {ps.LastName} {sb.ToString()} {DateTime.Now.ToLongTimeString()}";
            using (StreamWriter sw = new StreamWriter("dane.txt",append:true)) {
                //todo
            }
        }
    }
}
