enum Answer
{
	Option1,
	Option2,
	Option3,
	Option4
}

class Question
{
	public string Text { get; set; }
	public string[] Options { get; set; }
	public Answer CorrectAnswer { get; set; }

	public Question(string text, string[] options, Answer correctAnswer)
	{
		Text = text;
		Options = options;
		CorrectAnswer = correctAnswer;
	}

	public void DisplayQuestion()
	{
		Console.WriteLine(Text);
		for (int i = 0; i < Options.Length; i++)
		{
			Console.WriteLine($"{i + 1}. {Options[i]}");
		}
	}

	public bool IsCorrect(int userChoice)
	{
		return (Answer)(userChoice - 1) == CorrectAnswer;
	}
}