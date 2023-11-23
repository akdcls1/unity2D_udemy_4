using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
// TextMashPro 관련

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;
    void Start()
    {
        questionText.text = question.GetQuestion();
    }

}
