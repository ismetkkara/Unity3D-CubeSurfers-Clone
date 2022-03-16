using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haraket : MonoBehaviour
{
    [SerializeField] 
    private float ileriGitmeHizi;
    [SerializeField] 
    private float sagaSolaGitHizi;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal") * sagaSolaGitHizi * Time.deltaTime;
        this.transform .Translate(yatayEksen, 0, ileriGitmeHizi * Time.deltaTime);
    }
}
