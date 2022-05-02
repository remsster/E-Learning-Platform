using UnityEngine;
using System.Net;
using System.IO;

public class APIHelper
{
    static string api = "https://api.chucknorris.io/jokes/random";

    public static Joke GetNewJoke()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(api);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<Joke>(json);
    }

    public static Course[] GetCourse() 
    {
        string path = Directory.GetCurrentDirectory();
        string file = File.ReadAllText(path + "\\data.json");
        Debug.Log(file);
        Course[] courses = JsonUtility.FromJson<Course[]>(file);
        return courses;
    }

    
}
