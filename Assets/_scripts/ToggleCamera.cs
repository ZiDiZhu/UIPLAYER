using UnityEngine;

//camera and lights too
public class ToggleCamera : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;

    public Camera currentCam;

    private void Start()
    {
        Cam2();
    }
    public void Cam1()
    {
        currentCam = cam1;
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
    }

    public void Cam2()
    {
        currentCam = cam2;
        cam1.enabled = false;
        cam2.enabled = true;
        cam3.enabled = false;
    }

    public void Cam3()
    {
        currentCam = cam3;
        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = true;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Cam1();
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Cam2();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Cam3();
        }
    }
}