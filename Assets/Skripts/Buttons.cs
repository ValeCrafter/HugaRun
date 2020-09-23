using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void World1()
    {
        SceneManager.LoadScene("World1");
    }

    public void WorldPicker()
    {
        SceneManager.LoadScene("LevelPicker");
    }
}
