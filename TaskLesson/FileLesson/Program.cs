
DirectoryInfo dirInfo = new DirectoryInfo("C:\\Users\\elchin\\Desktop\\CodeLessons\\31. 06-02-2024\\TaskLesson\\FileLesson\\Files\\");

Console.WriteLine("\n\t Directory info");
Console.WriteLine("Fullname: "+dirInfo.FullName);
Console.WriteLine("Name: " + dirInfo.Name);
Console.WriteLine("Creation time: " + dirInfo.CreationTime);
Console.WriteLine("Last access time: " + dirInfo.LastAccessTime);
Console.WriteLine("Parent: " + dirInfo.Parent);
Console.WriteLine("Files count: "+dirInfo.GetFiles().Length);
Console.WriteLine("Dirs count: " + dirInfo.GetDirectories().Length);

//FileInfo fileInfo = (FileInfo)dirInfo.GetFiles().GetValue(0);
FileInfo fileInfo = new FileInfo("C:\\Users\\elchin\\Desktop\\CodeLessons\\31. 06-02-2024\\TaskLesson\\FileLesson\\Files\\text1.txt");

Console.WriteLine("\n\t File info");

Console.WriteLine("Fullname: " + fileInfo.FullName);
Console.WriteLine("Name: " + fileInfo.Name);
Console.WriteLine("Creation time: " + fileInfo.CreationTime);
Console.WriteLine("Last access time: " + fileInfo.LastAccessTime);
Console.WriteLine("Length: " + fileInfo.Length);

FileInfo fileInfo2 = new FileInfo("C:\\Users\\elchin\\Desktop\\CodeLessons\\31. 06-02-2024\\TaskLesson\\FileLesson\\Files\\text3.txt");

if (!fileInfo2.Exists)
{
    Console.WriteLine("axtardiginiz fayl yoxdur, yaradilsinmi? y/n");

    string opt = Console.ReadLine();

    if (opt == "y")
    {
        var newFs = fileInfo2.Create();
        newFs.Close();
    }
}

Console.WriteLine(  "Directories in Files folder");

//foreach (var item in dirInfo.GetDirectories())
//{
//    if (item.GetFiles().Length == 0)
//    {
//        Directory.Delete(item.FullName);
//    }
//}

foreach (var item in dirInfo.GetFiles())
{
    if (item.Length == 0) File.Delete(item.FullName);
}

//var lines= File.ReadAllLines("C:\\Users\\elchin\\Desktop\\CodeLessons\\31. 06-02-2024\\TaskLesson\\FileLesson\\Files\\text1.txt");
//foreach (var item in lines)
//{
//    Console.WriteLine(item);
//}


FileStream fs = new FileStream("C:\\Users\\elchin\\Desktop\\CodeLessons\\31. 06-02-2024\\TaskLesson\\FileLesson\\Files\\text1.txt", FileMode.Open);
StreamReader sr = new StreamReader(fs);

var line = sr.ReadLine();
while (line!=null)
{
    Console.WriteLine(line);
    line = sr.ReadLine();
}

fs.Close();
