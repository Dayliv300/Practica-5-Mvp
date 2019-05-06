using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollIA : MonoBehaviour {

    Animator anim;

    public GameObject player;

    bool Asesinado = false;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        float distance = Vector3.Distance(transform.position, player.transform.position);
            anim.SetFloat("distance", distance);

        //anim.SetBool("Angulo", Mirar());

        Vector3 targetDir = player.transform.position - transform.position;
        float Angulo = Vector3.Angle(targetDir, transform.forward);
        anim.SetFloat("Angulo", Angulo);

        if (Asesinado)
        {
            anim.SetFloat("casa", distance);
        }
        
    }
    public void Escaparenemigo(bool escapa)
    {
        Asesinado = escapa;
        anim.SetBool("cristal",escapa);
    }
    public GameObject GetPlayer()
    {
        return player;
    }
    private bool Mirar()
    {
        RaycastHit hit;
        var direccionRayo = player.transform.position - transform.position;
        var distanciaActual = Vector3.Distance(transform.position, player.transform.position);

        if (distanciaActual > 20)
        {
            return false;
        }

        if (Vector3.Angle(direccionRayo,
            transform.forward) < 45)
        {
            if (Physics.Raycast(transform.position,
                direccionRayo, out hit))
            {
                if (hit.transform.tag == "Player")
                {
                    return true;
                }
            }
        }

        return false;
    }
    public void StartAtack()
    {

    }
}
