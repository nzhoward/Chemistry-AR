using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ModelSwapper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            SwapModel();
        }
    }

    private void SwapModel()
    {
        //ObjectTracker tracker = (ObjectTracker) TrackerManager.Instance.GetTracker<ObjectTracker>();
        //DataSet active = tracker.GetActiveDataSets().GetEnumerator().Current;

        StateManager sm = TrackerManager.Instance.GetStateManager();
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours();

        if (activeTrackables != null)
        {   
            foreach (TrackableBehaviour tb in activeTrackables)
            {
                string name = tb.TrackableName;
                Debug.Log("THIS IS TRACKED: " + name);
                GameObject trackedGameObject = GameObject.Find("Oxygen Marker");
                Object.Destroy(trackedGameObject);
            }
            
        }
    }
}
