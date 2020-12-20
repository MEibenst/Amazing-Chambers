using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomChanger : MonoBehaviour
{
    [SerializeField]
    Transform cameraTarget;
    [SerializeField]
    Transform playerSpawnPoint;
    [SerializeField]
    MoveCamera moveCamera;
    [SerializeField]
    GameObject player;
    [SerializeField]
    string dialogName;
    public string thisRoom;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //moveCamera.setTarget(target);
            moveCamera.transform.position = new Vector3(cameraTarget.position.x, cameraTarget.position.y, -10);
            player.transform.position = playerSpawnPoint.position;
            Debug.Log(cameraTarget.gameObject.name);
            player.GetComponent<PlayerController>().setLastSpawnPoint(playerSpawnPoint.position);
            if (cameraTarget.gameObject.name == "InvertedRoom1" || cameraTarget.gameObject.name == "InvertedRoom2")
            {
                player.GetComponent<PlayerController>().setActualController(new InvertedControls());
            }
            else if (cameraTarget.gameObject.name == "ShintoRoom")
            {
                player.GetComponent<PlayerController>().setActualController(new NormalControls());
            }
            if(dialogName != null)
            {
                player.GetComponent<PlayerController>().startDialog(dialogName);
            }
            if(cameraTarget.gameObject.name == "FinalRoom")
            {
                player.SetActive(false);
                string ending = GameManager.getInstance().flowchart.GetStringVariable("Ending");
                if (ending == "Knive") {
                    GameManager.getInstance().finalPinguin.GetComponent<Animator>().SetTrigger("KniveEnding");
                }
                else if (ending == "Heart")
                {
                    GameManager.getInstance().finalPinguin.GetComponent<Animator>().SetTrigger("HeartEnding");
                }
                else if (ending == "Cross")
                {
                    GameManager.getInstance().finalPinguin.GetComponent<Animator>().SetTrigger("CrossEnding");
                }
            }

            GameManager.getInstance().setLastVisitedRoom(thisRoom);
            this.GetComponent<AudioSource>().Play();
        }
    }
}
