using UnityEngine;
using Vuforia;

public class VbtnFn : MonoBehaviour

{

    public GameObject vbBtnObj;

    public GameObject obj1;

    void Start()

    {

        vbBtnObj = GameObject.Find("VirtualButton");

        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);

        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)

    {

        Debug.Log("Pressed");

        obj1.SetActive(true);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)

    {
        
        Debug.Log("Released");

        obj1.SetActive(false);

    }

    void Update()

    {

    }

}