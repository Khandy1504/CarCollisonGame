using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public Vector3 offsetF = new Vector3(-0.13f, 1.22f, -1.06f);
    public Vector3 offsetT = new Vector3(0, 5, -7);
    private float set;

    // Start is called before the first frame update
    void Start()
    {
        SetTPP();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        if (Input.GetKeyDown("c") && set == 0f)
        {
            SetFPP();
        }
        else if (Input.GetKeyDown("c") && set == 1f)
        {
            SetTPP();
        }
    }

    void SetFPP()
    {
        offset = offsetF;
        set = 1f;
    }

    void SetTPP()
    {
        offset = offsetT;
        set = 0f;
    }
}
