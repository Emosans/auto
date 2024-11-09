using System.Threading.Tasks;
public class Program{
    public static void Main(string[] args){
        var notifservice = new Notif();
        var filestructure = new Filestruct();

        notifservice.ShowNotification("message");
        filestructure.Organizefiles("path_to_your_directory/files");
    }
}
