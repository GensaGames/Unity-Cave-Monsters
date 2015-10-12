using UnityEngine;
using System.Collections;

public class RockFallTrigger : MonoBehaviour {

    public GameObject panelUI;
    public bool cur;

    private bool isShown = false;
    private Animator panelAnimator;

    private bool isWork = false;
	void Start () {
        panelAnimator = panelUI.GetComponent<Animator>();
	}
	

	void Update () {
	
	}


    public void ResumeGame() {
        Time.timeScale = 1.0f;
        panelAnimator.SetBool("IsUp", true);
    }

    void OnTriggerEnter2D(Collider2D collider) {

        if (collider.tag.Equals("PlayerCollider"))  {

            if (!isShown) {
                isShown = !isShown;
                collider.gameObject.GetComponent<CameraShake>().shake = 1.0f;
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                if (!isWork && cur)
                    Invoke("LoadUIPanel", 1.2f);
            }
          
        }

        
    }

    private void LoadUIPanel() {
        isWork = !isWork;
        panelAnimator.SetBool("FirstStart", true);        
    
    }

    private void animShow() {
        Time.timeScale = 0.0f;
    }
}
