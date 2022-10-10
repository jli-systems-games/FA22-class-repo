// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class LeanTweenTest : MonoBehaviour
// {
//     public GameObject sphereGO;
//     public float Y;
//     public float time;
//     private Material sphereMat;
//     public Color glowColor;

//     private void Awake()
//     {
//         //Vector3 targetPosition = sphereGO.transform.position + new Vector3(0, Y, 0);
//         //LeanTween.move(sphereGO, targetPosition, time)
//         //    .setLoopPingPong(-1) //-1 makes an infinite loop
//         //    .setEaseInElastic();

//         //var targetScale = sphereGO.transform.localScale * 2;
//         //LeanTween.scale(sphereGO, targetScale, 0.25f).setLoopPingPong(0); //makes it throb like a heart

//         sphereMat = sphereGO.GetComponent<MeshRenderer>().material;
//         sphereMat.EnableKeyword("_EMISSION");

//         var color = sphereMat.GetColor("_EmissionColor");
//         LeanTween.value(sphereGO, color, glowColor, 1.0f).setOnUpdate(UpdateColor).setLoopPingPong(0); //loops a color change

//     }

//     private void UpdateColor(Color color)
//     {
//         sphereMat.SetColor("_EmissionColor", color);
//     }


// }
