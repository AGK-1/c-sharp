using System.Text.Json.Serialization;

public class Question
{
	public string Text { get; set; }
	public string[] Options { get; set; }
	public Answer CorrectAnswer { get; set; }
}

[JsonConverter(typeof(JsonStringEnumConverter))]  // Optional: Add directly to the enum
public enum Answer
{
	Option1,
	Option2,
	Option3,
	Option4
}

