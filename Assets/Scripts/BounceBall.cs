using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBall : MonoBehaviour
{
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if()
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, Target.position, 1f);
        }
    }
}
