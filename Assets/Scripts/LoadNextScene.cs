using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    public void ChangeScene(int num){
    SceneManager.LoadScene(num);
}
}
