[System.Serializable]

public class QuestionAnswer
{
    public string QuestionType;
    public string QuestionText;
    public string[] Answers;
    public int CorrectAnswer;

    // Additional properties for multiple-choice questions
    public bool IsMultipleChoice;
    // Additional properties for arrange the answer type question
    public string[] CorrectArrangement;
}
