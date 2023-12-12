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
        int totalPoints = 0;

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
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'b'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 2. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "a")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'a'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 3. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "c")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'c'.");
                }

                break;

            case 2:
                Console.Write("\nMatching Question 2 (Skeletal System): ");
                Console.WriteLine("Match the terms to their correct definitions. Answer the questions in order: 1, 2, 3.");
                Console.WriteLine("1. cartilage    a. connect bone to bone");
                Console.WriteLine("2. ligaments    b. connect muscle to bone");
                Console.WriteLine("3. tendons      c. connective tissue in joints, nose, ears");
                Console.Write("\nPlease enter a one letter answer for term 1. (no caps): ");
                userAnswer = Console.ReadLine();
                
                if (userAnswer.ToLower() == "c")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'c'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 2. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "a")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'a'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 3. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "b")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'b'.");
                }

                break;

            case 3:
                Console.Write("\nMatching Question 3 (Muscular System): ");
                Console.WriteLine("Match the terms to their correct definitions. Answer the questions in order: 1, 2, 3.");
                Console.WriteLine("1. skeletal muscle    a. muscle tissue found in the heart");
                Console.WriteLine("2. smooth muscle      b. muscle tissue in limbs");
                Console.WriteLine("3. cardiac muscle     c. muscle found in and around organs");
                Console.Write("\nPlease enter a one letter answer for term 1. (no caps): ");
                userAnswer = Console.ReadLine();
                
                if (userAnswer.ToLower() == "b")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'b'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 2. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "c")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'c'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 3. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "a")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'a'.");
                }

                break;

            case 4:
                Console.Write("\nMatching Question 4 (Nervous System): ");
                Console.WriteLine("Match the terms to their correct definitions. Answer the questions in order: 1, 2, 3.");
                Console.WriteLine("1. cerebrum     a. controls touch, vision, hearing, speech, reasoning, fine motor control");
                Console.WriteLine("2. cerebellum   b. controls most automatic functions like breathing and heart rate");
                Console.WriteLine("3. brain stem   c. controls posture and balance");
                Console.Write("\nPlease enter a one letter answer for term 1. (no caps): ");
                userAnswer = Console.ReadLine();
                
                if (userAnswer.ToLower() == "a")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'a'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 2. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "c")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'c'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 3. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "b")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'b'.");
                }

                break;

            case 5:
                Console.Write("\nMatching Question 5 (Circulatory System): ");
                Console.WriteLine("Match the terms to their correct definitions. Answer the questions in order: 1, 2, 3.");
                Console.WriteLine("1. arteries      a. connect arteries to veins");
                Console.WriteLine("2. veins         b. carry blood back to the heart");
                Console.WriteLine("3. capillaries   c. carry blood away from the heart");
                Console.Write("\nPlease enter a one letter answer for term 1. (no caps): ");
                userAnswer = Console.ReadLine();
                
                if (userAnswer.ToLower() == "c")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'c'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 2. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "b")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'b'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 3. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "a")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'a'.");
                }

                break;

            case 6:
                Console.Write("\nMatching Question 6 (Respiratory System): ");
                Console.WriteLine("Match the terms to their correct definitions. Answer the questions in order: 1, 2, 3.");
                Console.WriteLine("1. trachea      a. tube that carries air from nasal and oral cavities to the lungs");
                Console.WriteLine("2. bronchi      b. branches within lungs");
                Console.WriteLine("3. alveoli      c. small air sacs at end of bronchioles where gas exchange occurs");
                Console.Write("\nPlease enter a one letter answer for term 1. (no caps): ");
                userAnswer = Console.ReadLine();
                
                if (userAnswer.ToLower() == "a")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'a'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 2. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "b")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'b'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 3. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "c")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'c'.");
                }

                break;

            case 7:
                Console.Write("\nMatching Question 7 (Digestive System): ");
                Console.WriteLine("Match the terms to their correct definitions. Answer the questions in order: 1, 2, 3.");
                Console.WriteLine("1. duodenum     a. 3rd section of small intestine");
                Console.WriteLine("2. jejunum      b. 1st section of small intestine");
                Console.WriteLine("3. ileum        c. 2nd section of small intestine");
                Console.Write("\nPlease enter a one letter answer for term 1. (no caps): ");
                userAnswer = Console.ReadLine();
                
                if (userAnswer.ToLower() == "b")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'b'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 2. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "c")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'c'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 3. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "a")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'a'.");
                }

                break;

            case 8:
                Console.Write("\nMatching Question 8 (Immune System): ");
                Console.WriteLine("Match the terms to their correct definitions. Answer the questions in order: 1, 2, 3.");
                Console.WriteLine("1. NK cells        a. eradicate pathogens by engulfing them");
                Console.WriteLine("2. macrophages     b. eradicate bacteria and fungi and activate other cells");
                Console.WriteLine("3. neutrophils     c. use activation receptors to target virus-infected cells");
                Console.Write("\nPlease enter a one letter answer for term 1. (no caps): ");
                userAnswer = Console.ReadLine();
                
                if (userAnswer.ToLower() == "c")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'c'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 2. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "a")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'a'.");
                }

                Console.Write("\nPlease enter a one letter answer for term 3. (no caps): ");
                userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "b")
                {
                    Console.WriteLine("Correct!");
                    totalPoints += 1;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is 'b'.");
                }

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