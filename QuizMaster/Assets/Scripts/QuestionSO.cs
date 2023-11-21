using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    // 최소 2자리, 최대 6자리
    [TextArea(2,6)]
    [SerializeField] string question = "Enter new Question text here";

    public string GetQuestion()
    {
        return question;
    }

}

public class Test
{
    QuestionSO questionSO;

    void TestA()
    {
        string questionText = questionSO.GetQuestion();
    }
}
