using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksDriver : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;

    [SerializeField] bool isRunning = false;

    void Start()
    {
    }

    void Update()
    {
        if (isRunning)
        {
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
            transform.position = newPos;
        }
    }

    public void SetIsRunning(bool run)
    {
        isRunning = run;
    }
}
