using System;
using System.Text.RegularExpressions;

class NotificationChannelApp
{
    static void Main()
    {
        string? notiTtitle;
        Console.Write("Enter Channel : ");
        notiTtitle = Console.ReadLine();
        List<string> notificationChannels = NotificationChannels(notiTtitle);
        string result = string.Join(", ", notificationChannels);
        Console.WriteLine("Receive Channels : " + result);
 
    }
    static List<string> NotificationChannels(string title)
    {
        List<string> channels = new List<string>();
        Regex regex = new Regex(@"\[(.*?)\]");
        MatchCollection matches = regex.Matches(title);

        foreach (Match match in matches)
        {
            string tag = match.Groups[1].Value;
            if (tag == "BE" || tag == "FE" || tag == "QA" || tag == "Urgent")
            {
                channels.Add(tag);
            }
        }

        return channels;
    }
}
