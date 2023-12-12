using System;
public class MultChoice : Application
{
    public MultChoice(string answer, int points) : base(answer, points)
    {
        OriginalPoints = points;
    }

    public string UserAnswer { get; private set; }
    public string CorrectAnswer { get; private set; }

    public bool IsAnswerCorrect()
    {
        return string.Equals(UserAnswer, CorrectAnswer, StringComparison.OrdinalIgnoreCase);
    }

    public void GenerateRandomQuestion(int questionNumber)
    {
        string userAnswer;

        switch (questionNumber)
        {
            case 1:
                Console.WriteLine("\nMultiple Choice Question 1 (Integumentary System): ");
                Console.WriteLine("Name the gland that secretes oil.");
                Console.WriteLine("    a. oil gland");
                Console.WriteLine("    b. sweat gland");
                Console.WriteLine("    c. sebaceous gland");
                Console.WriteLine("    d. adipose gland");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();
                UserAnswer = userAnswer;
                
                if (userAnswer.ToLower() == "c")
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'c'.");
                }
                break;

            case 2:
                Console.WriteLine("\nMultiple Choice Question 2 (Skeletal System): ");
                Console.WriteLine("Name the connective tissue that connects bones to bones.");
                Console.WriteLine("    a. cartilage");
                Console.WriteLine("    b. tendons");
                Console.WriteLine("    c. collagen");
                Console.WriteLine("    d. ligaments");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();
                UserAnswer = userAnswer;

                if (userAnswer.ToLower() == "d")
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'd'.");
                }

                break;

            case 3:
                Console.WriteLine("\nMultiple Choice Question 3 (Muscular System): ");
                Console.WriteLine("What is the correct name of the muscle in the shoulder?");
                Console.WriteLine("    a. latissimus dorsi");
                Console.WriteLine("    b. triceps brachii");
                Console.WriteLine("    c. deltoid");
                Console.WriteLine("    d. humerus");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();
                UserAnswer = userAnswer;

                if (userAnswer.ToLower() == "c")
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'c'.");
                }

                break;

            case 4:
                Console.WriteLine("\nMultiple Choice Question 4 (Nervous System): ");
                Console.WriteLine("Name the type of neurons that carry information back to the brain.");
                Console.WriteLine("    a. sensory neurons");
                Console.WriteLine("    b. peripheral neurons");
                Console.WriteLine("    c. sympathetic neurons");
                Console.WriteLine("    d. motor neurons");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();
                UserAnswer = userAnswer;

                if (userAnswer.ToLower() == "a")
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'a'.");
                }

                break;

            case 5:
                Console.WriteLine("\nMultiple Choice Question 5 (Circulatory System): ");
                Console.WriteLine("Which chamber of the heart does the blood enter after returning from the lungs?");
                Console.WriteLine("    a. left ventricle");
                Console.WriteLine("    b. left atrium");
                Console.WriteLine("    c. right ventricle");
                Console.WriteLine("    d. right atrium");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();
                UserAnswer = userAnswer;

                if (userAnswer.ToLower() == "b")
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'b'.");
                }

                break;

            case 6:
                Console.WriteLine("\nMultiple Choice Question 6 (Respiratory System): ");
                Console.WriteLine("What is the name of the tube that carries air from the nasal and oral cavities to the lungs?");
                Console.WriteLine("    a. esophagus");
                Console.WriteLine("    b. larynx");
                Console.WriteLine("    c. alveoli");
                Console.WriteLine("    d. trachea");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();
                UserAnswer = userAnswer;

                if (userAnswer.ToLower() == "d")
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'd'.");
                }

                break;

            case 7:
                Console.WriteLine("\nMultiple Choice Question 7 (Digestive System): ");
                Console.WriteLine("Name the location where digestion begins in the body.");
                Console.WriteLine("    a. the esophagus");
                Console.WriteLine("    b. the mouth");
                Console.WriteLine("    c. the small intestine");
                Console.WriteLine("    d. the stomach");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();
                UserAnswer = userAnswer;

                if (userAnswer.ToLower() == "b")
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'b'.");
                }

                break;

            case 8:
                Console.WriteLine("\nMultiple Choice Question 8 (Immune System): ");
                Console.WriteLine("Which type of lymphocyte produces antibodies? ");
                Console.WriteLine("    a. B cells");
                Console.WriteLine("    b. cytotoxic T cells");
                Console.WriteLine("    c. dendritic cells");
                Console.WriteLine("    d. helper T cells");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();
                UserAnswer = userAnswer;

                if (userAnswer.ToLower() == "a")
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'a'.");
                }

                break;

            default:
                Console.WriteLine("Invalid question number.");
                userAnswer = Console.ReadLine();
                UserAnswer = userAnswer;
                break;
        }
    }
    public void SetPoints(int points)
    {
        Points = points;
    }
}
