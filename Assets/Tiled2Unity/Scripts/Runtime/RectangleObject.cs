using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Tiled2Unity
{
    public class RectangleObject : Tiled2Unity.TmxObject
    {
        private void OnCollisionEnter2D(Collision2D col)
        {
            if (col.transform.tag == "Player" || col.transform.tag == "Enemy")
            {
                col.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }

}
