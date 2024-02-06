
using FormatLesson;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

User usr1 = null;
usr1 = new User()
{
    Name = "Elmar",
    Surname = "Surname1",
    Age = 5
};


#region Ser/DeSer Binary
//SerializeBinary(usr1);
//usr1 = DeserializeBinary();
#endregion

#region Ser/DeSer XML
//SerializeXml(usr1);
//usr1 = DeserializeXml();
#endregion

#region Ser/DeSer JSON
SerializeJson(usr1);
usr1 = DeserializeJson();
#endregion


Console.WriteLine(usr1);



void SerializeBinary(User user)
{
    FileStream fs = new FileStream("C:\\Users\\elchin\\Desktop\\CodeLessons\\31. 06-02-2024\\TaskLesson\\FormatLesson\\data\\user1.dat",FileMode.Create);
    BinaryFormatter bf = new BinaryFormatter();
    bf.Serialize(fs, user);
    fs.Close();
}

User DeserializeBinary()
{
    FileStream fs = new FileStream("C:\\Users\\elchin\\Desktop\\CodeLessons\\31. 06-02-2024\\TaskLesson\\FormatLesson\\data\\user1.dat", FileMode.Open);
    BinaryFormatter bf = new BinaryFormatter();
    var data = bf.Deserialize(fs) as User;
    return data;
}

void SerializeXml(User user)
{
    FileStream fs = new FileStream("C:\\Users\\elchin\\Desktop\\CodeLessons\\31. 06-02-2024\\TaskLesson\\FormatLesson\\data\\user2.xml", FileMode.Create);
    XmlSerializer bf = new XmlSerializer(typeof(User));
    bf.Serialize(fs, user);
    fs.Close();
}

User DeserializeXml()
{
    //FileStream fs = new FileStream("C:\\Users\\elchin\\Desktop\\CodeLessons\\31. 06-02-2024\\TaskLesson\\FormatLesson\\data\\user2.xml", FileMode.Open);
    //XmlSerializer bf = new XmlSerializer(typeof(User));
    //var data = bf.Deserialize(fs) as User;
    //fs.Close();
    //return data;

    User data = null;

    using(var fs = new FileStream("C:\\Users\\elchin\\Desktop\\CodeLessons\\31. 06-02-2024\\TaskLesson\\FormatLesson\\data\\user2.xml", FileMode.Open))
    {
        XmlSerializer bf = new XmlSerializer(typeof(User));
        data = bf.Deserialize(fs) as User;
    }

    return data;
}

void SerializeJson(User user)
{
    //var jsonStr = JsonConvert.SerializeObject(user);
    //File.WriteAllText("C:\\Users\\elchin\\Desktop\\CodeLessons\\31. 06-02-2024\\TaskLesson\\FormatLesson\\data\\user3.json", jsonStr);
    using (FileStream fs = new FileStream("C:\\Users\\elchin\\Desktop\\CodeLessons\\31. 06-02-2024\\TaskLesson\\FormatLesson\\data\\user3.json", FileMode.Create))
    {
        var jsonStr = JsonConvert.SerializeObject(user);
        Console.WriteLine(jsonStr);
        StreamWriter sw = new StreamWriter(fs);
        sw.Write(jsonStr);
        sw.Close();

        //DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(User));
        //js.WriteObject(fs, user);
    }
}

User DeserializeJson()
{
    User data = null;
    using (FileStream fs = new FileStream("C:\\Users\\elchin\\Desktop\\CodeLessons\\31. 06-02-2024\\TaskLesson\\FormatLesson\\data\\user3.json", FileMode.Open))
    {
        //DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(User));
        //data = js.ReadObject(fs) as User;
        StreamReader sr = new StreamReader(fs);
        var jsonStr = sr.ReadToEnd();
        data = JsonConvert.DeserializeObject<User>(jsonStr);
    }
    return data;
}

