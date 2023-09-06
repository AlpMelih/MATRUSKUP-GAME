using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movableDoor : MonoBehaviour
{
    public GameObject Door;
    public float x;
    public float y;
    private int ControllerNumber;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Door.transform.position);
        Door.transform.position = Door.transform.position + new Vector3(x,y);
    }
}
