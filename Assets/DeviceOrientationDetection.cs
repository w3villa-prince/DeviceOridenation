using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeviceOrientationDetection : MonoBehaviour
{
    public TextMeshProUGUI _currentScreen;

    CurrentDeviceOrientationEnu _currentDeviceOrientationValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        CurrentDeviceOrientation();
        _currentScreen.text = _currentDeviceOrientationValue.ToString();

    }
    void CurrentDeviceOrientation()
    {
        Debug.Log("LoggetCall");
        if (Input.deviceOrientation == DeviceOrientation.Portrait)
        {
            _currentDeviceOrientationValue = CurrentDeviceOrientationEnu.Portrait;
            Debug.Log("Now We Are In Portrait Mode ");



        }
        else if (Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
        {
            _currentDeviceOrientationValue = CurrentDeviceOrientationEnu.PortraitUpsideDown;
            Debug.Log("Now We Are In Portrait Mode ");
        }
        else if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft)
        {
            _currentDeviceOrientationValue = CurrentDeviceOrientationEnu.LandscapeLeft;
            Debug.Log("Now We Are In Landscape Mode ");

        }
        else if (Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            _currentDeviceOrientationValue = CurrentDeviceOrientationEnu.LandscapeRight;
            Debug.Log("Now We Are In Landscape Mode ");
        }
        else if( Input.deviceOrientation==DeviceOrientation.Unknown)
        {
            Debug.Log("Now We Are In Unknow  Mode ");
        }

    }

    public enum CurrentDeviceOrientationEnu
    {
        None,
        Portrait,
        PortraitUpsideDown,
        LandscapeLeft,
        LandscapeRight
    }
}
