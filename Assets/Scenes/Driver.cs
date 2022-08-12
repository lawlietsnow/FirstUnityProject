using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("starting");

    }

    // Update is called once per frame
    void Update()
    {
        float steerValue = -Input.GetAxis("Horizontal") * Time.deltaTime * 300;
        float moveValue = Input.GetAxis("Vertical") * Time.deltaTime * 15;
        Debug.Log("steerValue" + steerValue.ToString());
        transform.Rotate(0, 0, steerValue);
        transform.Translate(0, moveValue, 0);
    }
}
