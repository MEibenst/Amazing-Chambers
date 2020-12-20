using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public Flowchart flowchart;
    [SerializeField]
    string lastVisitedRoom;
    public GameObject finalPinguin;

    private List<GameObject> collectedItems = new List<GameObject>();

    private void Start()
    {
        lastVisitedRoom = "StartRoom";
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public static GameManager getInstance()
    {
        return instance;
    }

    public void addItem(GameObject item)
    {
        collectedItems.Add(item);
    }

    public List<GameObject> getItemList()
    {
        return collectedItems;
    }

    public void setLastVisitedRoom(string lastVisited)
    {
        this.lastVisitedRoom = lastVisited;
    }

    public string getLastVisitedRoom()
    {
        return this.lastVisitedRoom;
    }

    public void restartLevel()
    {
        Debug.Log("Level1");
        SceneManager.LoadSceneAsync("Level1");
    }
}
