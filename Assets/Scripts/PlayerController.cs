using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using Fungus;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    Vector2 movement;
    [SerializeField]
    float playerSpeed;
   /* [SerializeField]
    TileBase tilemapA;
    [SerializeField]
    TileBase tilemapB;
    [SerializeField]
    GameObject room_bootom;
    [SerializeField]
    GameObject room_Wall;*/
    Animator anim;
    [SerializeField]
    Flowchart dialogSystem;
    bool isDialogActive;
    IControls actualController;
    public Vector3 lastSpawnPoint;
    public GameObject menu;
    public bool playKnockKnock = false;
    public float playKnockKnockDelay = 6;
    public float playTime;

    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
        isDialogActive = true;
        dialogSystem.SendFungusMessage("StartDialog");
        actualController = new NormalControls();
    }

    public void playDialogKnock()
    {
        playTime = Time.time + playKnockKnockDelay;
        playKnockKnock = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(playKnockKnock && playTime < Time.time)
        {
            dialogSystem.SendFungusMessage("StartKnockKnock");
            playKnockKnock = false;
            
        }

        if (!isDialogActive)
        {
            movement = actualController.Update();
            anim.SetFloat("Horizontal", movement.x);
            anim.SetFloat("Vertical", movement.y);

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                menu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                menu.SetActive(false);
            }
        }
        /* Nur ein Test für das Switchen von Tiles
        if (Input.GetKeyDown(KeyCode.D)){
            Tilemap tilemap = room_bootom.GetComponent<Tilemap>();
            tilemap.SwapTile(tilemapA, tilemapB);

        }*/
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime * playerSpeed);
    }

    public void deactivateDialog()
    {
        isDialogActive = false;
        
    }

    public void activateDialog()
    {
        isDialogActive = true;
        movement.x = 0;
        movement.y = 0;
        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
    }

    public void setActualController(IControls controller)
    {
        this.actualController = controller;
    }

    public void setLastSpawnPoint(Vector3 position)
    {
        lastSpawnPoint = position;
    }

    public void resetPlayerToSpawnPoint()
    {
        Debug.Log("ResetPlayer");
        this.gameObject.transform.position = lastSpawnPoint;
    }

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.tag == "Projectile")
        {
            resetPlayerToSpawnPoint();
        }
    }

    public void startDialog(string dialogName) {
        dialogSystem.SendFungusMessage(dialogName);
    }
}
