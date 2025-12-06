using LoGaCulture.LUTE;
using UnityEngine;

public class ModelSceneSetup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("ModelSceneSetup.Start() begin");
        
        //try to find object of type MapCompletion
        Debug.Log("Searching for MapCompletion");
        var mapCompletion = FindAnyObjectByType<MapCompletion>();
        Debug.Log($"MapCompletion found: {(mapCompletion != null)}");

        if ( mapCompletion==null)
        {
            Debug.Log("MapCompletion is null, creating new GameObject and adding component");
            //spawn a new GameObject with MapCompletion component
            var mapCompletionObject = new GameObject("MapCompletion");
            Debug.Log($"Created GameObject: {mapCompletionObject.name}");
            mapCompletionObject.AddComponent<MapCompletion>();
            Debug.Log("Added MapCompletion component to new GameObject");

        }
        else
        {
            Debug.Log("MapCompletion exists, skipping creation");
            //mapCompletion.SyncFromTinySave();
            //StartCoroutine(mapCompletion.wait10AndCreateStones(1));
            Debug.Log("(Optional) SyncFromTinySave and coroutine are commented out");
        }

        Debug.Log("Searching for BasicFlowEngine");
        BasicFlowEngine basicFlowEngine = FindAnyObjectByType<BasicFlowEngine>();
        Debug.Log($"BasicFlowEngine found: {(basicFlowEngine != null)}");

        if (basicFlowEngine != null)
        {
            Debug.Log("Attempting to find node 'Spawn model'");
            Node node = basicFlowEngine.FindNode("Spawn model");
            Debug.Log($"Node 'Spawn model' found: {(node != null)}");
            var barnLocationVariable = basicFlowEngine.GetVariable("Barn");
            Debug.Log($"Variable 'Barn' found: {(barnLocationVariable != null)}");

            //if the event handler of the node is location one, set the location to barnLocationVariable
            if (node != null && barnLocationVariable != null)
            {
                Debug.Log("Node and variable are valid, checking event handler type");

                //get the node._EventHandler
                
                if (node._EventHandler is LocationClickEventHandler locationEventHandler)
                {
                    Debug.Log("Event handler is LocationClickEventHandler");
                    //var loc = locationEventHandler.Location;
                    //Debug.Log($"Location retrieved: {(loc != null)}");

                    //loc.locationRef = (LocationVariable)barnLocationVariable;
                    Debug.Log("Assigned loc.locationRef to 'Barn' variable");

                    //locationEventHandler.location = loc;

                }
                else
                {
                    Debug.Log($"Event handler is not LocationClickEventHandler. Actual type: {node._EventHandler?.GetType().Name ?? "null"}");
                }

            }
            else
            {
                Debug.Log("Node or 'Barn' variable missing; skipping locationRef assignment");
            }
        }
        else
        {
            Debug.Log("BasicFlowEngine not found; skipping node and variable setup");
        }

        Debug.Log("ModelSceneSetup.Start() end");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
