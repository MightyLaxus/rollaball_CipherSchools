using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    
    [Header("Player Movement")]
    // Start is called before the first frame update
    private Rigidbody _rb;
    //private GameplayUIManager _gameplayUIManager;
    //public GameObject gamePlayUIManager_GO;
    [SerializeField] private int _speed;
    [SerializeField] private int _score;
    
    [Header("Timer")]
    [SerializeField] private float _timeLeft;
    [SerializeField] private bool _timerOn = false;
    [SerializeField] private Text _timertext;
    


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
      
        
        //_gameplayUIManager = gamePlayUIManager_GO.GetComponent<GameplayUIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        _rb.AddForce(movement * _speed);
        if (_timerOn)
        {
            if(_timeLeft>0)
            {
                _timeLeft -= Time.deltaTime;
                UpdateTimer(_timeLeft);
            }
            else
            {
                Debug.Log("timer is 0");
                _timeLeft = 0;
                _timerOn = false;
                SceneManager.LoadScene(3);
            }
        }
        if(horizontal > 0 || vertical > 0)
        {
            _timerOn = true;
        }
            
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Pickable")
        {
            other.gameObject.SetActive(false);
            _score += 10;
            GameplayUIManager.instance._scoreText.text = "Score : " + _score;
        }
        if (_score >= 30)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void UpdateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        _timertext.text = string.Format("{0:00} : {1:00}" ,minutes ,seconds);
    }
}
