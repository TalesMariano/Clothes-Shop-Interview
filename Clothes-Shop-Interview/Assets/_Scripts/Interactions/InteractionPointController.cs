using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPointController : MonoBehaviour
{

    [SerializeField] private Vector3 nPosition;
    [SerializeField] private Vector3 sPosition;
    [SerializeField] private Vector3 ePosition;
    [SerializeField] private Vector3 wPosition;

    [SerializeField] private Transform point;


    private void Update()
    {
        switch (GetInputDirection())
        {
            case Directions.None:
                break;
            case Directions.North:
                SetPointNorth();
                break;
            case Directions.South:
                SetPointSouth();
                break;
            case Directions.East:
                SetPointEast();
                break;
            case Directions.West:
                SetPointWest();
                break;
        }

    }

        Directions GetInputDirection()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");


        if(x == 0 && y == 0)
        {
            return Directions.None;
        }else if(Mathf.Abs(x)> Mathf.Abs(y))
        {
            return x>0? Directions.East:Directions.West;
        }
        else
        {
            return y > 0 ? Directions.North : Directions.South;
        }
    }



    [ContextMenu("SetPointNorth")]
    void SetPointNorth()
    {
        point.position = transform.position + nPosition;
    }

    void SetPointSouth()
    {
        point.position = transform.position + sPosition;
    }

    [ContextMenu("SetPointEast")]
    void SetPointEast()
    {
        point.position = transform.position + ePosition;
    }

    void SetPointWest()
    {
        point.position = transform.position + wPosition;
    }


    void OnDrawGizmosSelected()
    {
        // Display the explosion radius when selected
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position + nPosition, .2f);
        Gizmos.DrawSphere(transform.position + sPosition, .2f);
        Gizmos.DrawSphere(transform.position + ePosition, .2f);
        Gizmos.DrawSphere(transform.position + wPosition, .2f);
    }


}


    public enum Directions
{
    None, 
    North,
    South,
    East,
    West
}
