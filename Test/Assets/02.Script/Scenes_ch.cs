using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes_ch : MonoBehaviour
{
    public void InGame()
    {
        SceneManager.LoadScene("Ingame");
    }
    public void Title()
    {
        SceneManager.LoadScene("Title");
    }
    public void Stage()
    {
        SceneManager.LoadScene("Stage");
    }
}
