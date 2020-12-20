using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueController : MonoBehaviour
{
    public GameObject projectile;
    public float projectileSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shooting()
    {
        GameObject bullet = Instantiate(projectile, this.transform.position, this.transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(this.transform.up * projectileSpeed, ForceMode2D.Impulse);
    }

}
