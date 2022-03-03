using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.State
{
    /// <summary>
    /// This interface will be implemented by each of our
    /// concrete state classes
    /// </summary>
    public interface IBikeState
    {
        
        void Handle(BikeController bikeController);
    } 
}
