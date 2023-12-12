using System;
public class Matching : Application
{
    public Matching(string answer, int points) : base(answer, points)
    {
        OriginalPoints = points;
    }

        private void AskQuestion(string category, string[] terms, string[] definitions, ref int totalPoints)
    {
        Console.Write($"\nMatching Question ({category}): ");
        Console.WriteLine("Match the terms to their correct definitions. Answer the questions in order: 1, 2, 3.");

        for (int i = 0; i < terms.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {terms[i]}    {definitions[i]}");
        }

        for (int i = 0; i < terms.Length; i++)
        {
            Console.Write($"\nPlease enter a one-letter answer for term {i + 1}. (no caps): ");
            string userAnswer = Console.ReadLine();

            if (userAnswer.Length == 1 && char.IsLetter(userAnswer[0]))
            {
                if (userAnswer.ToLower() == terms[i][0].ToString())
                {
                    Console.WriteLine("Correct!");
                    totalPoints++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer is '{terms[i][0]}'.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a single letter.");
                i--;
            }
        }
    }

    public void GenerateRandomQuestion(int questionNumber)
    {
        string userAnswer;
        int totalPoints = 0;

        switch (questionNumber)
        {
            case 1:
                AskQuestion("Integumentary System", new[] { "epidermis", "dermis", "hypodermis" },
                            new[] { "a. middle layer of skin", "b. upper layer of skin", "c. lower layer of skin" }, ref totalPoints);
                break;

            case 2:
                AskQuestion("Skeletal System", new[] { "cartilage", "ligaments", "tendons" },
                            new[] { "a. connect bone to bone", "b. connect muscle to bone", "c. connective tissue in joints, nose, ears" }, ref totalPoints);
                break;

            case 3:
                AskQuestion("Muscular System", new[] { "skeletal muscle", "smooth muscle", "cardiac muscle" },
                            new[] { "a. muscle tissue found in the heart", "b. muscle tissue in limbs", "c. muscle found in and around organs" }, ref totalPoints);
                break;

            case 4:
                AskQuestion("Nervous System", new[] { "cerebrum", "cerebellum", "brain stem" },
                            new[] { "a. controls most senses, speech, reasoning, fine motor control", "b. controls automatic functions like breathing and heart rate", "c. controls posture and balance" }, ref totalPoints);
                break;

            case 5:
                AskQuestion("Circulatory System", new[] { "arteries", "veins", "capillaries" },
                            new[] { "a. connect arteries to veins", "b. carry blood back to the heart", "c. carry blood away from the heart" }, ref totalPoints);
                break;

            case 6:
                AskQuestion("Respiratory System", new[] { "trachea", "bronchi", "alveoli" },
                            new[] { "a. tube that carries air from mouth to lungs", "b. branches within lungs", "c. small air sacs at end of bronchioles where gas exchange occurs" }, ref totalPoints);
                break;

            case 7:
                AskQuestion("Digestive System", new[] { "duodenum", "jejunum", "ileum" },
                            new[] { "a. 3rd section of small intestine", "b. 1st section of small intestine", "c. 2nd section of small intestine" }, ref totalPoints);
                break;

            case 8:
                AskQuestion("Immune System", new[] { "NK cells", "macrophages", "neutrophils" },
                            new[] { "a. engulf pathogens", "b. activators that can phagocytose bacteria and fungi", "c. use activation receptors to target virus-infected cells" }, ref totalPoints);
                break;

            default:
                Console.WriteLine("Invalid question number.");
                userAnswer = Console.ReadLine();
                break;
        }
        Points = totalPoints;
        
        Console.WriteLine("\nPress enter to return to the Main Menu.");
        Console.ReadLine(); 
    }

}