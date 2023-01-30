using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

namespace Mariana
{
    public class SoftBody : MonoBehaviour
    {
        #region Constants

        private const float splineOffset = 0.5f;
        
        #endregion
        
      /*  #region Fields
        [SerializeField] public SpriteShapeController spriteShape;
        [SerializeField] public Transform[] points;
        #endregion
        
        #region MonoBehavior Callbacks

        private void Awake()
        {
            _UpdateVerticies();
        }

        private void Update()
        {
            _UpdateVerticies();
        }
        #endregion
        
        #region privateMethods

        private void _UpdateVerticies()
        {
            for (int i = 0; i < points.Length - 1; i++)
            {
                Vector2 _vertex = points[i].localPosition;
                
                Vector2 _towardsCenter = (Vector2.zero - _vertex).normalized;
                
                float _colliderRadius = points[i].gameObject.GetComponent<CircleCollider2D>().radius;
                try
                { 
                    spriteShape.spline.SetPosition(i, (_vertex - _towardsCenter + _colliderRadius));
                    
                    
                } catch
                {
                    Debug.Log("too close");
                    spriteShape.spline.SetPosition(i, (_vertex - _towardsCenter + (_colliderRadius + splineOffset)));
                }
            }
     
        
        #endregion
           }*/
    }
}
