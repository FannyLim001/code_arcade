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
            "Practice", new List<QuestionAnswer> {
                new QuestionAnswer {
                    QuestionType = "Complete This Code",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    ____________ x = 5;\r\n    System.out.println(x);\r\n  }\r\n}",
                    Answers = new string[] { "int", "String", "double", "float" },
                    CorrectAnswer = 0,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Find a bug in this code",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int x = 5;\r\n    String y = \"Hello\";\r\n    System.out.println(x + y);\r\n  }\r\n}",
                    Answers = new string[] { "x + y", "String y", "int x = 5;", "System.out.println" },
                    CorrectAnswer = 0,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "What is the output?",
                    QuestionText = "import java.util.Scanner;\r\npublic class Main {\r\n  public static void main(String[] args) {\r\n    Scanner scanner = new Scanner(System.in);\r\n    System.out.print(\"Enter a number: \");\r\n    int x = scanner.nextInt();\r\n    System.out.println(\"You entered: \" + x);\r\n  }\r\n}",
                    Answers = new string[] { "Enter a number: You entered: 5", "You entered: 5", "Enter a number: 5", "Enter a number: You entered:" },
                    CorrectAnswer = 2,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Arrange this code",
                    Answers = new string[] { "Scanner scanner = new Scanner(System.in);", "public class Main", "System.out.println(\"Enter a number:\");", "int x = scanner.nextInt();" },
                    IsMultipleChoice = false,
                    CorrectArrangement = new string[] { "public class Main", "Scanner scanner = new Scanner(System.in);", "System.out.println(\"Enter a number:\");", "int x = scanner.nextInt();" }
                },
                new QuestionAnswer {
                    QuestionType = "Complete This Code",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int a = 10;\r\n    int b = 20;\r\n    int c = a ___________ b;\r\n    System.out.println(c);\r\n  }\r\n}",
                    Answers = new string[] { "++", "--", "*=", "+" },
                    CorrectAnswer = 3,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Find a bug in this code",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int x = 10;\r\n    int y = 5;\r\n    int z = x // y;\r\n    System.out.println(z);\r\n  }\r\n}",
                    Answers = new string[] { "//", "x", "y", "System.out.println" },
                    CorrectAnswer = 0,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "What is the output?",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int x = 5;\r\n    if (x > 2) {\r\n      System.out.println(\"Greater\");\r\n    } else {\r\n      System.out.println(\"Lesser\");\r\n    }\r\n  }\r\n}",
                    Answers = new string[] { "Greater", "Lesser", "Error", "No Output" },
                    CorrectAnswer = 0,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Arrange this code",
                    Answers = new string[] { "}", "if (x > 2) {", "public static void main(String[] args) {", "System.out.println(\"Greater\");" },
                    IsMultipleChoice = false,
                    CorrectArrangement = new string[] { "public static void main(String[] args) {", "if (x > 2) {", "System.out.println(\"Greater\");", "}" }
                },
                new QuestionAnswer {
                    QuestionType = "Find a bug in this code",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int[] arr = {1, 2, 3, 4, 5};\r\n    System.out.println(arr[5]);\r\n  }\r\n}",
                    Answers = new string[] { "arr[5]", "int[] arr", "System.out.println", "public static void main" },
                    CorrectAnswer = 0,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "What is the output?",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int[] arr = {10, 20, 30, 40, 50};\r\n    System.out.println(arr[1] + arr[4]);\r\n  }\r\n}",
                    Answers = new string[] { "30", "50", "60", "70" },
                    CorrectAnswer = 3,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Complete This Code",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    try {\r\n      int[] arr = {1, 2, 3};\r\n      System.out.println(arr[3]);\r\n    } catch (____________ e) {\r\n      System.out.println(\"Array index out of bounds\");\r\n    }\r\n  }\r\n}",
                    Answers = new string[] { "IOException", "ArrayIndexOutOfBoundsException", "NullPointerException", "Exception" },
                    CorrectAnswer = 1,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Arrange this code",
                    Answers = new string[] { "System.out.println(\"Division by zero\");", "try {", "int result = 10 / 0;", "} catch (ArithmeticException e) {" },
                    IsMultipleChoice = false,
                    CorrectArrangement = new string[] { "try {", "int result = 10 / 0;", "} catch (ArithmeticException e) {", "System.out.println(\"Division by zero\");" }
                }
                // Add more questions for PreTest as needed...
            }
        },
        {
            "Unit 1", new List<QuestionAnswer> {
                new QuestionAnswer {
                    QuestionType = "Complete This Code",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    ___________ x = 5.5;\r\n  }\r\n}",
                    Answers = new string[] { "int", "String", "float", "boolean" },
                    CorrectAnswer = 2,
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
    public static Dictionary<string, List<QuestionAnswer>> QuestionsID = new Dictionary<string, List<QuestionAnswer>> {
        {
        "PreTest", new List<QuestionAnswer> {
            new QuestionAnswer {
                QuestionType = "Lengkapi Kode Ini",
                QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    _________(\"Hello World\");\r\n  }\r\n}",
                Answers = new string[] { "System.out.println", "System.print", "Console.log", "print" },
                CorrectAnswer = 0,
                IsMultipleChoice = true
            },
            new QuestionAnswer {
                QuestionType = "Temukan Bug di Kode Ini",
                QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    System.println(\"Hello World\");;\r\n  }\r\n}",
                Answers = new string[] { "System.out.println", "System.print", ";;", "print" },
                CorrectAnswer = 2,
                IsMultipleChoice = true
            },
            new QuestionAnswer {
                QuestionType = "Apa Outputnya?",
                QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    System.println(\"Hello World\");\r\n  }\r\n}",
                Answers = new string[] { "Hello", "Hello World", "World", "H W" },
                CorrectAnswer = 1,
                IsMultipleChoice = true
            },
            new QuestionAnswer {
                QuestionType = "Susun Kode Ini",
                Answers = new string[] { "public class Main", "System.println(\"Hello World\");", "public static void main(String[] args){", "}" },
                IsMultipleChoice = false,
                CorrectArrangement = new string[] { "public class Main","public static void main(String[] args){", "System.println(\"Hello World\");", "}" },
            },
            // Add more questions for PreTest as needed...
        }
    },
        {
            "Practice", new List<QuestionAnswer> {
                new QuestionAnswer {
                    QuestionType = "Lengkapi Kode Ini",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    ____________ x = 5;\r\n    System.out.println(x);\r\n  }\r\n}",
                    Answers = new string[] { "int", "String", "double", "float" },
                    CorrectAnswer = 0,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Temukan Bug di Kode Ini",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int x = 5;\r\n    String y = \"Hello\";\r\n    System.out.println(x + y);\r\n  }\r\n}",
                    Answers = new string[] { "x + y", "String y", "int x = 5;", "System.out.println" },
                    CorrectAnswer = 0,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Apa Outputnya?",
                    QuestionText = "import java.util.Scanner;\r\npublic class Utama {\r\n  public static void main(String[] args) {\r\n    Scanner scanner = new Scanner(System.in);\r\n    System.out.print(\"Masukkan sebuah angka: \");\r\n    int x = scanner.nextInt();\r\n    System.out.println(\"Anda memasukkan: \" + x);\r\n  }\r\n}",
                    Answers = new string[] { "Masukkan sebuah angka: Anda memasukkan: 5", "Anda memasukkan: 5", "Masukkan sebuah angka: 5", "Masukkan sebuah angka: Anda memasukkan:" },
                    CorrectAnswer = 2,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Susun Kode Ini",
                    Answers = new string[] { "Scanner scanner = new Scanner(System.in);", "public class Main", "System.out.println(\"Enter a number:\");", "int x = scanner.nextInt();" },
                    IsMultipleChoice = false,
                    CorrectArrangement = new string[] { "public class Main", "Scanner scanner = new Scanner(System.in);", "System.out.println(\"Enter a number:\");", "int x = scanner.nextInt();" }
                },
                new QuestionAnswer {
                    QuestionType = "Lengkapi Kode Ini",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int a = 10;\r\n    int b = 20;\r\n    int c = a ___________ b;\r\n    System.out.println(c);\r\n  }\r\n}",
                    Answers = new string[] { "++", "--", "*=", "+" },
                    CorrectAnswer = 3,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Temukan Bug di Kode Ini",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int x = 10;\r\n    int y = 5;\r\n    int z = x // y;\r\n    System.out.println(z);\r\n  }\r\n}",
                    Answers = new string[] { "//", "x", "y", "System.out.println" },
                    CorrectAnswer = 0,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Apa Outputnya?",
                    QuestionText = "public class Utama {\r\n  public static void main(String[] args) {\r\n    int x = 5;\r\n    if (x > 2) {\r\n      System.out.println(\"Lebih Besar\");\r\n    } else {\r\n      System.out.println(\"Lebih Kecil\");\r\n    }\r\n  }\r\n}",
                    Answers = new string[] { "Lebih Besar", "Lebih Kecil", "Error", "Tidak Ada Output" },
                    CorrectAnswer = 0,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Susun Kode Ini",
                    Answers = new string[] { "}", "if (x > 2) {", "public static void main(String[] args) {", "System.out.println(\"Greater\");" },
                    IsMultipleChoice = false,
                    CorrectArrangement = new string[] { "public static void main(String[] args) {", "if (x > 2) {", "System.out.println(\"Greater\");", "}" }
                },
                new QuestionAnswer {
                    QuestionType = "Temukan Bug di Kode Ini",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int[] arr = {1, 2, 3, 4, 5};\r\n    System.out.println(arr[5]);\r\n  }\r\n}",
                    Answers = new string[] { "arr[5]", "int[] arr", "System.out.println", "public static void main" },
                    CorrectAnswer = 0,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Apa Outputnya?",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int[] arr = {10, 20, 30, 40, 50};\r\n    System.out.println(arr[1] + arr[4]);\r\n  }\r\n}",
                    Answers = new string[] { "30", "50", "60", "70" },
                    CorrectAnswer = 3,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Lengkapi Kode Ini",
                    QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    try {\r\n      int[] arr = {1, 2, 3};\r\n      System.out.println(arr[3]);\r\n    } catch (____________ e) {\r\n      System.out.println(\"Array index out of bounds\");\r\n    }\r\n  }\r\n}",
                    Answers = new string[] { "IOException", "ArrayIndexOutOfBoundsException", "NullPointerException", "Exception" },
                    CorrectAnswer = 1,
                    IsMultipleChoice = true
                },
                new QuestionAnswer {
                    QuestionType = "Susun Kode Ini",
                    Answers = new string[] { "System.out.println(\"Division by zero\");", "try {", "int result = 10 / 0;", "} catch (ArithmeticException e) {" },
                    IsMultipleChoice = false,
                    CorrectArrangement = new string[] { "try {", "int result = 10 / 0;", "} catch (ArithmeticException e) {", "System.out.println(\"Division by zero\");" }
                }
                // Add more questions for PreTest as needed...
            }
        },
    {
        "Unit 1", new List<QuestionAnswer> {
            new QuestionAnswer {
                QuestionType = "Lengkapi Kode Ini",
                QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    ___________ x = 5.5;\r\n  }\r\n}",
                Answers = new string[] { "int", "String", "float", "boolean" },
                CorrectAnswer = 2,
                IsMultipleChoice = true
            },
            new QuestionAnswer {
                QuestionType = "Temukan Bug di Kode Ini",
                QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int num == 10;\r\n    System.out.println(num);\r\n  }\r\n}",
                Answers = new string[] { "int num = 10;", "int num == 10;", "int num === 10;", "int num =: 10;" },
                CorrectAnswer = 1,
                IsMultipleChoice = true
            },
            new QuestionAnswer {
                QuestionType = "Apa Outputnya?",
                QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int x = 5;\r\n    double y = 3.5;\r\n    System.out.println(x + y);\r\n  }\r\n}",
                Answers = new string[] { "8.5", "9", "5.35", "53" },
                CorrectAnswer = 0,
                IsMultipleChoice = true
            },
            new QuestionAnswer {
                QuestionType = "Susun Kode Ini",
                Answers = new string[] { "int x = 5;", "System.out.println(x);", "public static void main(String[] args) {", "}" },
                IsMultipleChoice = false,
                CorrectArrangement = new string[] { "public static void main(String[] args) {", "int x = 5;", "System.out.println(x);", "}" },
            },
            // Add more questions for Unit 1 as needed...
        }
    },
    // Tambahkan unit dan pertanyaan lebih lanjut sesuai kebutuhan...

        // Add more units and questions as needed...
        {
            "Unit 2", new List<QuestionAnswer> {
                new QuestionAnswer {
                  QuestionType = "Lengkapi Kode Ini",
                  QuestionText = "public class Main {\r\n public static void main(String[] args) {\r\n  int result = 10 ______ 5;  // Isi operator yang sesuai\r\n  System.out.println(result);\r\n }\r\n}",
                  Answers = new string[] { "*/", "++", "/", "%=" },
                  CorrectAnswer = 2,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Temukan Bug di Kode Ini",
                  QuestionText = "public class Main {\r\n public static void main(String[] args) {\r\n  int num1 = 15;\r\n  int num2 = 5;\r\n  // Kode yang sudah diperbaiki: int result = num1 % num2;\r\n  int result = num1 %= num2;  // Identifikasi bug\r\n  System.out.println(result);\r\n }\r\n}",
                  Answers = new string[] { "Operator %= harus diganti menjadi %.", "Kurung kurawal kurang di sekitar num1 % num2.", "Variabel harus dinyatakan sebagai double.", "Tidak ada bug di kode." },
                  CorrectAnswer = 1,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Apa Outputnya?",
                  QuestionText = "public class Main {\r\n public static void main(String[] args) {\r\n  boolean a = true;\r\n  boolean b = false;\r\n  System.out.println(a && b);\r\n }\r\n}",
                  Answers = new string[] { "true", "false", "0", "1" },
                  CorrectAnswer = 1,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Susun Kode Ini",
                  Answers = new string[] { "int x = 5;", "System.out.println(x + 3 == 8);", "public static void main(String[] args) {", "}" },
                  IsMultipleChoice = false,
                  CorrectArrangement = new string[] { "public static void main(String[] args) {", "int x = 5;", "System.out.println(x + 3 == 8);", "}" }
                }
            }
        },
        {
            "Unit 3", new List<QuestionAnswer> {
                new QuestionAnswer {
                  QuestionType = "Lengkapi Kode Ini",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    String name = new Scanner(System.in).nextLine();  // Ganti baris untuk membaca input pengguna\r\n    System.out.println(\"Hello, \" + name);\r\n  }\r\n}",
                  Answers = new string[] { "String name = System.console().readLine();", "String name = JOptionPane.showInputDialog(\"Masukkan nama Anda\");", "String name = \"Alice\";", "String name = args[0];" },
                  CorrectAnswer = 0,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Temukan Bug di Kode Ini",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int num = Integer.parseInt(System.in.readLine());  // Membaca input pengguna\r\n    System.out.println(\"Anda memasukkan: \" + num);\r\n  }\r\n}",
                  Answers = new string[] {"Tidak ada bug di kode.", "Integer.parseInt harus diganti dengan Integer.valueOf.", "System.in.read() harus digunakan alih-alih readLine().", "Kode tidak menangani input non numerik."},
                  CorrectAnswer = 3,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Apa Outputnya?",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    System.out.print(\"Masukkan usia Anda: \");\r\n    int age = new Scanner(System.in).nextInt();\r\n    System.out.println(\"Usia Anda adalah: \" + age);\r\n  }\r\n}",
                  Answers = new string[] {"Program menyapa pengguna dan keluar.", "Program meminta usia pengguna dan mencetaknya.", "Kode dikompilasi dengan kesalahan.", "Membuka file bernama \"usia.txt\"."},
                  CorrectAnswer = 1,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Susun Kode Ini",
                  Answers = new string[] { "System.out.print(\"Masukkan nama Anda: \");", "String name = new Scanner(System.in).nextLine();", "public static void main(String[] args) {", "}", "System.out.println(\"Hello, \" + name);"},
                  IsMultipleChoice = false,
                  CorrectArrangement = new string[] { "public static void main(String[] args) {", "System.out.print(\"Masukkan nama Anda: \");", "String name = new Scanner(System.in).nextLine();", "System.out.println(\"Hello, \" + name);", "}" }
                }
            }
        },
        {
            "Unit 4", new List<QuestionAnswer> {
                new QuestionAnswer {
                  QuestionType = "Lengkapi Kode Ini",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int age = 25;\r\n    if (age ______ 18) {  // Isikan operator perbandingan yang sesuai\r\n      System.out.println(\"Anda sudah dewasa.\");\r\n    }\r\n  }\r\n}",
                  Answers = new string[] { ">", ">=", "<", "<=" },
                  CorrectAnswer = 1,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Temukan Bug di Kode Ini",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    for (int i = 0; i <= 5; i++) {  // Temukan bug\r\n      System.out.println(i);\r\n    }\r\n  }\r\n}",
                  Answers = new string[] {"Loop seharusnya melakukan iterasi 6 kali, bukan 5.", "Loop kekurangan kurung kurawal setelah kondisi.", "Variabel i harus dinyatakan sebagai double.", "Tidak ada bug di kode."},
                  CorrectAnswer = 0,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Apa Outputnya?",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int sum = 0;\r\n    for (int i = 1; i <= 3; i++) {\r\n      sum += i;\r\n    }\r\n    System.out.println(sum);\r\n  }\r\n}",
                  Answers = new string[] {"0", "1", "3", "6"},
                  CorrectAnswer = 3,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Susun Kode Ini",
                  Answers = new string[] { "int i = 0;", "System.out.println(i);", "for (int i = 0; i < 3; i++) {", "}", "i++" },
                  IsMultipleChoice = false,
                  CorrectArrangement = new string[] { "for (int i = 0; i < 3; i++) {", "int i = 0;", "System.out.println(i);", "i++", "}" }
                }
            }
        },
        {
            "Unit 5", new List<QuestionAnswer> {
                new QuestionAnswer {
                  QuestionType = "Lengkapi Kode Ini",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int[] numbers = new int[5];  // Deklarasikan sebuah array\r\n    numbers[2] = ______;  // Berikan nilai pada elemen ke-3\r\n    System.out.println(numbers[2]);\r\n  }\r\n}",
                  Answers = new string[] { "10", "2", "{1, 2, 3}", "numbers.length" },
                  CorrectAnswer = 1,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Temukan Bug di Kode Ini",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int[] numbers = {1, 2, 3, 4, 5};\r\n    System.out.println(numbers[6]);  // Temukan bug\r\n  }\r\n}",
                  Answers = new string[] {"Array dideklarasikan dengan ukuran 5, tetapi diakses pada indeks 6.", "Elemen-elemen dicetak di urutan terbalik.", "Loop melakukan iterasi satu kali ekstra.", "Tidak ada bug di kode."},
                  CorrectAnswer = 0,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Apa Outputnya?",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    String[] names = {\"Alice\", \"Bob\", \"Charlie\"};\r\n    System.out.println(names[1]);\r\n  }\r\n}",
                  Answers = new string[] {"Program dikompilasi dengan kesalahan.", "Ini mencetak semua elemen dari array.", "Ini mencetak panjang array.", "Ini mencetak elemen kedua (Bob)."},
                  CorrectAnswer = 3,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Susun Kode Ini",
                  Answers = new string[] { "int[][] matrix = {{1, 2, 3}, {4, 5, 6}};", "System.out.println(matrix[1][0]);", "public static void main(String[] args) {", "}", "for (int i = 0; i < matrix.length; i++) {" },
                  IsMultipleChoice = false,
                  CorrectArrangement = new string[] { "public static void main(String[] args) {", "int[][] matrix = {{1, 2, 3}, {4, 5, 6}};", "for (int i = 0; i < matrix.length; i++) {", "System.out.println(matrix[i][0]);", "}", "}" }
                }
            }
        },
        {
            "Unit 6", new List<QuestionAnswer> {
                new QuestionAnswer {
                  QuestionType = "Lengkapi Kode Ini",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int[] numbers = new int[2];\r\n    try {\r\n      numbers[3] = 10; // Baris ini mungkin menyebabkan pengecualian\r\n    } catch (______ e) {  // Isi dengan jenis pengecualian yang sesuai\r\n      System.out.println(\"Indeks array di luar batas!\");\r\n    }\r\n  }\r\n}",
                  Answers = new string[] { "IndexOutOfBoundsException", "ArrayIndexOutOfBoundsException", "IntegerException", "NumberFormatException" },
                  CorrectAnswer = 1,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Temukan Bug di Kode Ini",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    int num = Integer.parseInt(\"hello\");  // Baris ini mungkin menyebabkan pengecualian\r\n    System.out.println(num);\r\n  }\r\n}",
                  Answers = new string[] {"Pengecualian tidak ditangani.", "Metode `parseInt` harus diganti menjadi `valueOf`.", "Variabel `num` harus dinyatakan sebagai `String`.", "Tidak ada bug di kode."},
                  CorrectAnswer = 0,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Apa Outputnya?",
                  QuestionText = "public class Main {\r\n  public static void main(String[] args) {\r\n    try {\r\n      int result = 10 / 0;\r\n    } catch (ArithmeticException e) {\r\n      System.out.println(\"Pembagian dengan nol!\");\r\n    }\r\n  }\r\n}",
                  Answers = new string[] {"Program dikompilasi dengan kesalahan.", "Ini mencetak nilai dari variabel `result`.", "Ini melemparkan pengecualian yang tidak ditangani.", "Ini mencetak \"Pembagian dengan nol!\".", "Ini keluar tanpa mencetak apa pun."},
                  CorrectAnswer = 3,
                  IsMultipleChoice = true
                },

                new QuestionAnswer {
                  QuestionType = "Susun Kode Ini",
                  Answers = new string[] { "System.out.println(\"Number: \" + num);", "int num = Integer.parseInt(userInput);", "public static void main(String[] args) {", "}", "try {", "catch (NumberFormatException e) {", "}" },
                  IsMultipleChoice = false,
                  CorrectArrangement = new string[] { "public static void main(String[] args) {", "try {", "int num = Integer.parseInt(userInput);", "System.out.println(\"Number: \" + num);", "} catch (NumberFormatException e) {", "System.out.println(\"Invalid input!\");", "}", "}" }
                }
            }
        }
    };
}
