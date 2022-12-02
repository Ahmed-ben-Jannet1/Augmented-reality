using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedIn : MonoBehaviour
{
    public void buttonFunction(string buttonLink)
    {
        Application.OpenURL(buttonLink);
    }
}
