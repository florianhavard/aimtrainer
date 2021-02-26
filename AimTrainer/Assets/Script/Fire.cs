using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    
    public GameObject shot;
    public GameObject shotspawn;
    public float FireRate=1;
    private float nextFireTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetButtonUp("Fire1") && Time.time > nextFireTime)
        {
            Instantiate(shot, shotspawn.transform.position, shotspawn.transform.rotation);
            nextFireTime = Time.time + FireRate;
        }

    }
}
