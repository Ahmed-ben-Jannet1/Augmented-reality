using UnityEngine;

using Vuforia;

public class FrontVb : MonoBehaviour

{

    public GameObject vbBtnObj;

    public GameObject obj1;

    void Start()

    {

        vbBtnObj = GameObject.Find("Virtual");

        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);

        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)

    {

        Debug.Log("Pressed");

        obj1.SetActive(false);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)

    {

        Debug.Log("Released");

        obj1.SetActive(true);

    }

    void Update()

    {

    }

}