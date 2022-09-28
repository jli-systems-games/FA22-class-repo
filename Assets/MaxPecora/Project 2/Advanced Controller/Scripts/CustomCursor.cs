﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Max
{

    public class CustomCursor : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Cursor.visible = false;
        }

        // Update is called once per frame
        void Update()
        {
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = cursorPos;
        }
    }
}