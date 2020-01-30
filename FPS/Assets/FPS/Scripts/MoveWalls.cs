using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWalls : MonoBehaviour
{

    public enum MoveType {
        x,
        y,
        z,
    }

    public MoveType moveType = MoveType.x;

    public float movePower = 1.0f;

    public float moveSpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = gameObject.transform.position;
        float sinNumber = Mathf.Sin(Time.time * moveSpeed) * movePower;
        switch(moveType){
            case MoveType.x:
                pos.x += sinNumber;
                break;
            case MoveType.y:
                pos.y += sinNumber;
                break;
            case MoveType.z:
                pos.z += sinNumber;
                break;
        }
        gameObject.transform.position = pos;
    }
}
