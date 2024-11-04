using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textscore : MonoBehaviour
{
    public Text scorezero;
    public carcode carcode;
    public TMPro.TextMeshPro score;

    void Update()
    {
        scorezero.text = score.text + carcode.score.ToString();
    }
}
