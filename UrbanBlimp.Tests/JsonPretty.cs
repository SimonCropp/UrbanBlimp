using Newtonsoft.Json.Linq;

public static class JsonPretty
{
    public static string FormatAsJson(this string value)
    {
        string formatted;
        if (value.StartsWith("["))
        {
            formatted = JArray.Parse(value).ToString();
        }
        else
        {

            formatted = JObject.Parse(value).ToString();
        }
        var formatAsJsom = "\n" + formatted.Replace("\"", "'");
        return formatAsJsom.Replace("\r\n", "\n");
    }
}