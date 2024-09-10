using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

	 class QuestionList
	{
		public static List<Question> GetQuestions()
		{
		return new List<Question>
		{
			new Question(
				"Вопрос 1: Какая столица Франции?",
				new string[] { "Лондон", "Берлин", "Париж", "Мадрид" },
				Answer.Option3
			),
			new Question(
				"Вопрос 2: Какой элемент таблицы Менделеева имеет символ H?",
				new string[] { "Гелий", "Гидроген", "Кислород", "Азот" },
				Answer.Option2
			),
			new Question(
				"Вопрос 3: Сколько планет в Солнечной системе?",
				new string[] { "7", "8", "9", "10" },
				Answer.Option2
			)
		};
	}
}
