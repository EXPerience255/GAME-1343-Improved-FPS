using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera vcam;
    [SerializeField] float shakeStrength;
    [SerializeField] float shakeLength;

    float shakeTimer = 0;

    private void Update()
    {
        if (shakeTimer > 0)
        {
            shakeTimer -= Time.deltaTime;
        }
        else
        {
            EndShake();
        }
    }

    [ContextMenu("Start Shake")]
    public void StartShake()
    {
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = shakeStrength;
        shakeTimer = shakeLength;
    }

    [ContextMenu("End Shake")]
    public void EndShake()
    {
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0f;
    }
}
