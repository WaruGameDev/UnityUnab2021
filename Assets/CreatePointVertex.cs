using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePointVertex : MonoBehaviour
{
    public GameObject objetoACrear;

    public MeshFilter mf;

    // Start is called before the first frame update
    void Start()
    {
        Matrix4x4 localToWorld = transform.localToWorldMatrix;

        for (int i = 0; i < mf.mesh.vertices.Length; ++i)
        {
            Vector3 world_v = localToWorld.MultiplyPoint3x4(mf.mesh.vertices[i]);
            Instantiate(objetoACrear, world_v, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
