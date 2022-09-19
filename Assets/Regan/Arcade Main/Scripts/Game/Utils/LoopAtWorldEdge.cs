using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Regan {

public class LoopAtWorldEdge : MonoBehaviour
{
    Vector2 _worldBounds;


    void Start()
    {
        _worldBounds = GameManager.instance.worldBounds;
    }

    private void FixedUpdate()
    {
        Vector2 position = transform.position;

        if (position.x > _worldBounds.x)
        {
            transform.position = new Vector2(-_worldBounds.x + 0.1f, position.y);
        }
        else if (position.x < -_worldBounds.x)
        {
            transform.position = new Vector2(_worldBounds.x - 0.1f, position.y);
        }

        if (position.y > _worldBounds.y)
        {
            transform.position = new Vector2(position.x, -_worldBounds.y + 0.1f);
        }
        else if (position.y < -_worldBounds.y)
        {
            transform.position = new Vector2(position.x, _worldBounds.y - 0.1f);
        }
    }


}
}
