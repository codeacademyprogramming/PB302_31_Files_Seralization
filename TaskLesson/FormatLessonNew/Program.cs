

using FormatLessonNew;
using System.Text.Json;

User usr1 = null;
usr1 = new User()
{
    Name = "Elmar",
    Surname = "Surname1",
    Age = 5
};

var jsonStr = JsonSerializer.Serialize(usr1);
Console.WriteLine(jsonStr);

User? newUser = JsonSerializer.Deserialize<User>(jsonStr);
Console.WriteLine(newUser);




HttpClient client = new HttpClient();

var responseStr = client.GetStringAsync("https://jsonplaceholder.typicode.com/posts").Result;

List<Post> post = JsonSerializer.Deserialize<List<Post>>(responseStr);

foreach (var item in post)
{
    Console.WriteLine(item.Title);
}
Console.WriteLine(post.Count());