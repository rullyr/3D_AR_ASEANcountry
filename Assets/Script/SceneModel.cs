using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneModel : MonoBehaviour
{
    public void LoadScene(string scenename){
        SceneManager.LoadScene (scenename);
    }
}
