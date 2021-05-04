using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public static TimeManager instance;
    public int timerOriginal = 10;
    public int actualTimer;
    public TextMeshProUGUI timerUI;

    private void Awake()
    {
        instance = this;
    }
    public void ResetTimer()
    {
        actualTimer = timerOriginal;
    }
    private void Start()
    {
        ResetTimer();
        timerUI.text = actualTimer.ToString();
        StartCoroutine(Timer());
    }
    IEnumerator Timer()
    {
        while(actualTimer > 0)
        {
            yield return new WaitForSeconds(1);
            actualTimer--;
            timerUI.text = actualTimer.ToString();
        }
        yield break;
    }
}
