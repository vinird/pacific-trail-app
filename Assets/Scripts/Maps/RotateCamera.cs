using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public GameObject gText;
    private Transform transform;
    private Gyroscope m_Gyro;
    private Quaternion rotation;

     void Awake()
    {
        //Set up and enable the gyroscope (check your device has one)
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
 
    }

    // Start is called before the first frame update
    void Start()
    {
        gText.GetComponent<UnityEngine.UI.Text>().text = "Gyro info will appear here";
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gText.GetComponent<UnityEngine.UI.Text>().text = "Gyro Y: " + Input.gyro.rotationRateUnbiased.y + " Gyro X: " + Input.gyro.rotationRateUnbiased.x + "Gyro Z: " + Input.gyro.rotationRateUnbiased.z + " Attitude: " + Input.gyro.attitude;

        rotation = Input.gyro.attitude;
        rotation.x = 90f;
        rotation.y = 0f;
        rotation.w = 0;

        print(rotation);
        
        transform.Rotate(0f, 0f, Input.gyro.rotationRateUnbiased.z, Space.Self);
    }
    
}
