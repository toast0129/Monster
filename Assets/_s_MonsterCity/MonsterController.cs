using MirzaBeig.ParticleSystems.Demos;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public Animator animator;
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sphere.SetActive(true);
            CameraShake cameraShake = FindObjectOfType<CameraShake>();

            cameraShake.Add(0.4f, 10.0f, 0.4f, CameraShakeTarget.Position, CameraShakeAmplitudeCurve.FadeInOut25);
            cameraShake.Add(8.0f, 10.0f, 1.0f, CameraShakeTarget.Rotation, CameraShakeAmplitudeCurve.FadeInOut25);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetTrigger("Walk");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Jump");
        }
    }
}
