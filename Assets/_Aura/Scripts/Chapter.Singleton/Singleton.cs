using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Singleton
{
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        #region Singleton Instance Setup
        //private instance of the constructed class
        private static T _instance;

        //public interface for accessing the instance globally
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<T>();
                    if (_instance == null)
                    {
                        _instance = new GameObject().AddComponent<T>();
                    }
                }
                return _instance;
            }
        }
        #endregion

        #region Singleton in Scene Setup
        public virtual void Awake()
        {
            if (_instance == null)
            {
                _instance = this as T;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
        #endregion
    } 
}
