using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Fliper : MonoBehaviour
{
    public Quaternion startRot;
    public float changeRotation;
    public bool isLeft;

    // Start is called before the first frame update
    void Start()
    {
        startRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        newInput();

      //  pushAction();
    }
    void newInput() {
        var current = Keyboard.current;

        // AÉLÅ[ÇÃì¸óÕèÛë‘éÊìæ
        if (isLeft)
        {
            if (current.aKey.isPressed)
            {
                transform.rotation = Quaternion.AngleAxis(startRot.y + changeRotation, Vector3.up);
            }
            if (!current.aKey.isPressed)
            {
                transform.rotation = Quaternion.AngleAxis(startRot.y, Vector3.up);
            }
            return;
        }
        if (!isLeft)
        {
            if (current.dKey.isPressed)
            {
                transform.rotation = Quaternion.AngleAxis(startRot.y - changeRotation, Vector3.up);
            }
            if (!current.dKey.isPressed)
            {
                transform.rotation = Quaternion.AngleAxis(startRot.y, Vector3.up);
            }
        }
    }
    void pushAction()
    {
        if (isLeft)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.rotation = Quaternion.AngleAxis(startRot.y + changeRotation, Vector3.up);
            }
            if (!Input.GetKey(KeyCode.A))
            {
                transform.rotation = Quaternion.AngleAxis(startRot.y, Vector3.up);
            }
            return;
        }
        if (!isLeft)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.AngleAxis(startRot.y - changeRotation, Vector3.up);
            }
            if (!Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.AngleAxis(startRot.y, Vector3.up);
            }
        }
    }
}
