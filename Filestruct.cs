using System.IO;

public class Filestruct {
    public void Organizefiles(string directory){
        var files = Directory.GetFiles(directory);

        foreach (var file in files){
            string extension = Path.GetExtension(file);
            string destinationfolder = Path.Combine(directory,extension.TrimStart('.').ToUpper());

            if(!Directory.Exists(destinationfolder)){
                Directory.CreateDirectory(destinationfolder);
            }

            string destinationpath = Path.Combine(destinationfolder,Path.GetFileName(file));
            File.Move(file,destinationpath);
        }
    }
}