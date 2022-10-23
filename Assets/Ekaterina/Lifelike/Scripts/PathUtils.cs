using UnityEngine;
using System.Collections;

namespace Ekaterina {

public class PathUtils : MonoBehaviour {
    private UnityEngine.AI.NavMeshAgent agent;
    private Color c = Color.green;
    public void Start() {
        agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent> ();
    }

    public void Update() {
        StartCoroutine(DrawPath(agent.path));
    }

    IEnumerator DrawPath(UnityEngine.AI.NavMeshPath path) {
        yield return new WaitForEndOfFrame();
        path = agent.path;
        if (path.corners.Length < 2)yield return null;
        switch (path.status) {
        case UnityEngine.AI.NavMeshPathStatus.PathComplete:
                c = Color.green;
                break;
        case UnityEngine.AI.NavMeshPathStatus.PathInvalid:
                c = Color.red;
                break;
        case UnityEngine.AI.NavMeshPathStatus.PathPartial:
                c = Color.yellow;
                break;
        }
                
        Vector3 previousCorner = path.corners[0];
        
        int i = 1;
        while (i < path.corners.Length) {
            Vector3 currentCorner = path.corners[i];
            Debug.DrawLine(previousCorner, currentCorner, c,1);
            previousCorner = currentCorner;
            i++;
        }
    }
}
}