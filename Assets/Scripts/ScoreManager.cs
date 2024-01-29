using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text ScoreText;
    [SerializeField]
    private ZoneScore _zoneScore;
    private int _currentScore = 0;

    private void Start()
    {
        _zoneScore.OnScore += ScoreUpdate;
    }

    public void ScoreUpdate()
    {
        _currentScore ++;
        ScoreText.text = "" + _currentScore;
    }
}
