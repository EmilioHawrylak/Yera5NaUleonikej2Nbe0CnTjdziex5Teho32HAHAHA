using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;

public class Telephone : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    GameObject Contacts;
    private bool isOpen;
    enum what_choosen
    {
         Contacts
    };
    private what_choosen lol;
    public GameObject Contacts_panel;
    void Start()
    {
        animator = this.GetComponent<Animator>();
        Contacts = GameObject.Find("Main_panel");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isOpen = animator.GetBool("open");
            lol = what_choosen.Contacts;
            Image image = Contacts.GetComponent<Image>();
            Debug.Log(Contacts);
            image.color = Color.red;
            animator.SetBool("open", !isOpen);
            isOpen = animator.GetBool("open");
        }
        mechanic();
    }

    private void mechanic()
    {
        if (isOpen)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                // soon
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                // sooooon
            }
            else if (Input.GetKeyDown(KeyCode.Return) && lol == what_choosen.Contacts)
            {
                Contacts.SetActive(false);
                Contacts_panel.SetActive(true);
            }
        }
    }
}
