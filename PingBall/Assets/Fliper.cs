using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Fliper : MonoBehaviour
{
    public Quaternion startRot;
    public float addRotation;
    public Quaternion changeRotation;
    public bool isLeft;

    // Start is called before the first frame update
    void Start()
    {
        startRot = this.gameObject.transform.rotation;
        changeRotation =  Quaternion.Euler(startRot.x, startRot.y+addRotation, startRot.z);
    }

    // Update is called once per frame
    void Update()
    {
        newInput();
    }
    void newInput() {
        var current = Keyboard.current;

        // AÉLÅ[ÇÃì¸óÕèÛë‘éÊìæ
        if (isLeft)
        {
            if (current.aKey.isPressed)
            {
                this.gameObject.transform.rotation = Quaternion.RotateTowards(startRot, changeRotation,(changeRotation.y/addRotation));
            }
            if (!current.aKey.isPressed)
            {
                this.gameObject.transform.rotation = Quaternion.AngleAxis(startRot.y, Vector3.up);
            }
            return;
        }
       
    }
  
}
