using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chapter.Singleton
{
    public class GameManager : Singleton<GameManager>
    {
        [SerializeField] Logger _logger;
        //let's set up some dummy code to simulate GameManager shit
        private DateTime _sessionStartTime;
        private DateTime _sessionEndtime;

        private void Start()
        {
            //TODO:
            //-Load player save
            //-If no save, redirect player to registration scene
            //-Call backend and get daily challenge and rewards

            _sessionStartTime = DateTime.Now;
            _logger.LogDebugMessage("Game session start @: " + DateTime.Now, this);
        }

        private void OnApplicationQuit()
        {
            _sessionEndtime = DateTime.Now;

            TimeSpan timeDifference = _sessionEndtime.Subtract(_sessionStartTime);

            _logger.LogDebugMessage("Game session ended @: " + DateTime.Now, this);
            _logger.LogDebugMessage("Game sessioni lasted: " + timeDifference, this);
        }

        private void OnGUI()
        {
            if (GUILayout.Button("Next Scene"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    } 
}
