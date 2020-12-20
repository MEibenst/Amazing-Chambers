using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
   public void LoadLevelByName(string name)
    {
        SceneManager.LoadSceneAsync(name);
        Time.timeScale = 1;
    }

    public void LoadFinal()
    {
        string ending = GameManager.getInstance().flowchart.GetStringVariable("Ending");
        if(ending == "Cross")
        {
            SceneManager.LoadSceneAsync("FinalCross");
        }
        else if(ending == "Heart"){
            SceneManager.LoadSceneAsync("FinalHeart");
        }
        else if(ending == "Knive")
        {
            SceneManager.LoadSceneAsync("FinalKnive");
        }
    }


}
