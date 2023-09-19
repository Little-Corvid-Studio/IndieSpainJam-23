using KBCore.Refs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeStar
{
    Simple, //1 conexion
    Double, //2 conexiones
    Triple, //3 conexiones
    Cuadruple, //4 conexiones
    Quintuple //5 conexiones
}
public class StarData :ValidatedMonoBehaviour
{
    [Header("Star Parameters")]
    [SerializeField] public TypeStar type;
    //array de booleanos del tamaño de la constelacion 
    //true si se tiene qu conectar para ser sol false en caso contrario
    [SerializeField] protected bool[] conections;
    [SerializeField] protected GameObject lineObj;

    protected List<NodeConnector> connectors = new List<NodeConnector>();

    private void Awake()
    {
        float rot = 360/(1+(int)type);
        if (type == TypeStar.Simple)
        {
            GameObject go = Instantiate(lineObj, transform.position + new Vector3(0, 0, 0), Quaternion.identity, this.transform);
        }
        else
        {
            for (int i = 0; i <= (int)type; i++)
            {
                GameObject go = Instantiate(lineObj, transform.position + new Vector3(0, 0.5f, 0), Quaternion.identity, null);
                transform.Rotate(new Vector3(0, 0, rot));
                go.transform.parent = this.transform;
                NodeConnector con= go.GetComponent<NodeConnector>();
                if(con != null) connectors.Add(con);
            }
        }
    }
    public bool[] getConnections()
    {
        return conections;
    }

}
