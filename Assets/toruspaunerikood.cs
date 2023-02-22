using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toruspaunerikood : MonoBehaviour
{
    public GameObject toru;
    public float tekituskiirus = 2f;
    private float taimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        taimer += Time.deltaTime;
        if (taimer>tekituskiirus)
        {
            taimer = 0;
            Instantiate(toru, new Vector3(transform.position.x, transform.position.y+Random.Range(-1.5f, 1.5f), transform.position.z), transform.rotation);
        }
    }
}
