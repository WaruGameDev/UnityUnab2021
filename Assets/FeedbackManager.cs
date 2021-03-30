using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FeedbackManager : MonoBehaviour
{
    public static FeedbackManager sFeedbackManager;
    public CinemachineVirtualCamera virtualCamera;
    public float shakeTime;
    public float shakeTotalTime;
    public float startingIntensity;


    private void Awake()
    {
        sFeedbackManager = this;
    }

    public void ScreenShake(float intensity, float time)
    {
        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin =
            virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = intensity;
        shakeTime = time;
        shakeTotalTime = time;
        startingIntensity = intensity;
    }
    // Update is called once per frame
    void Update()
    {
        if(shakeTime >0)
        {
            shakeTime -= Time.deltaTime;

            if(shakeTime <= 0)
            {
                 CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin =
            virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
                 cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = Mathf.Lerp(startingIntensity, 0f, (1-(shakeTime / shakeTotalTime)));
            }


        }
       
    }
}
