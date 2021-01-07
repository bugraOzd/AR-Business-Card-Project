using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public void onButtonClick(string link)
    {
        Application.OpenURL(link);
    }
}
