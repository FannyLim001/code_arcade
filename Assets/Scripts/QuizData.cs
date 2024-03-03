using System.Collections.Generic;

public static class QuizData
{
    public static Dictionary<string, List<QuestionAnswer>> Questions = new Dictionary<string, List<QuestionAnswer>> {
        {
            "PreTest", new List<QuestionAnswer> {
                new QuestionAnswer {
                    QuestionType = "Complete This Code",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    _________(\"Hello World\");\r\n  }\r\n}",
                    Answers = new string[] { "System.out.println", "System.print", "Console.log", "print" },
                    CorrectAnswer = 0,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Find a bug in this code",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    System.println(\"Hello World\");;\r\n  }\r\n}",
                    Answers = new string[] { "System.out.println", "System.print", ";;", "print" },
                    CorrectAnswer = 2,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "What is the output?",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    System.println(\"Hello World\");\r\n  }\r\n}",
                    Answers = new string[] { "Hello", "Hello World", "World", "H W" },
                    CorrectAnswer = 1,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Arrange this code",
                    Answers = new string[] { "public class Main", "System.println(\"Hello World\");", "public static void main(String[] args){", "}" },
                    IsMultipleChoice = false,
                    CorrectArrangement = new string[] { "public class Main","public static void main(String[] args){", "System.println(\"Hello World\");", "}" },
                },
                // Add more questions for PreTest as needed...
            }
        },
        {
            "Unit 1", new List<QuestionAnswer> {
                new QuestionAnswer {
                    QuestionType = "Complete This Code",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    ___________ x = 5.5;\r\n  }\r\n}",
                    Answers = new string[] { "int", "String", "float", "boolean" },
                    CorrectAnswer = 3,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Find a Bug in This Code",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int num == 10;\r\n    System.out.println(num);\r\n  }\r\n}",
                    Answers = new string[] { "int num = 10;", "int num == 10;", "int num === 10;", "int num =: 10;" },
                    CorrectAnswer = 1,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "What is the Output?",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int x = 5;\r\n    double y = 3.5;\r\n    System.out.println(x + y);\r\n  }\r\n}",
                    Answers = new string[] { "8.5", "9", "5.35", "53" },
                    CorrectAnswer = 0,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Arrange this code",
                    Answers = new string[] { "int x = 5;", "System.out.println(x);", "public static void main(String[] args) {", "}" },
                    IsMultipleChoice = false,
                    CorrectArrangement = new string[] { "public static void main(String[] args) {", "int x = 5;", "System.out.println(x);", "}" },
                },

                // Add more questions for Unit 1 as needed...
            }
        },
        // Add more units and questions as needed...
        {
            "Unit 2", new List<QuestionAnswer> {
                new QuestionAnswer {
                  QuestionType = "Complete This Code",
                  QuestionText = "public class Main {\r\n public static void main(String[] args) {\r\n  int result = 10 ______ 5;  // Fill in the appropriate operator\r\n  System.out.println(result);\r\n }\r\n}",
                  Answers = new string[] { "*/", "++", "/", "%=" },
                  CorrectAnswer = 2,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Find a Bug in This Code",
                  QuestionText = "public class Main {\r\n public static void main(String[] args) {\r\n  int num1 = 15;\r\n  int num2 = 5;\r\n  // Corrected code: int result = num1 % num2;\r\n  int result = num1 %= num2;  // Identify the bug\r\n  System.out.println(result);\r\n }\r\n}",
                  Answers = new string[] { "The %= operator should be %.", "The parentheses are missing around num1 % num2.", "The variables should be declared as double.", "There is no bug in the code." },
                  CorrectAnswer = 1,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "What is the Output?",
                  QuestionText = "public class Main {\r\n public static void main(String[] args) {\r\n  boolean a = true;\r\n  boolean b = false;\r\n  System.out.println(a && b);\r\n }\r\n}",
                  Answers = new string[] { "true", "false", "0", "1" },
                  CorrectAnswer = 1,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Arrange This Code",
                  Answers = new string[] { "int x = 5;", "System.out.println(x + 3 == 8);", "public static void main(String[] args) {", "}" },
                  IsMultipleChoice = false,
                  CorrectArrangement = new string[] { "public static void main(String[] args) {", "int x = 5;", "System.out.println(x + 3 == 8);", "}" }
                }
                // Add more questions for Unit 1 as needed...
            }
        },
        {
            "Unit 3", new List<QuestionAnswer> {
                new QuestionAnswer {
                  QuestionType = "Complete This Code",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    String name = new Scanner(System.in).nextLine();  // Replace the line to read user input\r\n    System.out.println(\"Hello, \" + name);\r\n  }\r\n}",
                  Answers = new string[] { "String name = System.console().readLine();", "String name = JOptionPane.showInputDialog(\"Enter your name\");", "String name = \"Alice\";", "String name = args[0];" },
                  CorrectAnswer = 0,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Find a Bug in This Code",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int num = Integer.parseInt(System.in.readLine());  // Read user input\r\n    System.out.println(\"You entered: \" + num);\r\n  }\r\n}",
                  Answers = new string[] {"There is no bug in the code.", "Integer.parseInt should be Integer.valueOf.", "System.in.read() should be used instead of readLine().", "The code doesn't handle non-numeric input."},
                  CorrectAnswer = 3,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "What is the Output?",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    System.out.print(\"Enter your age: \");\r\n    int age = new Scanner(System.in).nextInt();\r\n    System.out.println(\"Your age is: \" + age);\r\n  }\r\n}",
                  Answers = new string[] {"The program greets the user and exits.", "It asks for the user's age and prints it.", "It compiles with errors.", "It opens a file named \"age.txt\"."},
                  CorrectAnswer = 1,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Arrange This Code",
                  Answers = new string[] { "System.out.print(\"Enter your name: \");", "String name = new Scanner(System.in).nextLine();", "public static void main(String[] args) {", "}", "System.out.println(\"Hello, \" + name);"},
                  IsMultipleChoice = false,
                  CorrectArrangement = new string[] { "public static void main(String[] args) {", "System.out.print(\"Enter your name: \");", "String name = new Scanner(System.in).nextLine();", "System.out.println(\"Hello, \" + name);", "}" }
                }
                // Add more questions for Unit 1 as needed...
            }
        },
        {
            "Unit 4", new List<QuestionAnswer> {
                new QuestionAnswer {
                  QuestionType = "Complete This Code",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int age = 25;\r\n    if (age ______ 18) {  // Fill in the appropriate comparison operator\r\n      System.out.println(\"You are an adult.\");\r\n    }\r\n  }\r\n}",
                  Answers = new string[] { ">", ">=", "<", "<=" },
                  CorrectAnswer = 1,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Find a Bug in This Code",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    for (int i = 0; i <= 5; i++) {  // Find the bug\r\n      System.out.println(i);\r\n    }\r\n  }\r\n}",
                  Answers = new string[] {"The loop should iterate 6 times, not 5.", "The loop is missing a curly brace after the condition.", "The variable i should be declared as double.", "There is no bug in the code."},
                  CorrectAnswer = 0,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "What is the Output?",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int sum = 0;\r\n    for (int i = 1; i <= 3; i++) {\r\n      sum += i;\r\n    }\r\n    System.out.println(sum);\r\n  }\r\n}",
                  Answers = new string[] {"0", "1", "3", "6"},
                  CorrectAnswer = 3,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Arrange This Code",
                  Answers = new string[] { "int i = 0;", "System.out.println(i);", "for (int i = 0; i < 3; i++) {", "}", "i++" },
                  IsMultipleChoice = false,
                  CorrectArrangement = new string[] { "for (int i = 0; i < 3; i++) {", "int i = 0;", "System.out.println(i);", "i++", "}" }
                }
                // Add more questions for Unit 1 as needed...
            }
        },
        {
            "Unit 5", new List<QuestionAnswer> {
                new QuestionAnswer {
                  QuestionType = "Complete This Code",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int[] numbers = new int[5];  // Declare an array\r\n    numbers[2] = ______;  // Assign a value to the 3rd element\r\n    System.out.println(numbers[2]);\r\n  }\r\n}",
                  Answers = new string[] { "10", "2", "{1, 2, 3}", "numbers.length" },
                  CorrectAnswer = 1,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Find a Bug in This Code",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int[] numbers = {1, 2, 3, 4, 5};\r\n    System.out.println(numbers[6]);  // Find the bug\r\n  }\r\n}",
                  Answers = new string[] {"The array is declared with a size of 5, but accessed at index 6.", "The elements are printed in reverse order.", "The loop iterates one extra time.", "There is no bug in the code."},
                  CorrectAnswer = 0,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "What is the Output?",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    String[] names = {\"Alice\", \"Bob\", \"Charlie\"};\r\n    System.out.println(names[1]);\r\n  }\r\n}",
                  Answers = new string[] {"The program compiles with errors.", "It prints all elements of the array.", "It prints the length of the array.", "It prints the second element (Bob)."},
                  CorrectAnswer = 3,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Arrange This Code",
                  Answers = new string[] { "int[][] matrix = {{1, 2, 3}, {4, 5, 6}};", "System.out.println(matrix[1][0]);", "public static void main(String[] args) {", "}", "for (int i = 0; i < matrix.length; i++) {" },
                  IsMultipleChoice = false,
                  CorrectArrangement = new string[] { "public static void main(String[] args) {", "int[][] matrix = {{1, 2, 3}, {4, 5, 6}};", "for (int i = 0; i < matrix.length; i++) {", "System.out.println(matrix[i][0]);", "}", "}" }
                }
                // Add more questions for Unit 1 as needed...
            }
        },
        {
            "Unit 6", new List<QuestionAnswer> {
                new QuestionAnswer {
                  QuestionType = "Complete This Code",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int[] numbers = new int[2];\r\n    try {\r\n      numbers[3] = 10; // This line might cause an exception\r\n    } catch (______ e) {  // Fill in the appropriate exception type\r\n      System.out.println(\"Array index out of bounds!\");\r\n    }\r\n  }\r\n}",
                  Answers = new string[] { "IndexOutOfBoundsException", "ArrayIndexOutOfBoundsException", "IntegerException", "NumberFormatException" },
                  CorrectAnswer = 1,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Find a Bug in This Code",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int num = Integer.parseInt(\"hello\");  // This line might cause an exception\r\n    System.out.println(num);\r\n  }\r\n}",
                  Answers = new string[] {"The exception is not handled.", "The `parseInt` method should be `valueOf`.", "The variable `num` should be declared as `String`.", "There is no bug in the code."},
                  CorrectAnswer = 0,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "What is the Output?",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    try {\r\n      int result = 10 / 0;\r\n    } catch (ArithmeticException e) {\r\n      System.out.println(\"Division by zero!\");\r\n    }\r\n  }\r\n}",
                  Answers = new string[] {"The program compiles with errors.", "It prints the value of the variable `result`.", "It throws an unhandled exception.", "It prints \"Division by zero!\".", "It exits without printing anything."},
                  CorrectAnswer = 3,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Arrange This Code",
                  Answers = new string[] { "System.out.println(\"Number: \" + num);", "int num = Integer.parseInt(userInput);", "public static void main(String[] args) {", "}", "try {", "catch (NumberFormatException e) {", "}" },
                  IsMultipleChoice = false,
                  CorrectArrangement = new string[] { "public static void main(String[] args) {", "try {", "int num = Integer.parseInt(userInput);", "System.out.println(\"Number: \" + num);", "} catch (NumberFormatException e) {", "System.out.println(\"Invalid input!\");", "}", "}" }
                },
                // Add more questions for Unit 1 as needed...
            }
        }
    };
}
