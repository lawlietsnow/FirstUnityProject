using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject driver;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.gameObject.transform.position = new Vector3(driver.transform.position.x, driver.transform.position.y, this.gameObject.transform.position.z);
    }
}
