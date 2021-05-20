using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public GameObject explosions;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        var expFx = Instantiate(explosions, transform.position, transform.rotation);
        Destroy(expFx, 5);
        Destroy(gameObject);
    }
}
