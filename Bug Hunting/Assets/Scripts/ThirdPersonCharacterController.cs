using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdPersonCharacterController : MonoBehaviour
{

    public float Speed;
    public Text countText;
    public Text winText;

    public Image grassHopper;
    public Image butterFly;
    public Image cicada;
    public Image cricket;
    public Image dragonFly;
    public Image herculesBeetle;
    public Image stagBeetle;
    public Image fireFly;
    public Image mantis;
    public Image locust;



    private int count;

    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
        butterFly.enabled = false;
        grassHopper.enabled = false;
        cicada.enabled = false;
        cricket.enabled = false;
        dragonFly.enabled = false;
        herculesBeetle.enabled = false;
        stagBeetle.enabled = false;
        fireFly.enabled = false;
        mantis.enabled = false;
        locust.enabled = false;
    }


    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Butter"))
        {
            other.gameObject.SetActive(false);
            butterFly.enabled = true;
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Grass"))
        {
            other.gameObject.SetActive(false);
            grassHopper.enabled = true;
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Locust"))
        {
            other.gameObject.SetActive(false);
            locust.enabled = true;
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Stag"))
        {
            other.gameObject.SetActive(false);
            stagBeetle.enabled = true;
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Fire"))
        {
            other.gameObject.SetActive(false);
            fireFly.enabled = true;
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Hercules"))
        {
            other.gameObject.SetActive(false);
            herculesBeetle.enabled = true;
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Mantis"))
        {
            other.gameObject.SetActive(false);
            mantis.enabled = true;
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Cricket"))
        {
            other.gameObject.SetActive(false);
            cricket.enabled = true;
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Dragon"))
        {
            other.gameObject.SetActive(false);
            dragonFly.enabled = true;
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Cicada"))
        {
            other.gameObject.SetActive(false);
            cicada.enabled = true;
            count = count + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "count: " + count.ToString();
        if (count >= 10)
        {
            winText.text = "All Bugs Caught!";
        }

    }
}
