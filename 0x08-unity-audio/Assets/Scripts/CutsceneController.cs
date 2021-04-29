using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    private Animator camAnim;
    public GameObject mainCamera;
    public GameObject player;
    public GameObject timer;

    public void Start()
    {
        camAnim = gameObject.GetComponent<Animator>();
    }

    public void Update()
    {
        if (camAnim.GetCurrentAnimatorStateInfo(0).IsName("Intro01"))
        {
            if (camAnim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
            {
                mainCamera.SetActive(true);
                player.GetComponent<PlayerController>().enabled = true;
                timer.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }

}
