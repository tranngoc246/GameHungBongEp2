using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject replayPanel;
    
    public void SetScoreText(string txt)
    {
        scoreText.text = txt;
    }

    public void ShowReplayPanel(bool isShow)
    {
        replayPanel.SetActive(isShow);
    }
}
