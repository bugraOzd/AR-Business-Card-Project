using UnityEngine;
using Vuforia;

public class CameraScript : MonoBehaviour
{
    private bool isVuforiaStarted = false;

    void Start()
    {
        VuforiaARController vuforia = VuforiaARController.Instance;

        if(vuforia != null)
        {
            vuforia.RegisterVuforiaStartedCallback(StartAfterVuforia);
        }
    }

    private void StartAfterVuforia()
    {
        isVuforiaStarted = true;
        SetAutoFocus();
    }

    private void OnApplicationPause(bool isPaused)
    {
        if(!isPaused)
        {
            if(isVuforiaStarted)
            {
                SetAutoFocus();
            }
        }
    }

    private void SetAutoFocus()
    {
        if (CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO))
        {
            Debug.Log("Autofocus is set!");
        } 
        else
        {
            Debug.Log("Device does not support autofocus!");
        }
    }
}
