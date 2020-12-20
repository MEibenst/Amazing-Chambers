using System.Collections;//
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform target;
    public float targetX;
    public float targetY;
    Rigidbody2D rb;
    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        target = this.transform;
        targetX = this.transform.position.x;
        targetY = this.transform.position.y;
        target.position = new Vector3(targetX, targetY, -10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (target.position.x != this.transform.position.x && target.position.x != this.transform.position.x)
        {
            Debug.Log(target.position);
            Debug.Log(transform.position);
           // rb.MovePosition(rb.position + new Vector2(targetX, targetY) * Time.fixedDeltaTime);
            
            transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime);
        }
    }

    public void setTarget(Transform target)
    {
        this.target = target;
        targetX = target.position.x;
        targetY = target.position.y;
        this.target.position = new Vector3(targetX, targetY, -10);
    }
}
