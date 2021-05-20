using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 80f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody shoot = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            shoot.velocity = transform.TransformDirection(new Vector3(0, speed,0));

            Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), shoot.GetComponent<Collider>()); //root代表根物件,也就是坦克本身
        }
    }
}
