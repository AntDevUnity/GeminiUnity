using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemNode : MonoBehaviour
{

    public List<GemPort> In = new List<GemPort>();
    public List<GemPort> Out = new List<GemPort>();

    public virtual void InitNode()
    {

    }

    public void AddOut(GemPort port,string name)
    {

        port.Name = name;
        Out.Add(port);

    }

    public void AddIn(GemPort port,string name)
    {

        port.Name = name;
        In.Add(port);

    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
