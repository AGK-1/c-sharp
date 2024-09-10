using System;
using System.Text;

class Program
{
	static void Main()
	{
		Random random = new Random();
		int z = random.Next(0, 3);
	
		Console.OutputEncoding = Encoding.UTF8;
		Console.InputEncoding = Encoding.UTF8;
		// Создаем список вопросов
		List<Question> quiz = QuestionList.GetQuestions();


		// Переменная для подсчета правильных ответов
		int score = 0;

		int questsc = 3;// quiz.Count; // Количество вопросов, которые мы хотим задать
		for (int i = 0; i < questsc; i++)
		{
			// Случайный выбор вопроса из списка
			int randomIndex = random.Next(quiz.Count);

			// Получаем случайный вопрос
			Question randomQuestion = quiz[randomIndex];

			// Выводим вопрос и варианты
			randomQuestion.DisplayQuestion();

			// Получаем ответ пользователя
			Console.Write("Ваш ответ (1-4): ");
			int userAnswer = int.Parse(Console.ReadLine());

			// Проверяем правильность ответа
			if (randomQuestion.IsCorrect(userAnswer))
			{
				Console.WriteLine("Правильный ответ!\n");
				score++;
			}
			else
			{
				Console.WriteLine("Неправильный ответ.\n");
			}

			// Удаляем вопрос из списка, чтобы не повторялся
			quiz.RemoveAt(randomIndex);
		}
		Console.WriteLine($"Your score is: {score}");
		Console.ReadLine();
	}
}