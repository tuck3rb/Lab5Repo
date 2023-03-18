using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopDoingThat : MonoBehaviour
{
    public GameObject BigVegas;
    public GameObject SadIdle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SadIdle.transform.position != BigVegas.transform.position) {
            BigVegas.transform.position += (SadIdle.transform.position - BigVegas.transform.position);
        }
    }
}
