using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SafaProjects
{
    public class GridTile : MonoBehaviour
    {
        public int x;
        public int z;

        public void SetCoordinates(int _x, int _z)
        {
            x = _x;
            z = _z;
            gameObject.name = $"GridCube ({x},{z})";
        }
        
        
    }
}