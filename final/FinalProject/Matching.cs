using System;
public class Matching : Application
{
    public Matching(string answer, int points) : base(answer, points)
    {
        OriginalPoints = points;
    }

    public void GenerateRandomQuestion(int questionNumber)
    {
        string userAnswer;

        switch (questionNumber)
        {
            case 1:
                Console.Write("\nMatching Question 1 (Integumentary System): ");
                Console.WriteLine("Match the terms to their correct definitions. Answer the questions in order: 1, 2, 3.");
                Console.WriteLine("1. epidermis    a. middle layer of skin");
                Console.WriteLine("2. dermis       b. upper layer of skin");
                Console.WriteLine("3. hypodermis   c. lower layer of skin");
                Console.Write("\nPlease enter a one letter answer for term 1. (no caps): ");
                userAnswer = Console.ReadLine();
                
                if (userAnswer.ToLower() == "b")
                {
                    Console.WriteLine("Correct!");
                    Points = 5;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'b'.");
                    Points = 0;
                }

                Console.Write("\nPlease enter a one letter answer for term 2. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "a")
                {
                    Console.WriteLine("Correct!");
                    Points = 5;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'a'.");
                    Points = 0;
                }

                Console.Write("\nPlease enter a one letter answer for term 3. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "c")
                {
                    Console.WriteLine("Correct!");
                    Points = 5;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'c'.");
                    Points = 0;
                }

                break;

            case 2:
                Console.Write("\nMatching Question 2 (Skeletal System): ");
                Console.WriteLine("Name the connective tissue that connects bones to bones.");
                Console.WriteLine("    a. cartilage");
                Console.WriteLine("    b. tendons");
                Console.WriteLine("    c. collagen");
                Console.WriteLine("    d. ligaments");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "d")
                {
                    Console.WriteLine("Correct!");
                    Points = 5;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'd'.");
                    Points = 0;
                }

                break;

            case 3:
                Console.Write("\nMatching Question 3 (Muscular System): ");
                Console.WriteLine("What is the correct name of the muscle in the shoulder?");
                Console.WriteLine("    a. latissimus dorsi");
                Console.WriteLine("    b. triceps brachii");
                Console.WriteLine("    c. deltoid");
                Console.WriteLine("    d. humerus");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "c")
                {
                    Console.WriteLine("Correct!");
                    Points = 5;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'c'.");
                    Points = 0;
                }

                break;

            case 4:
                Console.Write("\nMatching Question 4 (Nervous System): ");
                Console.WriteLine("Name the type of neurons that carry information back to the brain.");
                Console.WriteLine("    a. sensory neurons");
                Console.WriteLine("    b. peripheral neurons");
                Console.WriteLine("    c. sympathetic neurons");
                Console.WriteLine("    d. motor neurons");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "a")
                {
                    Console.WriteLine("Correct!");
                    Points = 5;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'a'.");
                    Points = 0;
                }

                break;

            case 5:
                Console.Write("\nMatching Question 5 (Circulatory System): ");
                Console.WriteLine("Which chamber of the heart does the blood enter after returning from the lungs?");
                Console.WriteLine("    a. left ventricle");
                Console.WriteLine("    b. left atrium");
                Console.WriteLine("    c. right ventricle");
                Console.WriteLine("    d. right atrium");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "b")
                {
                    Console.WriteLine("Correct!");
                    Points = 5;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'b'.");
                    Points = 0;
                }

                break;

            case 6:
                Console.Write("\nMatching Question 6 (Respiratory System): ");
                Console.WriteLine("What is the name of the tube that carries air from the nasal and oral cavities to the lungs?");
                Console.WriteLine("    a. esophagus");
                Console.WriteLine("    b. larynx");
                Console.WriteLine("    c. alveoli");
                Console.WriteLine("    d. trachea");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "d")
                {
                    Console.WriteLine("Correct!");
                    Points = 5;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'd'.");
                    Points = 0;
                }

                break;

            case 7:
                Console.Write("\nMatching Question 7 (Digestive System): ");
                Console.WriteLine("Name the location where digestion begins in the body.");
                Console.WriteLine("    a. the esophagus");
                Console.WriteLine("    b. the mouth");
                Console.WriteLine("    c. the small intestine");
                Console.WriteLine("    d. the stomach");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "b")
                {
                    Console.WriteLine("Correct!");
                    Points = 5;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'b'.");
                    Points = 0;
                }

                break;

            case 8:
                Console.Write("\nMatching Question 8 (Immune System): ");
                Console.WriteLine("Which type of lymphocyte produces antibodies? ");
                Console.WriteLine("    a. B cells");
                Console.WriteLine("    b. cytotoxic T cells");
                Console.WriteLine("    c. dendritic cells");
                Console.WriteLine("    d. helper T cells");
                Console.Write("\nPlease enter a one letter answer (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "a")
                {
                    Console.WriteLine("Correct!");
                    Points = 5;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'a'.");
                    Points = 0;
                }

                break;

            default:
                Console.WriteLine("Invalid question number.");
                userAnswer = Console.ReadLine();
                break;
        }
        Console.WriteLine("\nPress enter to return to the Main Menu.");
        Console.ReadLine(); 
    }

}