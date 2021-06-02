using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tryagainButScript : MonoBehaviour
{
    public void playgameAgain()
    {

        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
}
