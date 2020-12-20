using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BambooSpwaner : MonoBehaviour
{
    public GameObject knivePrefab;
    public float kniveSpeed = 5f;
    public float nextShot = 0f;
    public float shotDelay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextShot < Time.time)
        {
            Shooting();
            nextShot = nextShot + shotDelay;
        }
    }

    void Shooting()
    {
        GameObject bullet = Instantiate(knivePrefab, this.transform.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(this.transform.up * kniveSpeed, ForceMode2D.Impulse);
    }
}
