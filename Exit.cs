using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour
{
   public void MoveToScene2(){
    SceneManager.LoadSceneAsync(2);
   }
}
