

using System.ComponentModel.DataAnnotations;


Task.Run(() =>
{
	for (int i = 0; i < 100; i++)
	{
		Console.WriteLine(i);
	}
});


HttpClient client = new HttpClient();

//var task = GetGoogleSrc().ContinueWith(x => Console.WriteLine(x.Result));

var task = ShowGoogleSrcAsync();

//while (!task.IsCompleted)
//{
//	Thread.Sleep(100);
//	Console.WriteLine("Loading...");
//}


while (true)
{
	Thread.Sleep(100);
	Console.WriteLine("Continue....");
}

Task<string> GetGoogleSrc()
{
	var t = Task<string>.Run(() =>
	{
		var r = client.GetStringAsync("https://www.google.com/").Result;
		return r;
	});
	return t;
}

async Task ShowGoogleSrcAsync()
{
    var r = await client.GetStringAsync("https://www.google.com/");
	Console.WriteLine(r);
}


