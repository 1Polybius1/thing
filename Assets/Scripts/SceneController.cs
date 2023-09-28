using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

   public float timeToQuit = 2f;
   
   public void GoToScene(string sceneName)
   {
      SceneManager.LoadScene(sceneName);
   }

   public void GoToNextScene()
   {
      if (SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
         
      }
      else
      {
         SceneManager.LoadScene(0); 
      }
      
   }

   public void QuitGame()
   {
      Application.Quit();
   }

   public void Update()
   {
      if (Keyboard.current.escapeKey.wasPressedThisFrame)
      {
         timeToQuit = Time.time + 2f;
      }
      if (Keyboard.current.escapeKey.isPressed)
      {
         if (Time.time > timeToQuit)
         {
            QuitGame();
            print("Quitted");
         }
      }
   }
}
