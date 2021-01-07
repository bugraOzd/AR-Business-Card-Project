using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCanvas : MonoBehaviour
{
    public GameObject canvas;
    public bool isEnabled = false;

    public void toggleCanvas()
    {
        isEnabled = !isEnabled;
        canvas.SetActive(isEnabled);
    }

}
