using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameController.UIController
{
    public class AutoOpen : MonoBehaviour
    {
        public global::UIController controller;
        
        private void Start()
        {
            controller.Transition(() =>
            {
                SceneManager.LoadScene("Menu");
            });
        }
    }
}