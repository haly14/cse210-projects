using System;
public class MultChoice : Application
{
    
    public MultChoice(string answer, int points) : base(answer, points)
    {
        OriginalPoints = points;
    }

    public void GenerateRandomQuestion(int questionNumber)
    {
        string userAnswer;

        string[] questions = {
            "Name the gland that secretes oil.",
            "Name the connective tissue that connects bones to bones.",
            "What is the correct name of the muscle in the shoulder?",
            "Name the type of neurons that carry information back to the brain.",
            "Which chamber of the heart does the blood enter after returning from the lungs?",
            "What is the name of the tube that carries air from the nasal and oral cavities to the lungs?",
            "Name the location where digestion begins in the body.",
            "Which type of lymphocyte produces antibodies?"
        };

        string[][] options = {
            new[] { "a. oil gland", "b. sweat gland", "c. sebaceous gland", "d. adipose gland" },
            new[] { "a. cartilage", "b. tendons", "c. collagen", "d. ligaments" },
            new[] { "a. latissimus dorsi", "b. triceps brachii", "c. deltoid", "d. humerus" },
            new[] { "a. sensory neurons", "b. peripheral neurons", "c. sympathetic neurons", "d. motor neurons" },
            new[] { "a. left ventricle", "b. left atrium", "c. right ventricle", "d. right atrium" },
            new[] { "a. esophagus", "b. larynx", "c. alveoli", "d. trachea" },
            new[] { "a. the esophagus", "b. the mouth", "c. the small intestine", "d. the stomach" },
            new[] { "a. B cells", "b. cytotoxic T cells", "c. dendritic cells", "d. helper T cells" }
        };

        string[] correctAnswers = {"c", "d", "c", "a", "b", "d", "b", "a"};

        if (questionNumber >= 1 && questionNumber <= 8)
        {
            Console.WriteLine($"\nMultiple Choice Question {questionNumber} ({GetSystemName(questionNumber)}): ");
            Console.WriteLine(questions[questionNumber - 1]);

            for (int i = 0; i < options[questionNumber - 1].Length; i++)
            {
                Console.WriteLine(options[questionNumber - 1][i]);
            }

            Console.Write("\nPlease enter a one letter answer (no caps): ");
            userAnswer = Console.ReadLine();

            if (userAnswer.ToLower() == correctAnswers[questionNumber - 1])
            {
                Console.WriteLine("Correct!");
                Points = 2;
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer is '{correctAnswers[questionNumber - 1]}'.");
                Points = 0;
            }

        }
        else
        {
            Console.WriteLine("Invalid question number.");
            userAnswer = Console.ReadLine();
            return;
        }

        Console.WriteLine("\nPress enter to return to the Main Menu.");
        Console.ReadLine();
    }

    private string GetSystemName(int questionNumber)
    {
        switch (questionNumber)
        {
            case 1: return "Integumentary System";
            case 2: return "Skeletal System";
            case 3: return "Muscular System";
            case 4: return "Nervous System";
            case 5: return "Circulatory System";
            case 6: return "Respiratory System";
            case 7: return "Digestive System";
            case 8: return "Immune System";
            default: return "";
        }
    }

}
