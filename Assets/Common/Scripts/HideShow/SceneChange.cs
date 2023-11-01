using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void Scene0()
    {
        SceneManager.LoadScene("1-Menu");
    }
    public void Scene1()
    {
        SceneManager.LoadScene("1-Menu(Level Select)");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("3-GroundPlane");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("4-GroundPlane");
    }
    public void Scene4()
    {
        SceneManager.LoadScene("5-GroundPlane");
    }
    public void Scene5()
    {
        SceneManager.LoadScene("WaterTap");
    }
}
