using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Utilities
{
    //[DefaultExecutionOrder(,)]
    public class ObjectPoolInitializer : MonoBehaviour
    {
        #region Temp
        //[Header("Temporary Things", order = 0)]
        #endregion

        #region Fields
        //[Header("Fields", order = 1)]
        
        #endregion

        #region Functions
        
        #endregion
        
        #region Methods
        void Start()
        {          
            Actions.OnSceneLoad.Invoke();
        }
      
        #endregion
    }
}
