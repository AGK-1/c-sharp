using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
	static void Main(string[] args)
	{
		int score = 0;
		Console.OutputEncoding = Encoding.UTF8;
		Console.InputEncoding = Encoding.UTF8;
		// Path to your JSON file (Quiz.json)
		string jsonFilePath = "Quiz.json";

		// Read the JSON data from the file
		string jsonData = File.ReadAllText(jsonFilePath);

		// Create JsonSerializerOptions to support enum string conversion
		var options = new JsonSerializerOptions
		{
			Converters = { new JsonStringEnumConverter() },
			PropertyNameCaseInsensitive = true // Optional: Ignore case sensitivity in property names
		};

		// Deserialize the JSON data into a List of Question objects
		List<Question> questions = JsonSerializer.Deserialize<List<Question>>(jsonData, options);

		// Output the deserialized data
		foreach (var question in questions)
		{
			Console.WriteLine($"Question: {question.Text}");
			Console.WriteLine("Options:");
			for (int i = 0; i < question.Options.Length; i++)
			{
				Console.WriteLine($"{i + 1}: {question.Options[i]}");
			}
			int userAnswer = int.Parse(Console.ReadLine());

			// Convert user input to enum
			Answer ans = (Answer)(userAnswer - 1);
			if (ans == question.CorrectAnswer)
			{
				Console.WriteLine("Correct!");
				score++;
			}
			else
			{
				Console.WriteLine("Incorrect!");
			}
			int correctIndex = (int)question.CorrectAnswer; // Преобразуем enum в int
			string correctAnswerText = question.Options[correctIndex];
			Console.WriteLine($"Correct Answer: {correctAnswerText}");
			Console.WriteLine();
		}
		Console.WriteLine($"Your score: {score}");
	}
}

