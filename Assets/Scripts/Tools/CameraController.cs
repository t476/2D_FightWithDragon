using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

//因为PostProcessing包和渲染管线URP不兼容，所以用URP的GlobalVolume实现这个颜色变化的功能
public class CameraController : MonoBehaviour
{

    public GameObject guoduImage;
    Animator anim;
    public float time=1;
    private void Awake() {
        
    }
    void Start()
    {
        anim = guoduImage.GetComponent<Animator>();
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.P)){
            anim.enabled=true;
            Invoke("ChangeColor",time);
            anim.SetBool("Guodu", true);
        }
    }
    public void ChangeColor(){
        gameObject.GetComponent<Volume>().enabled=false;
    }
}
    

    


